using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Music_Store.Data;
using Music_Store.Models;

namespace Music_Store.Controllers
{
    public class MusiciansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MusiciansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Musicians
        public async Task<IActionResult> Index()
        {
            return View(await _context.Musician.ToListAsync());
        }

        // GET: Musicians/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musician = await _context.Musician
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musician == null)
            {
                return NotFound();
            }

            return View(musician);
        }

        // GET: Musicians/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Musicians/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,Address,City,PostalCode")] Musician musician)
        {
            if (ModelState.IsValid)
            {
                musician.Id = Guid.NewGuid();
                _context.Add(musician);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musician);
        }

        // GET: Musicians/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musician = await _context.Musician.FindAsync(id);
            if (musician == null)
            {
                return NotFound();
            }
            return View(musician);
        }

        // POST: Musicians/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,Address,City,PostalCode")] Musician musician)
        {
            if (id != musician.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musician);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicianExists(musician.Id))
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
            return View(musician);
        }

        // GET: Musicians/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musician = await _context.Musician
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musician == null)
            {
                return NotFound();
            }

            return View(musician);
        }

        // POST: Musicians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var musician = await _context.Musician.FindAsync(id);
            _context.Musician.Remove(musician);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicianExists(Guid id)
        {
            return _context.Musician.Any(e => e.Id == id);
        }
    }
}
