using kiosko_ssms.Data.Entities;
using System;
using System.Collections.Generic;

namespace kiosko_ssms.Data.Migrations
{
    public class CustomerSeeder
    {
        public List<Customer> Customers { get; } = new List<Customer>
        {
            new Customer {Id = 1, Names = "CLIENTE", Surnames = "ORDINARIO",  Dni = "00000000", Email = "CLI@TIENDA.COM", Address = "AV. PERU 100", PhoneNumber = "999888777", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false},
            new Customer {Id = 2, Names = "MARIA ELVIRA", Surnames = "SALAZAR",  Dni = "01288776", Email = "MAFER@PROTONMAIL.COM", Address = "CALLE EL CHILE 2014", PhoneNumber = "494222399", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false},
            new Customer {Id = 3, Names = "JUAN CARLOS", Surnames = "BODOQUE",  Dni = "30514535", Email = "JUANCARLITOS@YAHOO.COM", Address = "AV. KIOSKO-SSMS 304", PhoneNumber = "996554102", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, IsDeleted = false},
        };
    }
}
