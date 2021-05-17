using MVCTuts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTuts.Contract.Response
{
    public class EmployeeWithCustomerModel
    {
        public List<Customer> customers { get; set; }
        public List<Employees> employees { get; set; }
    }
}