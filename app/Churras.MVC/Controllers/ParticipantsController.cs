using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Churras.MVC.Controllers
{
    public class ParticipantsController : Controller
    {
        // GET: Participants
        public ActionResult Index()
        {
            return View();
        }

        // GET: Participants/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Participants/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Participants/Create
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

        // GET: Participants/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Participants/Edit/5
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

        // GET: Participants/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Participants/Delete/5
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
