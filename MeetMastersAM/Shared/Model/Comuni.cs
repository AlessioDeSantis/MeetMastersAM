using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Comuni
    {
        [Key]
        public int ComuneId { get; set; }
        public string? NomeComune { get; set; }
        public int ProvinciaId { get; set; }
        public virtual Province ProvinciaNavigation { get; set; } = null!;
        public virtual ICollection<Candidati> CandidatiNascita { get; set; } = new List<Candidati>();
        public virtual ICollection<Candidati> CandidatiResidenza { get; set; } = new List<Candidati>();

    }
}
