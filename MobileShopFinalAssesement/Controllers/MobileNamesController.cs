using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MobileShopFinalAssesement.Data;
using MobileShopFinalAssesement.Models;

namespace MobileShopFinalAssesement.Controllers
{
    public class MobileNamesController : Controller
    {
        private readonly MobileShopFinalAssesementContext _context;

        public MobileNamesController(MobileShopFinalAssesementContext context)
        {
            _context = context;
        }
        [Authorize]
        // GET: MobileNames
        public async Task<IActionResult> Index()
        {
            return View(await _context.MobileName.ToListAsync());
        }

        // GET: MobileNames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobileName = await _context.MobileName
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mobileName == null)
            {
                return NotFound();
            }

            return View(mobileName);
        }

        // GET: MobileNames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MobileNames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Mobile_Category")] MobileName mobileName)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mobileName);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mobileName);
        }

        // GET: MobileNames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobileName = await _context.MobileName.FindAsync(id);
            if (mobileName == null)
            {
                return NotFound();
            }
            return View(mobileName);
        }

        // POST: MobileNames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Mobile_Category")] MobileName mobileName)
        {
            if (id != mobileName.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mobileName);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MobileNameExists(mobileName.Id))
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
            return View(mobileName);
        }

        // GET: MobileNames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobileName = await _context.MobileName
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mobileName == null)
            {
                return NotFound();
            }

            return View(mobileName);
        }

        // POST: MobileNames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mobileName = await _context.MobileName.FindAsync(id);
            _context.MobileName.Remove(mobileName);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MobileNameExists(int id)
        {
            return _context.MobileName.Any(e => e.Id == id);
        }
    }
}
