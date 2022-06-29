using Music_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Interfaces
{
    public interface IMusic
    {
        List<Music> GetAll();
        Music GetById(Guid Id);
        void Insert(Music music);
        void Update(Music music);
        void Delete(Music music);
    }
}
