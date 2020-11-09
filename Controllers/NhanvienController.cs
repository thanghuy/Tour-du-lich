using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.NhanVien;

namespace tour.Controllers
{
    public class NhanvienController : Controller
    {
        private readonly ILogger<NhanvienController> _logger;
        private readonly INhanVienRepo nhanVien;

        public NhanvienController(ILogger<NhanvienController> logger,INhanVienRepo nhanVien)
        {
            _logger = logger;
            this.nhanVien = nhanVien;
        }

        public IActionResult index()
        {
            return View(nhanVien.GetAll());
        }
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(NhanViens nv)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation(nhanVien.Add(nv).ToString());
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
