using AutoMapper;
using Music_Store.Models;
using Music_Store.ViewModels.MusiciansViewModel;
using Music_Store.ViewModels.MusicsViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Auxiliary
{
    public class Helper : Profile
    {
        public Helper()
        {
            CreateMap<Musician, MusicianViewModel>().ReverseMap();
            CreateMap<CreateMusicianViewModel, Musician>();
            CreateMap<Music, MusicViewModel>();

        }
    }
}
