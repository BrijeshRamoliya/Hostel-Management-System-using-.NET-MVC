using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPanel.Controllers
{
    public class CalenderController : Controller
    {
        // GET: Calender
        public ActionResult Calender()
        {
            return View();
        }

        // GET: Calender/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calender/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calender/Create
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

        // GET: Calender/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calender/Edit/5
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

        // GET: Calender/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Calender/Delete/5
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
