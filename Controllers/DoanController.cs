using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tour.Services;

namespace tour.Controllers
{
    public class DoanController : Controller
    {
        private readonly DoanService _doanService;
        public DoanController(DoanService doanService)
        {
            _doanService = doanService;
        }
        // GET: DoanController
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: DoanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoanController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoanController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoanController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoanController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoanController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
