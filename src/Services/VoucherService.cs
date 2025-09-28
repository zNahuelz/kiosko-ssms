using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using kiosko_ssms.Data.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace kiosko_ssms.Services
{
    public class VoucherService
    {
        private readonly AppDbContext dbContext;

        public VoucherService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Voucher CreateVoucher(List<CartItem> cartItems, Customer customer, VoucherType voucherType, PaymentType paymentType, double change)
        {
            decimal igvValue = 0;
            decimal taxValue = (decimal)Properties.Settings.Default.taxValue;
            decimal subtotal = 0;
            decimal total = 0;

            foreach (CartItem cartItem in cartItems)
            {
                igvValue += (decimal)cartItem.Tax;
                total += (decimal)cartItem.Subtotal;
            }

            subtotal = total - igvValue;

            var voucher = new Voucher
            {
                Igv = (double)igvValue,
                Tax = (double)taxValue,
                Subtotal = (double)subtotal,
                Total = (double)total,
                Change = change,
                Paid = true,
                SaleSerial = Guid.NewGuid().ToString("N").Substring(0, 15),
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CustomerId = customer.Id,
                VoucherTypeId = voucherType.Id,
                PaymentTypeId = paymentType.Id,
                VoucherDetails = new List<VoucherDetail>()
            };

            foreach (CartItem cartItem in cartItems)
            {
                voucher.VoucherDetails.Add(new VoucherDetail
                {
                    Amount = cartItem.Amount,
                    UnitPrice = (double)cartItem.Cost,
                    Subtotal = cartItem.Subtotal,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    ProductId = cartItem.Product.Id
                });

                var product = dbContext.Products.Find(cartItem.Product.Id);
                if (product != null)
                {
                    product.Stock -= cartItem.Amount;
                    if (product.Stock < 0)
                    {
                        product.Stock = 0;
                    }
                    dbContext.Products.Update(product);
                }
            }

            dbContext.Vouchers.Add(voucher);
            dbContext.SaveChanges();
            return voucher;
        }

        public List<Voucher> GetAllVouchers(bool showDeleted)
        {
            var vouchers = dbContext.Vouchers
                .Where(s => showDeleted || !s.IsDeleted)
                .Include(s => s.Customer)
                .Include(s => s.VoucherType)
                .Include(s => s.PaymentType)
                .Include(s => s.VoucherDetails)
                .ThenInclude(vd => vd.Product)
                .OrderByDescending(s => s.CreatedAt)
                .ToList();
            return vouchers;
        }

        public List<Voucher> GetVouchersById(int id, bool showDeleted)
        {
            var vouchers = dbContext.Vouchers
                .Where(s => (showDeleted || !s.IsDeleted) && s.Id == id)
                .Include(s => s.Customer)
                .Include(s => s.VoucherType)
                .Include(s => s.PaymentType)
                .Include(s => s.VoucherDetails)
                .ThenInclude(vd => vd.Product)
                .OrderByDescending(s => s.CreatedAt)
                .ToList();
            return vouchers;
        }

        public List<Voucher> GetVouchersByDNI(string dni, bool showDeleted)
        {
            var vouchers = dbContext.Vouchers
                .Where(s => (showDeleted || !s.IsDeleted) && s.Customer.Dni.Contains(dni))
                .Include(s => s.Customer)
                .Include(s => s.VoucherType)
                .Include(s => s.PaymentType)
                .Include(s => s.VoucherDetails)
                .ThenInclude(vd => vd.Product)
                .OrderByDescending(s => s.CreatedAt)
                .ToList();
            return vouchers;
        }

        public List<Voucher> GetVouchersByDate(DateTime date, bool showDeleted)
        {
            var vouchers = dbContext.Vouchers
                .Where(s => (showDeleted || !s.IsDeleted) && s.CreatedAt.Date == date.Date)
                .Include(s => s.Customer)
                .Include(s => s.VoucherType)
                .Include(s => s.PaymentType)
                .Include(s => s.VoucherDetails)
                .ThenInclude(vd => vd.Product)
                .OrderByDescending(s => s.CreatedAt)
                .ToList();
            return vouchers;
        }

        public List<VoucherType> GetAllVoucherTypes(bool showDeleted)
        {
            var voucherTypes = dbContext.VoucherTypes.Where(s => showDeleted || !s.IsDeleted).OrderBy(s => s.Name).ToList();
            return voucherTypes;
        }

        public List<VoucherType> GetVoucherTypesByName(string name)
        {
            var voucherTypes = dbContext.VoucherTypes
                .Where(s => s.Name.ToUpper() == name.ToUpper())
                .ToList();
            return voucherTypes;
        }

        public VoucherType CreateVoucherType(string name)
        {
            var voucherType = new VoucherType
            {
                Name = name.Trim().ToUpper(),
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            dbContext.VoucherTypes.Add(voucherType);
            dbContext.SaveChanges();
            return voucherType;
        }

        public VoucherType UpdateVoucherType(int id, string name, bool isDeleted)
        {
            var voucherType = dbContext.VoucherTypes.Find(id);
            if (voucherType != null)
            {
                voucherType.Name = name.Trim().ToUpper();
                voucherType.UpdatedAt = DateTime.Now;
                voucherType.IsDeleted = isDeleted;
                dbContext.VoucherTypes.Update(voucherType);
                dbContext.SaveChanges();
            }
            else
            {
                throw new Exception($"Voucher de ID: {id} no encontrado.");
            }
            return voucherType;
        }

        public VoucherType GetVoucherTypeById(int id)
        {
            var voucherType = dbContext.VoucherTypes.Find(id);
            return voucherType;
        }

        public List<Voucher> GetAllVouchersBetweenDates(DateTime startDate, DateTime endDate, bool showDeleted)
        {
            var vouchers = dbContext.Vouchers
                .Where(s => (showDeleted || !s.IsDeleted) && s.CreatedAt.Date >= startDate.Date && s.CreatedAt.Date <= endDate.Date)
                .Include(s => s.Customer)
                .Include(s => s.VoucherType)
                .Include(s => s.PaymentType)
                .Include(s => s.VoucherDetails)
                .ThenInclude(vd => vd.Product)
                .OrderByDescending(s => s.CreatedAt)
                .ToList();
            return vouchers;
        }
    }
}
