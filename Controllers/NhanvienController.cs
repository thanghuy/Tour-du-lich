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
        private readonly INhanVienRepo nhanVienRepo;

        public NhanvienController(ILogger<NhanvienController> logger,INhanVienRepo nhanVienRepo)
        {
            _logger = logger;
            this.nhanVienRepo = nhanVienRepo;
        }

        public IActionResult index()
        {
            return View(nhanVienRepo.GetAll());
        }
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(NhanViens nv)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation(nhanVienRepo.Add(nv).ToString());
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            return View(nhanVienRepo.Get(id));
        }
    }
}
