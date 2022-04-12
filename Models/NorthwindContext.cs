using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Northwind_.Models;
using System.Linq;
using Northwind_.Models;

namespace Northwind_.Models
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        
        public DbSet<Discount> Discounts { get; set; }
        
        public DbSet<Customer> Customers { get; set; }

        public void AddCustomer(Customer customer)
        {
            this.Add(customer);
            this.SaveChanges();
        }
        public void EditCustomer(Customer customer)
        {
            var customerToUpdate = Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            customerToUpdate.Address = customer.Address;
            customerToUpdate.City = customer.City;
            customerToUpdate.Region = customer.Region;
            customerToUpdate.PostalCode = customer.PostalCode;
            customerToUpdate.Country = customer.Country;
            customerToUpdate.Phone = customer.Phone;
            customerToUpdate.Fax = customer.Fax;
            SaveChanges();
        }
    }
}