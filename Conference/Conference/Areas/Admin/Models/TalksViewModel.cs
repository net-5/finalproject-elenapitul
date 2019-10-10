using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class TalksViewModel
    {

        //public TalksViewModel()
        //{
        //    Schedules = new HashSet<Schedules>();
        //}

        [Required]
        [Key]
        public int Id { get; set; }
        
        [Required]      
        public int SpeakerId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }        
        
        [Required]
        [MaxLength(4, ErrorMessage = "Edition name can't have more than 4 characters.")]
        public string Edition { get; set; }
        
        [ForeignKey("SpeakerId")]
        public virtual Speakers Speaker { get; set; }
        
        //public virtual ICollection<Schedules> Schedules { get; set; }


    }
}
