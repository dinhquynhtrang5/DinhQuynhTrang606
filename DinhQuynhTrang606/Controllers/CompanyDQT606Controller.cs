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
    public class CompanyDQT606Controller : Controller
    {
        private readonly DinhQuynhTrang606Context _context;

        public CompanyDQT606Controller(DinhQuynhTrang606Context context)
        {
            _context = context;
        }

        // GET: CompanyDQT606
        public async Task<IActionResult> Index()
        {
              return View(await _context.CompanyDQT606.ToListAsync());
        }

        // GET: CompanyDQT606/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyDQT606 == null)
            {
                return NotFound();
            }

            var companyDQT606 = await _context.CompanyDQT606
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyDQT606 == null)
            {
                return NotFound();
            }

            return View(companyDQT606);
        }

        // GET: CompanyDQT606/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyDQT606/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyDQT606 companyDQT606)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyDQT606);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyDQT606);
        }

        // GET: CompanyDQT606/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyDQT606 == null)
            {
                return NotFound();
            }

            var companyDQT606 = await _context.CompanyDQT606.FindAsync(id);
            if (companyDQT606 == null)
            {
                return NotFound();
            }
            return View(companyDQT606);
        }

        // POST: CompanyDQT606/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyDQT606 companyDQT606)
        {
            if (id != companyDQT606.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyDQT606);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyDQT606Exists(companyDQT606.CompanyId))
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
            return View(companyDQT606);
        }

        // GET: CompanyDQT606/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyDQT606 == null)
            {
                return NotFound();
            }

            var companyDQT606 = await _context.CompanyDQT606
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyDQT606 == null)
            {
                return NotFound();
            }

            return View(companyDQT606);
        }

        // POST: CompanyDQT606/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyDQT606 == null)
            {
                return Problem("Entity set 'DinhQuynhTrang606Context.CompanyDQT606'  is null.");
            }
            var companyDQT606 = await _context.CompanyDQT606.FindAsync(id);
            if (companyDQT606 != null)
            {
                _context.CompanyDQT606.Remove(companyDQT606);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyDQT606Exists(string id)
        {
          return _context.CompanyDQT606.Any(e => e.CompanyId == id);
        }
    }
}
