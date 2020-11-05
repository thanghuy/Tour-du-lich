using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;

namespace tour.Controllers
{
    public class QuanlytourController : Controller
    {
        private readonly ILogger<QuanlytourController> _logger;

        public QuanlytourController(ILogger<QuanlytourController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
