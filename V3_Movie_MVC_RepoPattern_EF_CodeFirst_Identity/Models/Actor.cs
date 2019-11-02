using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Validators;

namespace V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Models
{
    public class Actor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
        [DateValidator]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public Movie Movie { get; set; }
    }
}