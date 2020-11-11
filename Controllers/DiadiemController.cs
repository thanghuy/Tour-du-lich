using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.ChiTiet;
using tour.Repository.DiaDiem;

namespace tour.Controllers
{
    public class DiadiemController : Controller
    {
        private readonly IDiaDiemRepo diaDiemRepo;
        private readonly ILogger<DiadiemController> _logger;
        private readonly IChiTietRepo chiTietRepo;

        public DiadiemController(IDiaDiemRepo diaDiemRepo, ILogger<DiadiemController> logger,IChiTietRepo chiTietRepo)
        {
            this.diaDiemRepo = diaDiemRepo;
            _logger = logger;
            this.chiTietRepo = chiTietRepo;
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
        public IActionResult Edit(int id)
        {
            return View(diaDiemRepo.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(DiaDiems diaDiems)
        {
            diaDiemRepo.Update(diaDiems);
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            diaDiemRepo.Delete(id);
            chiTietRepo.DeleteByDiaDiemId(id);
            return RedirectToAction("index");
        }

    }
}
