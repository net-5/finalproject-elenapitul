using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class SponsorsViewModel
    {

        [Required]
        [Key]
        public int Id { get; set; }

        [Required]        
        [MinLength(2, ErrorMessage = "Sponsor's name can't be less than 2 characters")]        
        public string Name { get; set; }

        public string Website { get; set; }
        public string Facebook { get; set; }

        [Required]
        [MinLength(2,ErrorMessage ="Please add a description.")]
        [MaxLength(255, ErrorMessage ="Description can't have more than 255 characters.")]
        public string Description { get; set; }
        
        public string PageSlug { get; set; }

        [Required]        
        public int SponsorTypeId { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        [MaxLength(4, ErrorMessage ="Edition name can't have more than 4 characters.")]
        public string Edition { get; set; }

        [ForeignKey("SponsorTypeId")]
        public virtual SponsorTypes SponsorType { get; set; }
        
        //public virtual ICollection<SponsorPhoto> SponsorPhoto { get; set; }
    }
}
