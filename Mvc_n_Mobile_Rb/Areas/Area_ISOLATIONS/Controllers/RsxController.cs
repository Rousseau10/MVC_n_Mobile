using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_n_Mobile_Rb.Areas.Area_ISOLATIONS.Controllers
{
    public class RsxController : Controller
    {
        
       // MyTest view
        
        public ActionResult TestView()
        {
            return View();
        }
        
        // GET: /Area_ISOLATIONS/Rsx/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Area_ISOLATIONS/Rsx/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Area_ISOLATIONS/Rsx/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Area_ISOLATIONS/Rsx/Create

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

        //
        // GET: /Area_ISOLATIONS/Rsx/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Area_ISOLATIONS/Rsx/Edit/5

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

        //
        // GET: /Area_ISOLATIONS/Rsx/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Area_ISOLATIONS/Rsx/Delete/5

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
