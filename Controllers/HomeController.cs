using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.Repository.Tour;


namespace tour.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository.Repository repo;
        private readonly ITourRepo tourRepo;

        public HomeController(Repository.Repository repo,ITourRepo tourRepo)
        {
            this.repo = repo;
            this.tourRepo = tourRepo;
        }

        public IActionResult Index()
        {
           return View(repo.ThongKeAllTour());
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            ViewBag.Tour = tourRepo.GetAll();
            ViewBag.nameTour = tourRepo.Get(id);
            return View(repo.GetChiTietDoanhThu(id));
        }

    }
}
