using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.ChiTiet;
using tour.Repository.DiaDiem;
using tour.Repository.Gia;
using tour.Repository.Loai;
using tour.Repository.Tour;
using tour.ViewModels;

namespace tour.Controllers
{
    public class QuanlytourController : Controller
    {
        private readonly ILogger<QuanlytourController> _logger;
        private readonly ILoaiRepo loaiRepo;
        private readonly IDiaDiemRepo diaDiemRepo;
        private readonly ITourRepo tourRepo;
        private readonly IChiTietRepo chiTietRepo;
        private readonly IGiaRepo giaRepo;
        private int LastId;

        public QuanlytourController(ILogger<QuanlytourController> logger, ILoaiRepo loaiRepo, IDiaDiemRepo diaDiemRepo, ITourRepo tourRepo,IChiTietRepo chiTietRepo, IGiaRepo giaRepo)
        {
            _logger = logger;
            this.loaiRepo = loaiRepo;
            this.diaDiemRepo = diaDiemRepo;
            this.tourRepo = tourRepo;
            this.chiTietRepo = chiTietRepo;
            this.giaRepo = giaRepo;
        }

        public IActionResult index()
        { 
            return View(chiTietRepo.getAllChiTietTour());
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
        public IActionResult Create(ChiTietTourVM chiTietTourVM)
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

                LastId = tourRepo.AddAndGetLastId(tours);
                for(int i=0;i<DiaDiem.Length;i++)
                {
                    ChiTietTours chiTiet = new ChiTietTours()
                    {
                        TourId = LastId,
                        DiadiemId = Int32.Parse(DiaDiem[i]),
                        CtThutu = i
                    };
                    if (chiTietRepo.Add(chiTiet))
                    {
                        Console.WriteLine("Them dia diem thanh cong!");
                    }
                }
            }
            return RedirectToAction("index");
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.ThanhPho = diaDiemRepo.GetGroupNameCity();
            ViewBag.Loai = loaiRepo.GetAll();
            ChiTietTourVM chiTietTour = tourRepo.CreateNewTour(id ?? 1);
            return View(chiTietTour);
        }
        [HttpPost]
        public IActionResult Edit(ChiTietTourVM chiTietTourVM)
        {
            chiTietRepo.Delete(chiTietTourVM.TourId);
            tourRepo.Delete(chiTietTourVM.TourId);
            Create(chiTietTourVM);
            giaRepo.UpdateIdTour(chiTietTourVM, LastId);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            chiTietRepo.Delete(id);
            giaRepo.DeleteByTourId(id);
            tourRepo.Delete(id);
            return RedirectToAction("index");
        }
    }
}
