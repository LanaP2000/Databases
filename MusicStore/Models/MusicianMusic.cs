using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class MusicianMusic
    {
        public Guid ID { get; set; }
        public Music Music { get; set; }
        public Guid MusicianID { get; set; }
        public Musician Musician { get; set; }
    }
}
