using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tour.Models;
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

        public ChiPhiController(ILoaiChiPhiRepo loaiChiPhiRepo,IDoanRepo doanRepo, Repository.Repository repo)
        {
            this.loaiChiPhiRepo = loaiChiPhiRepo;
            this.doanRepo = doanRepo;
            this.tourRepo = tourRepo;
            this.repo = repo;
        }

        [Route("ChiPhi/")]
        [Route("ChiPhi/{id?}")]
        public IActionResult Index(int? id)
        {
            ViewBag.Doans = doanRepo.GetAll();
            //IEnumerable<QuanLyChiPhi> QLCP = repo.GetGroupQL(id??0);
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.LoaiChiPhi = loaiChiPhiRepo.GetAll();
            return View();
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
    }
}