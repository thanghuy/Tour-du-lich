using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.DiaDiem;

namespace tour.Controllers
{
    public class DiadiemController : Controller
    {
        private readonly ILogger<DiadiemController> _logger;
        private readonly IDiaDiemRepo _repo;
        public DiadiemController(IDiaDiemRepo repo,ILogger<DiadiemController> logger)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult index()
        {
            return View();
        }
        public ViewResult ThemDiaDiem(){
            return View();
        }
        [HttpPost]
        public IActionResult ThemDiaDiem(DiaDiems diaDiems)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation(_repo.Add(diaDiems).ToString());
            }
            return View();
        }
    }
}
