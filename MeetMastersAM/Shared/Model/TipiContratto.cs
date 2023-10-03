using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class TipiContratto
    {
        [Key]
        public int TipoContrattoId { get; set; }
        [Required]
        public string? DescrizioneTipoContratto { get; set; }
        public virtual ICollection<Contratti> Contratti { get; set; } = new List<Contratti>();
        public virtual ICollection<Candidati> Candidati { get; set; } = new List<Candidati>();

    }
}
