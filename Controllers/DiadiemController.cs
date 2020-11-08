using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;

namespace tour.Controllers
{
    public class DiadiemController : Controller
    {
        private readonly ILogger<DiadiemController> _logger;

        public DiadiemController(ILogger<DiadiemController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ThemDiaDiem(){
            return View();
        }
    }
}
