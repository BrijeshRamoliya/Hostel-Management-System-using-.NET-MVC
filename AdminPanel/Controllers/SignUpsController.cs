using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminPanel.Models;


namespace AdminPanel.Controllers
{
    //[Authorize]
    public class SignUpsController : Controller
    {
        private ModelSignup db = new ModelSignup();

        // GET: SignUps
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.SignUps.ToList());
        }

        // GET: SignUps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SignUp signUp = db.SignUps.Find(id);
            if (signUp == null)
            {
                return HttpNotFound();
            }
            return View(signUp);
        }

        // GET: SignUps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SignUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,Username,EmailId,Password,ConfirmPassword")] SignUp signUp)
        {
            if (ModelState.IsValid)
            {
                db.SignUps.Add(signUp);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(signUp);
        }

        // GET: SignUps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SignUp signUp = db.SignUps.Find(id);
            if (signUp == null)
            {
                return HttpNotFound();
            }
            return View(signUp);
        }

        // POST: SignUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,Username,EmailId,Password,ConfirmPassword")] SignUp signUp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(signUp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(signUp);
        }

        // GET: SignUps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SignUp signUp = db.SignUps.Find(id);
            if (signUp == null)
            {
                return HttpNotFound();
            }
            return View(signUp);
        }

        // POST: SignUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SignUp signUp = db.SignUps.Find(id);
            db.SignUps.Remove(signUp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Login()
        {
            return View();
        }
    

        [HttpPost]
        public ActionResult Login(SignUp credentials)
        {
            SignUp entity = new SignUp();
            var cr = db.SignUps.Where(x => x.EmailId == credentials.EmailId && x.Password == credentials.Password);
            //bool userExist = ModelSignup.SignUp.Any(x => x.EmailId == credentials.EmailId && x.Password == credentials.Password)
            if (cr != null)
            {
                return RedirectToAction("Index");
            }
           
             return View();
        }




        
        // Forgotpassword
        /*
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(string EmailId)
        {
            //verify Email Id
            //Generate Reset password link
            //Send Email

            string message = "";
            bool status = false;

            using (myDatabaseEntities  dc = new myDatabaseEntities())
            {
                var account = dc.Users.Where(a => a.EmailId == EmailId).FirstOrDefault();
                if(account != null)
                {
                    //send email for reset password
                }
                else
                {
                    message = "Account not found";
                }
            }
                return View();
        }

      */

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
