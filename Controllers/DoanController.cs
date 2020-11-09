using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Models.DTOs;
using tour.Repository.Doan;
using tour.Repository.Gia;
using tour.Repository.Tour;
using tour.ViewModels;

namespace tour.Controllers
{
    public class DoanController : Controller
    {
        private readonly IDoanRepo _doanService;
        private readonly ITourRepo tour;
        private readonly IGiaRepo gia;

        public DoanController(IDoanRepo doanService, ITourRepo tour, IGiaRepo gia)
        {
            _doanService = doanService;
            this.tour = tour;
            this.gia = gia;
        }
        // GET: DoanController
        public ActionResult Index()
        {

            return View(_doanService.GetAll());
        }
        [HttpGet]
        public int getGia()
        {
            var id = Request.Query["id"];
            return gia.Get(Convert.ToInt32(id)).Sotien;
        }
        public ActionResult themdoan()
        {
            ViewBag.tour = tour.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult themdoan(Doans doans)
        {
            _doanService.Add(doans);
            return Redirect("Index"); 
        }
        public ActionResult themkhach()
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
