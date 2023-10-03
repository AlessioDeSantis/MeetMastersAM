using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Esperienze
    {
        public Guid EsperienzeId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataInizio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataFine { get; set; }

        
        public int? MansioneId { get; set; }

        
        public string? Azienda { get; set; }

        
        [MaxLength(300, ErrorMessage = "Inserire massimo 300 caratteri!")]
        public string? DescrizioneAttivita { get; set; }

        public int CandidatoId { get; set; }

        public virtual Mansioni MansioneNavigation { get; set; } = null!;

        public virtual Candidati CandidatoNavigation { get; set; } = null!;



    }
}
