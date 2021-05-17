using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTuts.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext() : base("myconnection") { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}