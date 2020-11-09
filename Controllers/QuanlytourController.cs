using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.DiaDiem;
using tour.Repository.Loai;

namespace tour.Controllers
{
    public class QuanlytourController : Controller
    {
        private readonly ILogger<QuanlytourController> _logger;
        private readonly ILoaiRepo loaiRepo;
        private readonly IDiaDiemRepo diaDiemRepo;

        public QuanlytourController(ILogger<QuanlytourController> logger, ILoaiRepo loaiRepo, IDiaDiemRepo diaDiemRepo)
        {
            _logger = logger;
            this.loaiRepo = loaiRepo;
            this.diaDiemRepo = diaDiemRepo;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult Create()
        {
            //ViewData["Loai"] = loai.GetAll();
            ViewBag.ThanhPho = diaDiemRepo.GetGroupNameCity();
            ViewBag.Loai = loaiRepo.GetAll();
            return View();
        }
        
        [HttpGet]
        public JsonResult GetLocation()
        {
            return Json(new {Data = diaDiemRepo.FindByName("DakLak")});
        }

        [HttpPost]
        public IActionResult Create(Tours tours)
        {
            return View();
        }
    }
}
