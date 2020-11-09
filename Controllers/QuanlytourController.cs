using System.Diagnostics;
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
            ViewBag.ThanhPho = diaDiemRepo.GetAllNameCity();
            ViewBag.Loai = loaiRepo.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tours tours)
        {
            return View();
        }
    }
}
