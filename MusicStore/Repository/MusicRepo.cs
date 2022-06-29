using Microsoft.EntityFrameworkCore;
using Music_Store.Data;
using Music_Store.Interfaces;
using Music_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Repository
{
    public class MusicRepo : IMusic
    {
        private readonly ApplicationDbContext _context;

        public MusicRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Music music)
        {
            _context.Music.Remove(music);
        }

        public List<Music> GetAll()
        {
            return _context.Music.ToList();
        }

        public Music GetById(Guid Id)
        {
            //return _context.Music.FirstOrDefault(x=>x.ID == Id);
            return _context.Music.Include("MusiciansMusics.Musician").FirstOrDefault(x => x.ID == Id);
        }

        public void Insert(Music music)
        {
            _context.Music.Add(music);
        }

        public void Update(Music music)
        {
            _context.Music.Update(music);
        }
    }
}
