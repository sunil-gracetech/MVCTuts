using MVCTuts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTuts.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult upload(HttpPostedFileBase files)
        {
          
            string message = "";
            if(files!=null && files.ContentLength > 0)
            {             
                string path = "~/uploads/";
                string fullpath = Server.MapPath(path + files.FileName);
                files.SaveAs(fullpath);
                message = "File uploaded successfully ";
            }
            else
            {
                message = "Please select file";
            }
            ViewBag.message = message;
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            return View(ViewRoute.AboutRoute);
        }

        public ActionResult Contact()
        {
            return View(ViewRoute.ContactRoute);
        }
    }
}