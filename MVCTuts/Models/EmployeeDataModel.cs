using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTuts.Models
{
    public class EmployeeDataModel
    {
        public List<Customer> Customers;
        public EmployeeDataModel()
        {
            this.Customers = new List<Customer>()
            {
                new Customer(){Name="Abhishek",Gender="Male"},
                new Customer(){Name="Deepak",Gender="Male"},
                new Customer(){Name="Rehana",Gender="Male"},
                new Customer(){Name="Dheeraj",Gender="Male"}
            };

           
        }
    }
}