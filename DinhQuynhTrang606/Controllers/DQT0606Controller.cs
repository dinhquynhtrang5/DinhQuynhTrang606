using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DinhQuynhTrang606.Data;
using DinhQuynhTrang606.Models;

namespace DinhQuynhTrang606.Controllers
{
    public class DQT0606Controller : Controller
    {
        private readonly DinhQuynhTrang606Context _context;

        public DQT0606Controller(DinhQuynhTrang606Context context)
        {
            _context = context;
        }

        // GET: DQT0606
        public async Task<IActionResult> Index()
        {
              return View(await _context.DQT0606.ToListAsync());
        }

        // GET: DQT0606/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.DQT0606 == null)
            {
                return NotFound();
            }

            var dQT0606 = await _context.DQT0606
                .FirstOrDefaultAsync(m => m.DQTId == id);
            if (dQT0606 == null)
            {
                return NotFound();
            }

            return View(dQT0606);
        }

        // GET: DQT0606/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DQT0606/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DQTId,DQTName,DQTGender")] DQT0606 dQT0606)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dQT0606);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dQT0606);
        }

        // GET: DQT0606/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.DQT0606 == null)
            {
                return NotFound();
            }

            var dQT0606 = await _context.DQT0606.FindAsync(id);
            if (dQT0606 == null)
            {
                return NotFound();
            }
            return View(dQT0606);
        }

        // POST: DQT0606/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("DQTId,DQTName,DQTGender")] DQT0606 dQT0606)
        {
            if (id != dQT0606.DQTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dQT0606);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DQT0606Exists(dQT0606.DQTId))
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
            return View(dQT0606);
        }

        // GET: DQT0606/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.DQT0606 == null)
            {
                return NotFound();
            }

            var dQT0606 = await _context.DQT0606
                .FirstOrDefaultAsync(m => m.DQTId == id);
            if (dQT0606 == null)
            {
                return NotFound();
            }

            return View(dQT0606);
        }

        // POST: DQT0606/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.DQT0606 == null)
            {
                return Problem("Entity set 'DinhQuynhTrang606Context.DQT0606'  is null.");
            }
            var dQT0606 = await _context.DQT0606.FindAsync(id);
            if (dQT0606 != null)
            {
                _context.DQT0606.Remove(dQT0606);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DQT0606Exists(string id)
        {
          return _context.DQT0606.Any(e => e.DQTId == id);
        }
    }
}
