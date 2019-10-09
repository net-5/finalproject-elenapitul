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

        public int Id { get; set; }

        [Required]
        [MinLength(2)]        
        public string Name { get; set; }

        [Required]
        public string TagLine { get; set; }


        [Required]
        [Range(2000, 2025)]
        public int Year { get; set; }
        [Required]
        public bool Active { get; set; }

    }
}
