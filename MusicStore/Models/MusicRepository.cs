using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class MusicRepository
    {
        // Methods that should work with Music instances
        // I could not implement using interface, so had to change like that - as google showed me :) 
        public List<Music> musics;
        public string music_genre { get; set; }
        public SelectList genres;
    }
}
