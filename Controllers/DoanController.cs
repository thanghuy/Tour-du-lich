using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tour.Models.DTOs;
using tour.Services.Doan;
using tour.ViewModels;

namespace tour.Controllers
{
    public class DoanController : Controller
    {
        private readonly IDoanService _doanService;
        private readonly IMapper _mapper;
        public DoanController(IDoanService doanService, IMapper mapper)
        {
            _mapper = mapper;
            _doanService = doanService;
        }
        // GET: DoanController
        public ActionResult Index()
        {
            // if (!ModelState.IsValid)
            // {
            //     return View();
            // }
            // else
            // {
            //     List<DoanDTO> src = _doanService.GetAll();
            //     var list = _mapper.Map<List<DoanDTO>, List<DoanViewModel>>(src);
            //     return View("Index", list);
            // }

            return View();
        }
        public ActionResult themdoan()
        {
            return View();
        }
        public ActionResult themkhach()
        {
            return View();
        }
        // GET: DoanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoanController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoanController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoanController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoanController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoanController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
