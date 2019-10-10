using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class EditionsViewModel
    {

        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(4, ErrorMessage = "Edition name can't have more than 4 characters.")]
        public string Name { get; set; }

        [Required]
        [MinLength(1, ErrorMessage ="Please add a tagline")]
        public string TagLine { get; set; }


        [Required]
        [Range(2000,2030, ErrorMessage = "Please add a valid year.")]
        public int Year { get; set; }

        [Required]
        public bool Active { get; set; }

    }
}
