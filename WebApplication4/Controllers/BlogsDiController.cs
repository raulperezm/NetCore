using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class BlogsDiController : Controller
    {
        // GET: BlogsDi
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlogsDi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogsDi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogsDi/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogsDi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogsDi/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogsDi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogsDi/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}