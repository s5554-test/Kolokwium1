using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Organizer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrganizer { get; set; }
        [MaxLength(30)]
        public string? Name { get; set; }

        public virtual ICollection<Event_Organizer> EventsOrganizers { get; set; }
    }
}
