using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Models.DTOs;
using tour.Repository.Doan;
using tour.Repository.Gia;
using tour.Repository.Khachhang;
using tour.Repository.Nguoidi;
using tour.Repository.NhanVien;
using tour.Repository.Tour;
using tour.ViewModels;

namespace tour.Controllers
{
    public class DoanController : Controller
    {
        private readonly IDoanRepo _doanService;
        private readonly ITourRepo tour;
        private readonly IGiaRepo gia;
        private readonly INguoidiRepo nguoidiRepo;
        private readonly IKhachhangRepo khachhangRepo;
        private readonly INhanVienRepo nhanVienRepo;

        public DoanController(IDoanRepo doanService, ITourRepo tour, IGiaRepo gia,INguoidiRepo nguoidiRepo,IKhachhangRepo khachhangRepo,INhanVienRepo nhanVienRepo
            )
        {
            _doanService = doanService;
            this.tour = tour;
            this.gia = gia;
            this.nguoidiRepo = nguoidiRepo;
            this.khachhangRepo = khachhangRepo;
            this.nhanVienRepo = nhanVienRepo;
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
            int iddoan = _doanService.Add(doans);
            nguoidiRepo.Add(new NguoiDis(){
                DoanId = iddoan,
                Danhsachnhanvien = "0",
                Danhsachkhach = "0"
            });
            return Redirect("Index"); 
        }
        [HttpPost]
        public IActionResult themkhach([FromBody]KhachHangs kh)
        {
            return Json(kh);
        }
        // GET: DoanController/Details/5
        public ActionResult Details(int id)
        {
            string strId = nguoidiRepo.getKH(id);
            string strIdnv = nguoidiRepo.getNV(id);
            ViewBag.kh = khachhangRepo.GetAll(strId);
            ViewBag.nv = nhanVienRepo.GetAllId(strIdnv);
            ViewBag.nvs = nhanVienRepo.GetAll();
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
