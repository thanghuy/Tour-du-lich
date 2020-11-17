using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
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
        public static int idND;
        public static int idTours;
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
            try
            {
             return gia.Get(Convert.ToInt32(id)).Sotien;   
            }
            catch (System.Exception ex)
            {
               return 0;
            }
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
        public IActionResult themkhachmoi([FromBody] KhachHangs kh)
        {
            int idkh = khachhangRepo.Add(kh);
            string list_kh = nguoidiRepo.getKH(idND);
            list_kh += "," + idkh;
            nguoidiRepo.UpdateKH(list_kh, idND);
            return Json(kh);
        }
        public ActionResult themkhach(){
            var idkh = Request.Query["idkh"];
            string list_kh = nguoidiRepo.getKH(idND);
            string[] list = list_kh.Split(",");
            bool result = false;
            foreach(var i in list){
                if(idkh == i){
                    result = false;
                    break;
                }
                else{
                    result = true;
                }
            }
            
            list_kh += ","+idkh;
            KhachHangs kh = null;
            if(result){
                nguoidiRepo.UpdateKH(list_kh,idND); 
                kh = khachhangRepo.Get(Convert.ToInt32(idkh));
            }
            return Json(kh);
        }
        public ActionResult xoakhachhang(){
            string idkh = Request.Query["idkh"];
            string list_kh = nguoidiRepo.getKH(idND);
            string[] list = list_kh.Split(',');
            int numIndex = Array.IndexOf(list,idkh);
            List<string> tmp = new List<string>(list);
            tmp.RemoveAt(numIndex);
            string newList = string.Join(",",tmp);
            nguoidiRepo.UpdateKH(newList,idND);
            return Json(null);
        }
        public ActionResult themnhanvien(){
            var idnv = Request.Query["idnv"];
            string list_nv = nguoidiRepo.getNV(idND);
            string[] list = list_nv.Split(",");
            bool result = false;
            foreach(var i in list){
                if(idnv == i){
                    result = false;
                    break;
                }
                else{
                    result = true;
                }
            }
            
            list_nv += ","+idnv;
            NhanViens kh = null;
            if(result){
                nguoidiRepo.UpdateNV(list_nv,idND); 
                kh = nhanVienRepo.Get(Convert.ToInt32(idnv));
            }
            return Json(kh);
        }
        public ActionResult xoanhanvien(){
            string idnv = Request.Query["idnv"];
            string list_nv = nguoidiRepo.getNV(idND);
            string[] list = list_nv.Split(',');
            int numIndex = Array.IndexOf(list,idnv);
            List<string> tmp = new List<string>(list);
            tmp.RemoveAt(numIndex);
            string newList = string.Join(",",tmp);
            nguoidiRepo.UpdateNV(newList,idND);
            return Json(null);
        }
        // GET: DoanController/Details/5
        public ActionResult Details(int id)
        {
            
            idND = id;
            string strId = nguoidiRepo.getKH(id);
            string strIdnv = nguoidiRepo.getNV(id);
            Doans d = _doanService.Get(id);
            idTours = d.TourId;
            ViewBag.doan = d;
            ViewBag.kh = khachhangRepo.GetAll(strId);
            ViewBag.nv = nhanVienRepo.GetAllId(strIdnv);
            ViewBag.nvs = nhanVienRepo.GetAll();
            ViewBag.khall = khachhangRepo.GetAlll();
            ViewBag.gia = gia.Get(Convert.ToInt32(d.TourId));
            ViewBag.slKh = nguoidiRepo.CountKH(strId);
            ViewBag.slNV = nguoidiRepo.CountNV(strIdnv);
            try
            {
                ViewBag.tongtien = tongTien();   
            }
            catch (System.Exception ex)
            {
               ViewBag.tongtien = 0;
            }
            ViewBag.tour = tour.Get(d.TourId);
            return View();
        }
        public int tongTien(){
            string strId = nguoidiRepo.getKH(idND);
            int giatour = gia.Get(idTours).Sotien;
            int slkh = nguoidiRepo.CountKH(strId);
            int total = giatour * slkh;
            return total;
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
            ViewBag.tour = tour.GetAll();
            return View(_doanService.Get(id));
        }

        // POST: DoanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Doans doans)
        {
            try
            {
                _doanService.Update(doans);
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
