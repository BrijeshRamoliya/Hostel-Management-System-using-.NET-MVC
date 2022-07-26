using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminPanel;

namespace AdminPanel.Controllers
{
    public class ComplainFormsController : Controller
    {
        private HostelManagementSystemEntities2 db = new HostelManagementSystemEntities2();

        // GET: ComplainForms
        public ActionResult Index()
        {
            return View(db.ComplainForms.ToList());
        }

        // GET: ComplainForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComplainForm complainForm = db.ComplainForms.Find(id);
            if (complainForm == null)
            {
                return HttpNotFound();
            }
            return View(complainForm);
        }

        // GET: ComplainForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComplainForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,RoomNo,Subject,Message")] ComplainForm complainForm)
        {
            if (ModelState.IsValid)
            {
                db.ComplainForms.Add(complainForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(complainForm);
        }

        // GET: ComplainForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComplainForm complainForm = db.ComplainForms.Find(id);
            if (complainForm == null)
            {
                return HttpNotFound();
            }
            return View(complainForm);
        }

        // POST: ComplainForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,RoomNo,Subject,Message")] ComplainForm complainForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(complainForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(complainForm);
        }

        // GET: ComplainForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComplainForm complainForm = db.ComplainForms.Find(id);
            if (complainForm == null)
            {
                return HttpNotFound();
            }
            return View(complainForm);
        }

        // POST: ComplainForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComplainForm complainForm = db.ComplainForms.Find(id);
            db.ComplainForms.Remove(complainForm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
