using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Contratti
    {
        [Key]
        public int ContrattoId { get; set; }

        [Required]
        public int LivelloContrattoId { get; set; }

        [Required]
        public int TipoContrattoId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataStipuloContratto { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DataScadenzaContratto { get; set; }

        public int? DipendenteId { get; set; }

        public virtual LivelliContratti LivelloContrattoNavigation { get; set; } = null!;

        public virtual TipiContratto TipoContrattoNavigation { get; set; } = null!; 

        public virtual Dipendenti DipendenteNavigation { get; set; } = null!;

        public virtual ICollection<Benefits> Benefits { get; set; } = new List<Benefits>();




    }
}
