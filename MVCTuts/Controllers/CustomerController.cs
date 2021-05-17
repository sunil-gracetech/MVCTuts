using MVCTuts.Contract.Request;
using MVCTuts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTuts.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer model)
        {
            if (ModelState.IsValid)
            {
                CustomerContext context = new CustomerContext();
                context.Customers.Add(model);
                ViewBag.message = "Customer created succesfully ";
                return View();
            }
            else
            {

                return View(model);
            }

            
        }
    }
}