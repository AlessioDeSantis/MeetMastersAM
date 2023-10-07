using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Regioni
    {
        [Key]
        public int RegioneId { get; set; }

        [Display(Name = "Regione")]
        public string? RegioneNome { get; set; }
        public int NazioneId { get; set; }

        public virtual Nazioni NazioneNavigation { get; set; } = null!;
        public virtual ICollection<Province> Province { get; set; } = new List<Province>();


    }
}
