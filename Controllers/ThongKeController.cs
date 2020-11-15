using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tour.Repository.Tour;

namespace tour.Controllers
{

    public class ThongKeController : Controller
    {
        private readonly Repository.Repository repo;
        private readonly ITourRepo tourRepo;

        public ThongKeController(Repository.Repository repo,ITourRepo tourRepo)
        {
            this.repo = repo;
            this.tourRepo = tourRepo;
        }
        // GET: ThongKeController
        public ActionResult Index()
        {
            return View(repo.ThongKeAllTour());
        }

        // GET: ThongKeController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            ViewBag.Tour = tourRepo.GetAll();
            return View(repo.GetChiTietDoanhThu(id));
        }

        // GET: ThongKeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThongKeController/Create
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

        // GET: ThongKeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThongKeController/Edit/5
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

        // GET: ThongKeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThongKeController/Delete/5
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
