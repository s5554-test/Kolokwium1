using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Event_Organizer
    {
        public int IdEvent { get; set; }
        public int IdOrganizer { get; set; }
        [ForeignKey("IdEvent")]
        public virtual Event Event { get; set; }
        [ForeignKey("IdOrganizer")]
        public virtual Organizer Organizer { get; set; }
    }
}
