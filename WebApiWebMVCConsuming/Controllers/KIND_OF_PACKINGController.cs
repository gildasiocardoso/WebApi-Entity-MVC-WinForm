using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiWebMVCConsuming.Controllers
{
    public class KIND_OF_PACKINGController : Controller
    {
        // GET: KIND_OF_PACKING
        public ActionResult Index()
        {
            return View();
        }

        // GET: KIND_OF_PACKING/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KIND_OF_PACKING/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KIND_OF_PACKING/Create
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

        // GET: KIND_OF_PACKING/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KIND_OF_PACKING/Edit/5
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

        // GET: KIND_OF_PACKING/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KIND_OF_PACKING/Delete/5
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
