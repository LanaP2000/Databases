using Music_Store.Data;
using Music_Store.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Repository
{
    public class UnitOfWorkRepo : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IMusic _musicrepo;
        private IMusician _musicianrepo;

        public UnitOfWorkRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public IMusic Music
        {
            get
            {
                return _musicrepo = _musicrepo ?? new MusicRepo(_context);
            }
        }

        public IMusician Musician
        {
            get
            {
                return _musicianrepo = _musicianrepo ?? new MusicianRepo(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
