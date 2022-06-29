using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class Musician
    {
        
        public Guid Id { get; set; }

       
        [MaxLength(50, ErrorMessage = "Maximum length for the name is {0} characters")]
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        
        [MaxLength(50, ErrorMessage = "Maximum length for the address is {0} characters")]
        public string Address { get; set; }

        
        [MaxLength(50, ErrorMessage = "Maximum length for the city is {0} characters")]
        public string City { get; set; }

       
        [RegularExpression(@"^[-+]?[0-9]*\.?[0-9]+$", ErrorMessage = "Invalid Year value")]
        public string PostalCode { get; set; }

        public List<MusicianMusic> MusiciansMusics { get; set; } = new List<MusicianMusic>();
    }
}
