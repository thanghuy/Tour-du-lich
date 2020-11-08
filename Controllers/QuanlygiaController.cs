using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tour.Models;

namespace tour.Controllers
{
    public class QuanlygiaController : Controller
    {
        private readonly ILogger<QuanlygiaController> _logger;
        private readonly tour.Repository.Gia.IGiaRepo _repo;
        public QuanlygiaController(ILogger<QuanlygiaController> logger, tour.Repository.Gia.IGiaRepo repo)
        {
            _repo = repo;
            _logger = logger;
        }

        public IActionResult index()
        {
            return View(_repo.GetAll());
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
                _logger.LogInformation(_repo.Add(gias).ToString());
            }
            return View();
        }
    }
}
