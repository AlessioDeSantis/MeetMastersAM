using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Colloqui
    {
        [Key]
        public int ColloquioId { get; set; }

        [Required(ErrorMessage = "Il campo è richiesto")]
        [DataType(DataType.Date)]
        [Display(Name = "Data colloquio")]
        public DateTime DataColloquio { get; set; }

        [Required(ErrorMessage = "Il campo è richiesto")]
        [Display(Name = "Sede")]
        public int SedeId { get; set; }

        [Required(ErrorMessage = "Il campo è richiesto")]
        [Display(Name = "Tipo colloquio")]
        public int TipoColloquioId { get; set; }

        [Required(ErrorMessage = "Il campo è richiesto")]
        public int CandidatoId { get; set; }

        [Required]
        public int DipendenteId { get; set; }

        public int? ReferenteId { get; set; }

        [Display(Name = "Valutazione")]
        public int? Valutazione { get; set; }

        [Display(Name ="Note")]
        public string? Note { get; set; }

        public virtual Sedi SedeNavigation { get; set; } = null!;
        public virtual TipiColloqui TipiColloquioNavigation { get; set; } = null!;
        public virtual Candidati CandidatoNavigation { get; set; } = null!;
        public virtual Dipendenti DipendentiNavigation { get; set; } = null!;
        public virtual Dipendenti ReferenteNavigation { get; set; } = null!;


    }
}
