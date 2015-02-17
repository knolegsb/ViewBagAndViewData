using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagAndViewData.Models;

namespace ViewBagAndViewData.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            ViewBag.Message = "Test Page";
            ViewBag.Name = "Sean You";
            return View();
        }

        public ActionResult Test()
        {
            ViewData["message"] = "Test Page";
            ViewData["name"] = "Sean You";

            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Sean You";
            employee.Salary = 12000000;

            ViewData["emp"] = employee;
            return View();
        }
        //
        // GET: /Test/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Test/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Test/Create
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
        // GET: /Test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Test/Edit/5
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
        // GET: /Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Test/Delete/5
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
