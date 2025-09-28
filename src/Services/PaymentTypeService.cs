using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace kiosko_ssms.Services
{
    public class PaymentTypeService
    {
        private readonly AppDbContext dbContext;

        public PaymentTypeService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<PaymentType> GetAllPaymentTypes(bool showDeleted)
        {
            var paymentTypes = dbContext.PaymentTypes.Where(c => showDeleted || !c.IsDeleted).OrderBy(c => c.Name).ToList();
            return paymentTypes;
        }

        public List<PaymentType> GetPaymentTypesByName(string name)
        {
            var paymentTypes = dbContext.PaymentTypes
                .Where(c => c.Name.ToUpper() == name.ToUpper())
                .ToList();
            return paymentTypes;
        }

        public PaymentType GetPaymentTypeById(int id)
        {
            var paymentType = dbContext.PaymentTypes.Find(id);
            return paymentType;
        }

        public PaymentType UpdatePaymentType(int id, string name, bool isDeleted)
        {
            var paymentType = dbContext.PaymentTypes.Find(id);
            if (paymentType != null)
            {
                paymentType.Name = name.Trim().ToUpper();
                paymentType.IsDeleted = isDeleted;
                paymentType.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
            }
            return paymentType;
        }

    }
}
