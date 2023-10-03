﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Mansioni
    {
        [Key]
        public int MansioneId { get; set; }

        [Required]
        public string? NomeMansione { get; set; }

        public virtual ICollection<Esperienze> Esperienze { get; set; } = new List<Esperienze>();

        public virtual ICollection<Dipendenti> Dipendenti { get; set; } = new List<Dipendenti>();

    }
}