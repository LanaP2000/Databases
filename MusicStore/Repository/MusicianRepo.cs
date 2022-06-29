using Music_Store.Data;
using Music_Store.Interfaces;
using Music_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Repository
{
    public class MusicianRepo : IMusician
    {
        private readonly ApplicationDbContext _context;

        public MusicianRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Musician musician)
        {
            _context.Musician.Remove(musician);
        }

        public List<Musician> GetAll()
        {
            return _context.Musician.ToList();
        }

        public Musician GetById(Guid Id)
        {
            return _context.Musician.FirstOrDefault(x => x.Id == Id);
        }

        public void Insert(Musician musician)
        {
            _context.Musician.Add(musician);
        }

        public void Update(Musician musician)
        {
            _context.Musician.Update(musician);
        }
    }
}
