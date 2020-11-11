using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tour.Models;

namespace tour.Controllers
{
    public class KhachHangsController : Controller
    {
        private readonly Tour_DBContext _context;

        public KhachHangsController(Tour_DBContext context)
        {
            _context = context;
        }

        // GET: KhachHangs
        public async Task<IActionResult> Index()
        {
            return View(await _context.KhachHangs.ToListAsync());
        }

        // GET: KhachHangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHangs = await _context.KhachHangs
                .FirstOrDefaultAsync(m => m.KhId == id);
            if (khachHangs == null)
            {
                return NotFound();
            }

            return View(khachHangs);
        }

        // GET: KhachHangs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KhachHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KhId,KhTen,KhSdt,KhNgaysinh,KhEmail,KhCmnd")] KhachHangs khachHangs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khachHangs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khachHangs);
        }

        // GET: KhachHangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHangs = await _context.KhachHangs.FindAsync(id);
            if (khachHangs == null)
            {
                return NotFound();
            }
            return View(khachHangs);
        }

        // POST: KhachHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KhId,KhTen,KhSdt,KhNgaysinh,KhEmail,KhCmnd")] KhachHangs khachHangs)
        {
            if (id != khachHangs.KhId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khachHangs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachHangsExists(khachHangs.KhId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(khachHangs);
        }

        // GET: KhachHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHangs = await _context.KhachHangs
                .FirstOrDefaultAsync(m => m.KhId == id);
            if (khachHangs == null)
            {
                return NotFound();
            }

            return View(khachHangs);
        }

        // POST: KhachHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var khachHangs = await _context.KhachHangs.FindAsync(id);
            _context.KhachHangs.Remove(khachHangs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhachHangsExists(int id)
        {
            return _context.KhachHangs.Any(e => e.KhId == id);
        }
    }
}
