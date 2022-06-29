using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Interfaces
{
    public interface IUnitOfWork
    {
        IMusic Music { get; }
        IMusician Musician { get; }
        void Save();
    }
}
