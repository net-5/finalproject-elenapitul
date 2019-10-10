using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class SpeakersViewModel
    {

        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Speaker's firstname can't be less than 2 characters.")]
        [MaxLength(50, ErrorMessage = "Speaker's firstname can't have more than 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Speaker's lastname can't be less than 2 characters.")]
        [MaxLength(50, ErrorMessage = "Speaker's lastname can't have more than 50 characters.")]
        public string LastName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Position can't be less than 2 characters.")]
        [MaxLength(50, ErrorMessage ="Position can't be more tahn 50 characters.")]
        public string Position { get; set; }
        
        public string Website { get; set; }
        public string Facebook { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Skype { get; set; }
        public string GitHub { get; set; }
        public string Twitter { get; set; }
                
        public string CompanyName { get; set; }
        public string CompanyWebsite { get; set; }

        [Required]
        [MinLength(1, ErrorMessage ="Please add a description.")]
        public string Description { get; set; }
        
        public string PageSlug { get; set; }

        [Required]
        [MaxLength(4, ErrorMessage = "Edition name can't have more than 4 characters.")]
        public string Edition { get; set; }

        public virtual ICollection<Photos> Photos { get; set; }
        public virtual ICollection<Talks> Talks { get; set; }
        public virtual ICollection<Workshops> Workshops { get; set; }

    }
}
