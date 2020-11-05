using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;

namespace tour.Controllers
{
    public class NhanvienController : Controller
    {
        private readonly ILogger<NhanvienController> _logger;

        public NhanvienController(ILogger<NhanvienController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
        {
            return View();
        }
        public IActionResult Create(){
            return View();
        }
    }
}
