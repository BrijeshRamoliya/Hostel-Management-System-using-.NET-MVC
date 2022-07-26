using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AdminPanel.Controllers
{
    public class UserController : Controller
    {
        // GET: User

   
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult StudentForm()
        {
            return View();
        }
        
        public ActionResult Rating()
        {
            return View();
        }
        
        public ActionResult Complain()
        {
            return View();
        }

        public ActionResult FoodMenu()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}