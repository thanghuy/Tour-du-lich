using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.ChiTiet;
using tour.Repository.DiaDiem;
using tour.Repository.Loai;
using tour.Repository.Tour;

namespace tour.Controllers
{
    public class QuanlytourController : Controller
    {
        private readonly ILogger<QuanlytourController> _logger;
        private readonly ILoaiRepo loaiRepo;
        private readonly IDiaDiemRepo diaDiemRepo;
        private readonly ITourRepo tourRepo;
        private readonly IChiTietRepo chiTietRepo;

        public QuanlytourController(ILogger<QuanlytourController> logger, ILoaiRepo loaiRepo, IDiaDiemRepo diaDiemRepo, ITourRepo tourRepo,IChiTietRepo chiTietRepo)
        {
            _logger = logger;
            this.loaiRepo = loaiRepo;
            this.diaDiemRepo = diaDiemRepo;
            this.tourRepo = tourRepo;
            this.chiTietRepo = chiTietRepo;
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
            var location = Request.Query["location"];
            return Json(new {Data = diaDiemRepo.FindByName(location)});
        }

        [HttpPost]
        public IActionResult Create(tour.ViewModels.ChiTietTourVM chiTietTourVM)
        {
            if (ModelState.IsValid)
            {
                Tours tours = new Tours() 
                {
                    Ten = chiTietTourVM.TenTour,
                    Mota = chiTietTourVM.Mota,
                    LoaiId = chiTietTourVM.IdLoai
                } ;
                string[] DiaDiem = chiTietTourVM.IdDiaDiem.Split(",");

                int LastId = tourRepo.AddAndGetLastId(tours);
                foreach(String id in DiaDiem)
                {
                    ChiTietTours chiTiet = new ChiTietTours()
                    {
                        TourId = LastId,
                        DiadiemId = Int32.Parse(id)
                    };
                    if (chiTietRepo.Add(chiTiet))
                    {
                        Console.WriteLine("Them dia diem thanh cong!");
                    }
                }
            }
            return Redirect("index");
        }
    }
}
