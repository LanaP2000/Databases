using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Music_Store.Data;
using Music_Store.Interfaces;
using Music_Store.Models;
using Music_Store.ViewModels.MusicsViewModel;

namespace Music_Store.Controllers
{
    public class MusicsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public MusicsController(ApplicationDbContext context, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: Musics
        public async Task<IActionResult> Index(string music_genre, string year_item)
        {
            IQueryable<string> genreQuery = from v in _context.Music
                                            orderby v.Genre
                                            select v.Genre;

            var musics = from m in _context.Music
                         select m;

            if (!string.IsNullOrEmpty(year_item))
            {
                musics = musics.Where(s => s.Year.ToString() == year_item);
            }

            if (!string.IsNullOrEmpty(music_genre))
            {
                musics = musics.Where(x => x.Genre == music_genre);
            }

            var MR = new MusicRepository
            {
                genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                musics = await musics.ToListAsync()
            };

            return View(MR);
        }

        // GET: Musics/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var music = await _context.Music
                .FirstOrDefaultAsync(m => m.ID == id);
            if (music == null)
            {
                return NotFound();
            }

            return View(music);
        }

        // GET: Musics/Create
        public IActionResult Create()
        {
            /*
            var musiciansFromRepo = _unitOfWork.Musician.GetAll();
            var selectList = new List<SelectListItem>();
            foreach(var item in musiciansFromRepo)
            {
                selectList.Add(new SelectListItem(item.Id.ToString(), item.FirstName));
            }
            var vm = new MusicCreateViewModel()
            {
                Musicians = selectList
            };

            return View(vm);
            */
            return View();
        }

        // POST: Musics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Author,Genre,Year")] Music music)
        {
            if (ModelState.IsValid)
            {
                music.ID = Guid.NewGuid();
                _context.Add(music);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(music);
        }

        // GET: Musics/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var music = await _context.Music.FindAsync(id);
            if (music == null)
            {
                return NotFound();
            }
            return View(music);
        }

        // POST: Musics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Name,Author,Genre,Year")] Music music)
        {
            if (id != music.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(music);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicExists(music.ID))
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
            return View(music);
        }

        // GET: Musics/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var music = await _context.Music
                .FirstOrDefaultAsync(m => m.ID == id);
            if (music == null)
            {
                return NotFound();
            }

            return View(music);
        }

        // POST: Musics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var music = await _context.Music.FindAsync(id);
            _context.Music.Remove(music);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicExists(Guid id)
        {
            return _context.Music.Any(e => e.ID == id);
        }
    }
}
