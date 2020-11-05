using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;

namespace tour.Controllers
{
    public class QuanlygiaController : Controller
    {
        private readonly ILogger<QuanlygiaController> _logger;

        public QuanlygiaController(ILogger<QuanlygiaController> logger)
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
