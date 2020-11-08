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

        public INhanVienRepo Repo { get; }

        public NhanvienController(ILogger<NhanvienController> logger,INhanVienRepo repo)
        {
            _logger = logger;
            Repo = repo;
        }

        public IActionResult index()
        {
            return View(Repo.GetAll());
        }
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(NhanViens nv)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation(Repo.Add(nv).ToString());
            }
            return View();
        }
    }
}
