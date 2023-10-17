using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Dipendenti
    {
        [Key]
        public int DipendenteId { get; set; }

        [Required(ErrorMessage ="Questo campo è richiesto!")]
        [MaxLength(50, ErrorMessage ="Hai superato il numero massimo di caratteri(50)")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Inserire solo lettere e spazi.")]
        public string? NomeDipendente {  get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        [MaxLength(50, ErrorMessage = "Hai superato il numero massimo di caratteri(50)")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Inserire solo lettere e spazi.")]
        public string? CognomeDipendente { get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        public string? IndirizzoDipendente { get; set; }

        [Phone(ErrorMessage = "Il formato inserito non è corretto!")]
        [Required(ErrorMessage = "Questo campo è richiesto!")]
        public string? RecapitoDipendente { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascitaDipendente { get; set; }

        public string? GenereDipendente { get; set; }

        /*[Required(ErrorMessage = "Questo campo è richiesto!")]*/
        public int? SedeId { get; set; }

        public bool IsReferent {  get; set; }

        public virtual Contratti? ContrattoNavigation { get; set; } = null!;

        public virtual Sedi? LuogoDiLavoroSedeNavigation { get; set; } = null!;
        public virtual Sedi? ReferenteSedeNavigation { get; set; } = null!;

        public virtual ICollection<Dipendenti_Skills>? Dipendenti_Skills { get; set; } = new List<Dipendenti_Skills>();

        public virtual ICollection<Mansioni>? Mansioni { get; set; } = new List<Mansioni>();

        public virtual ICollection<Colloqui>? ColloquiDipendenti { get; set; } = new List<Colloqui>();

        public virtual ICollection<Colloqui>? ColloquiReferenti { get; set; } = new List<Colloqui>();



    }
}
