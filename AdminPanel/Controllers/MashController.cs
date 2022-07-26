using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPanel.Controllers
{
    public class MashController : Controller
    {
        // GET: Mash
        public ActionResult Mash()
        {
            return View();
        }

        // GET: Mash/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mash/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mash/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mash/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mash/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mash/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mash/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
