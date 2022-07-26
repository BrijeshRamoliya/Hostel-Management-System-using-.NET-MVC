using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPanel.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Signup()
        {
            return View();
        }

       
        //POST
        [HttpPost]
        public ActionResult Signup(SignUp si)
        {
            using (var context = new HostelManagementSystemEntities1())
            {
                context.SignUp.Add(si);
                context.SaveChanges();
            }
            return RedirectToAction("Signin");
        }

        public ActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signin(Signin sgn)
        {
            using (var context = new HostelManagementSystemEntities1())
            {
                bool isValid = context.SignUp.Any(x => x.EmailId == sgn.Emailid && x.Password == sgn.Password);
                if (isValid)
                {
                    //FormsAuthentication.SetAuthCookie(log.L_Email, false);  //false for stay not save and true for stay login
                    ModelState.AddModelError("", sgn.Emailid);
                    Session["uemail"] = sgn.Emailid;
                    var Fname = context.SignUp.Where(x => x.EmailId == sgn.Emailid).FirstOrDefault();
                    //var Lname = context.Signup.Where(x => x.S_Email == log.L_Email);
                    
                    return RedirectToAction("Home", "User");
                    //return View();
                }
                ModelState.AddModelError("", "Invalid Email Or Password");

                return View();

            }
        }

        

       
    }


    
}