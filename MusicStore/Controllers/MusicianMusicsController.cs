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
    public class MusicianMusicsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MusicianMusicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MusicianMusics
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MusicianMusic.Include(m => m.Musician);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MusicianMusics/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicianMusic = await _context.MusicianMusic
                .Include(m => m.Musician)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (musicianMusic == null)
            {
                return NotFound();
            }

            return View(musicianMusic);
        }

        // GET: MusicianMusics/Create
        public IActionResult Create()
        {
            ViewData["MusicianID"] = new SelectList(_context.Musician, "MusicianID", "Address");
            return View();
        }

        // POST: MusicianMusics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MusicianID")] MusicianMusic musicianMusic)
        {
            if (ModelState.IsValid)
            {
                musicianMusic.ID = Guid.NewGuid();
                _context.Add(musicianMusic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MusicianID"] = new SelectList(_context.Musician, "MusicianID", "Address", musicianMusic.MusicianID);
            return View(musicianMusic);
        }

        // GET: MusicianMusics/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicianMusic = await _context.MusicianMusic.FindAsync(id);
            if (musicianMusic == null)
            {
                return NotFound();
            }
            ViewData["MusicianID"] = new SelectList(_context.Musician, "MusicianID", "Address", musicianMusic.MusicianID);
            return View(musicianMusic);
        }

        // POST: MusicianMusics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,MusicianID")] MusicianMusic musicianMusic)
        {
            if (id != musicianMusic.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musicianMusic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicianMusicExists(musicianMusic.ID))
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
            ViewData["MusicianID"] = new SelectList(_context.Musician, "MusicianID", "Address", musicianMusic.MusicianID);
            return View(musicianMusic);
        }

        // GET: MusicianMusics/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicianMusic = await _context.MusicianMusic
                .Include(m => m.Musician)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (musicianMusic == null)
            {
                return NotFound();
            }

            return View(musicianMusic);
        }

        // POST: MusicianMusics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var musicianMusic = await _context.MusicianMusic.FindAsync(id);
            _context.MusicianMusic.Remove(musicianMusic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicianMusicExists(Guid id)
        {
            return _context.MusicianMusic.Any(e => e.ID == id);
        }
    }
}
