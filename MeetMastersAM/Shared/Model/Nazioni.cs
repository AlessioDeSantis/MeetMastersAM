using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Nazioni
    {
        [Key]
        public int NazioneId { get; set; }

        [Required]
        public string? NazioneNome { get; set; }

        public virtual ICollection<Regioni>? Regioni { get; set; } = new List<Regioni>();
    }
}
