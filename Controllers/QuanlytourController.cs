using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.Loai;

namespace tour.Controllers
{
    public class QuanlytourController : Controller
    {
        private readonly ILogger<QuanlytourController> _logger;
        private readonly ILoaiRepo loaiRepo;

        public QuanlytourController(ILogger<QuanlytourController> logger, ILoaiRepo loaiRepo)
        {
            _logger = logger;
            this.loaiRepo = loaiRepo;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult Create()
        {
            //ViewData["Loai"] = loai.GetAll();
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
