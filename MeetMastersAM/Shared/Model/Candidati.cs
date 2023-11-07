using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Candidati
    {
        [Key]
        [Display(Name = "ID")]
        public int CandidatoId { get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        [MaxLength(50, ErrorMessage = "Hai superato il numero massimo di caratteri(50)")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Inserire solo lettere e spazi.")]
        [Display(Name = "Nome")]
        public string? NomeCandidato { get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        [MaxLength(50, ErrorMessage = "Hai superato il numero massimo di caratteri(50)")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Inserire solo lettere e spazi.")]
        [Display(Name = "Cognome")]
        public string? CognomeCandidato { get; set; }

        [Display(Name = "Immagine Profilo")]
        public byte[]? ImmagineProfilo { get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        [Display(Name = "Comune di nascita")]
        public int? ComuneNascitaId { get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        [Display(Name = "Comune di residenza")]
        public int? ComuneResidenzaId { get; set; }

        [Required]
        [Phone(ErrorMessage = "Questo campo è richiesto!")]
        [Display(Name = "Telefono")]
        public string? RecapitoCandidato { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Questo campo è richiesto!")]
        [Display(Name = "Email")]
        public string? EmailCandidato { get; set; }

        [Display(Name = "Tipo di Contratto")]
        public int? TipoContrattoId { get; set; }

        public virtual Comuni? ComuniNascitaNavigation { get; set; } = null!;

        public virtual Comuni? ComuniResidenzaNavigation { get; set; } = null!;

        public virtual TipiContratto? TipoContrattoNavigation { get; set; } = null!;

        public virtual ICollection<Esperienze> Esperienze { get; set;} = new List<Esperienze>();

        public virtual ICollection<Candidati_Skills> Candidati_Skills { get; set; } = new List<Candidati_Skills>();

        public virtual ICollection<Candidati_TitoliDiStudio> Candidati_TitoliDiStudi { get; set; } = new List<Candidati_TitoliDiStudio>();

        public virtual ICollection<Candidati_TipiDiDocumenti> Candidati_TipiDiDocumenti { get; set; } = new List<Candidati_TipiDiDocumenti>();

    }
}
