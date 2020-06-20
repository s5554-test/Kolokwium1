﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Artist_Event
    {
       
        public int IdEvent { get; set; }
        public int IdArtist { get; set; }
        public DateTime PerformanceDate { get; set; }
        [ForeignKey("IdEvent")]
        public virtual Event Event { get; set; }
        [ForeignKey("IdArtist")]
        public virtual Artist Artist { get; set; }

    }
}
