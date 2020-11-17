using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using tour.Models;
using tour.Repository.Tour;
using tour.Repository.DiaDiem;


namespace tour.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository.Repository repo;
        private readonly ITourRepo tourRepo;
        private readonly IDiaDiemRepo diadiemRepo;

        public HomeController(Repository.Repository repo,ITourRepo tourRepo,IDiaDiemRepo diadiemRepo)
        {
            this.repo = repo;
            this.tourRepo = tourRepo;
            this.diadiemRepo = diadiemRepo;
        }

        public IActionResult Index()
        {
            ViewBag.countTour = tourRepo.Count();
            ViewBag.countDiaDiem = diadiemRepo.Count();
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
