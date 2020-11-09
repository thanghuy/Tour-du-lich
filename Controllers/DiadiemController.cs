using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.DiaDiem;

namespace tour.Controllers
{
    public class DiadiemController : Controller
    {
        private readonly IDiaDiemRepo diaDiemRepo;
        private readonly ILogger<DiadiemController> _logger;
        public DiadiemController(IDiaDiemRepo diaDiemRepo, ILogger<DiadiemController> logger)
        {
            this.diaDiemRepo = diaDiemRepo;
            _logger = logger;
        }

        public IActionResult index()
        {
            return View(diaDiemRepo.GetAll());
        }
        public ViewResult ThemDiaDiem(){
            return View();
        }
        [HttpPost]
        public IActionResult ThemDiaDiem(DiaDiems diaDiems)
        {
            if (ModelState.IsValid)
            {
                diaDiemRepo.Add(diaDiems);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
