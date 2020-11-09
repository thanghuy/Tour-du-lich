using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;
using tour.Repository.Gia;
using tour.Repository.Tour;

namespace tour.Controllers
{
    public class QuanlygiaController : Controller
    {
        private readonly ILogger<QuanlygiaController> _logger;
        private readonly IGiaRepo giaRepo;
        private readonly ITourRepo tourRepo;

        public QuanlygiaController(ILogger<QuanlygiaController> logger, IGiaRepo giaRepo, ITourRepo tourRepo)
        {
            _logger = logger;
            this.giaRepo = giaRepo;
            this.tourRepo = tourRepo;
        }

        public IActionResult index()
        {
            return View(giaRepo.GetAll());
        }
        public IActionResult Create()
        {
            ViewBag.Tours = tourRepo.GetAll();
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
