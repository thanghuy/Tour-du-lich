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
        private readonly ILoaiRepo loai;

        public QuanlytourController(ILogger<QuanlytourController> logger, ILoaiRepo loai)
        {
            _logger = logger;
            this.loai = loai;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult Create()
        {
            //ViewData["Loai"] = loai.GetAll();
            ViewBag.Loai = loai.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tours tours)
        {
            return View();
        }
    }
}
