using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class Music
    {
        
        public Guid ID { get; set; }

       
        [Display(Name = "Music Title")]
        public string Name { get; set; }

        
        [MaxLength(50, ErrorMessage = "Maximum length for the name of the author is {0} characters")]
        [RegularExpression("^(?<firstchar>[A-Za-z])((?<alphachars>[A-Za-z])|(?<specialchars>[A-Za-z]['-][A-Za-z])|(?<spaces> [A-Za-z]))*$", ErrorMessage = "Invalid Name")]
        public string Author { get; set; }

        
        [RegularExpression("^(?<firstchar>[A-Za-z])((?<alphachars>[A-Za-z])|(?<specialchars>[A-Za-z]['-][A-Za-z])|(?<spaces> [A-Za-z]))*$", ErrorMessage = "Invalid Genre")]
        public string Genre { get; set; }

        
        [RegularExpression(@"^[-+]?[0-9]*\.?[0-9]+$", ErrorMessage = "Invalid Year value")]
        public int Year { get; set; }

        public List<MusicianMusic> MusiciansMusics { get; set; } = new List<MusicianMusic>();
    }
}
