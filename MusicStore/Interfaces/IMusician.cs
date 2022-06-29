using Music_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Interfaces
{
    public interface IMusician
    {
        List<Musician> GetAll();
        Musician GetById(Guid Id);
        void Insert(Musician musician);
        void Update(Musician musician);
        void Delete(Musician musician);
    }
}
