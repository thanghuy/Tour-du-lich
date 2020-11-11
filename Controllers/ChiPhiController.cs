using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace tour.Controllers
{
    public class ChiPhiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}