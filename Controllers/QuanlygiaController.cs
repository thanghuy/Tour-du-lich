using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.Gia;

namespace tour.Controllers
{
    public class QuanlygiaController : Controller
    {
        private readonly ILogger<QuanlygiaController> _logger;
        private readonly IGiaRepo giaRepo;

        public QuanlygiaController(ILogger<QuanlygiaController> logger, IGiaRepo giaRepo)
        {
            _logger = logger;
            this.giaRepo = giaRepo;
        }

        public IActionResult index()
        {
            return View(giaRepo.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Gias gias)
        {
            if (ModelState.IsValid)
            {
                giaRepo.Add(gias);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
