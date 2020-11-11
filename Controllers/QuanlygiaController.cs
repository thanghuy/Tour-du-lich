using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.Gia;
using tour.Repository.Tour;

namespace tour.Controllers
{
    public class QuanlygiaController : Controller
    {
        private readonly ILogger<QuanlygiaController> _logger;
        private readonly IGiaRepo giaRepo;
        private readonly ITourRepo tourRepo;

        public QuanlygiaController(ILogger<QuanlygiaController> logger, IGiaRepo giaRepo, ITourRepo tourRepo)
        {
            _logger = logger;
            this.giaRepo = giaRepo;
            this.tourRepo = tourRepo;
        }

        [Route("Quanlygia/")]
        [Route("Quanlygia/{id?}")]
        public IActionResult index(int? id)
        {
            /*if (!id.HasValue)
            {
                return View(giaRepo.GetAll());
            }
            else
            {
                return View(giaRepo.GetAllGiasByIdLoai(id));
            }*/
            ViewBag.Tour = tourRepo.GetAll();
            return View(!id.HasValue ? giaRepo.GetAll() : giaRepo.GetAllGiasByIdLoai(id));

        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Tours = tourRepo.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Gias gias)
        {
            if (ModelState.IsValid)
            {
                giaRepo.Add(gias);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Tours = tourRepo.GetAll();
            return View(giaRepo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Gias GiaMoi)
        {
            if (ModelState.IsValid)
            {
                Gias GiaCu = giaRepo.Get(GiaMoi.GiaId);
                GiaCu.ToudId = GiaMoi.ToudId;
                GiaCu.Tungay = GiaMoi.Tungay;
                GiaCu.Denngay = GiaMoi.Denngay;
                GiaCu.Sotien = GiaMoi.Sotien;
                giaRepo.Update(GiaCu);
            }
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            giaRepo.Delele(id);
            return RedirectToAction("index");
        }
    }
}
