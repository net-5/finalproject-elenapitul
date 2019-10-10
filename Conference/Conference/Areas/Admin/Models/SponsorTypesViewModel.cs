using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class SponsorTypesViewModel
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Sponsor Type name can't be less than 2 characters")]        
        public string Name { get; set; }

        [Required]        
        public int Order { get; set; }

        [Required]
        [MaxLength(4, ErrorMessage = "Edition name can't have more than 4 characters.")]
        public string Edition { get; set; }

        //public virtual ICollection<Sponsors> Sponsors { get; set; }

       

    }
}

