using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Validators;

namespace V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Release Date")]
        [DateValidator]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        [Range(1,10,ErrorMessage ="Rating should be between 1 and 10")]
        public decimal Rating { get; set; }
        
        public ICollection <Actor> Actors{ get; set; }
    }
}
