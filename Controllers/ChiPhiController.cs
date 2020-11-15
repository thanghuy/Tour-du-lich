using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tour.Models;
using tour.Repository.ChiPhi;
using tour.Repository.Doan;
using tour.Repository.LoaiChiPhi;
using tour.Repository.Tour;
using tour.ViewModels;

namespace tour.Controllers
{
    public class ChiPhiController : Controller
    {
        private readonly ILoaiChiPhiRepo loaiChiPhiRepo;
        private readonly IDoanRepo doanRepo;
        private readonly ITourRepo tourRepo;
        private readonly Repository.Repository repo;
        private readonly IChiPhiRepo chiPhiRepo;

        public ChiPhiController(ILoaiChiPhiRepo loaiChiPhiRepo,IDoanRepo doanRepo, Repository.Repository repo,IChiPhiRepo chiPhiRepo)
        {
            this.loaiChiPhiRepo = loaiChiPhiRepo;
            this.doanRepo = doanRepo;
            this.tourRepo = tourRepo;
            this.repo = repo;
            this.chiPhiRepo = chiPhiRepo;
        }

        [Route("ChiPhi/")]
        [Route("ChiPhi/{id?}")]
        [HttpGet]
        public IActionResult Index(int? id)
        {
            ViewBag.Doans = doanRepo.GetAll();
            int idDoan = id ?? 0;
            if (idDoan != 0)
            {
                return View(repo.GetChiTietHoaDon(idDoan));
            }
            return View(new List<ChiPhis>());
        }
        [HttpGet]
        public IActionResult Create(int? id)
        {
            ViewBag.LoaiChiPhi = loaiChiPhiRepo.GetAll();
            return View(repo.GetGroupQL(id??0));
        }
        [HttpPost]
        public IActionResult Create(QuanLyChiPhi quanLyChiPhi)
        {
            Console.WriteLine(chiPhiRepo.Add(quanLyChiPhi).ToString());
            return RedirectToAction("Index");
        }
        public IActionResult Createloai()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateloaiAsync(LoaiChiPhis loaiChiPhis)
        {
            if (ModelState.IsValid)
            {
                await loaiChiPhiRepo.AddAsync(loaiChiPhis);   
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            chiPhiRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}