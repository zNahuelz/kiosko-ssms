using kiosko_ssms.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace kiosko_ssms.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<VoucherDetail> VoucherDetails { get; set; }
        public DbSet<VoucherType> VoucherTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=kiosko.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(new Migrations.RoleSeeder().Roles);
            modelBuilder.Entity<User>().HasData(new Migrations.UserSeeder().Users);
            modelBuilder.Entity<Supplier>().HasData(new Migrations.SupplierSeeder().Suppliers);
            modelBuilder.Entity<Presentation>().HasData(new Migrations.PresentationSeeder().Presentations);
            modelBuilder.Entity<Product>().HasData(new Migrations.ProductSeeder().Products);
        }
    }
}
