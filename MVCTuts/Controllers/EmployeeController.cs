using MVCTuts.Contract.Response;
using MVCTuts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTuts.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
         private   CustomerContext context;
        public EmployeeController()
        {
            context = new CustomerContext();
        }
        public ActionResult Index()
        {
            
            List<Department> departments = context.Departments.ToList();         
            return View(departments);
        }
        public ActionResult GetEmployees(int id)
        {
            // var employees = context.Employees.Where(e => e.Department.Id == id);
            var employees = (from e in context.Employees
                             join
                             d in context.Departments
                             on e.Department.Id equals d.Id
                             where e.Department.Id == id
                             select new EmployeewithDeprtment()
                             {
                                 Id=e.Id,
                                 Name=e.Name,
                                 Gender=e.Gender,
                                 Email=e.Email,
                                 Address=e.Address,
                                 Dept=d.DeptName
                             }).ToList();
            return View(employees);
        }
    }
}