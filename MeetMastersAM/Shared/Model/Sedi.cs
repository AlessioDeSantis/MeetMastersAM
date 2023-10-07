using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Sedi
    {
        [Key]
        public int SedeId { get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        [MaxLength(50, ErrorMessage = "Hai superato il numero massimo di caratteri(50)")]
        [RegularExpression("^[A-Za-z\\s]+$", ErrorMessage = "Inserire solo lettere e spazi.")]
        [Display(Name = "Nome sede")]
        public string? DescrizioneSede { get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        [Display(Name = "Indirizzo")]
        public string? IndirizzoSede { get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        [Phone(ErrorMessage ="Il formato non è corretto!")]
        [Display(Name = "Telefono")]
        public string? RecapitoSede { get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        [EmailAddress(ErrorMessage = "Il formato non è corretto!")]
        [Display(Name = "Email")]
        public string? EmailSede { get; set; }

        [Required(ErrorMessage = "Questo campo è richiesto!")]
        [Display(Name ="Referente")]
        public int? ReferenteId { get; set; }

       
        public virtual Dipendenti ReferenteNavigation { get; set; } = null!;
        public virtual ICollection<Dipendenti> Dipendenti { get; set; } = new List<Dipendenti>();
        public virtual ICollection<Colloqui> Colloquis { get; set; } = new List<Colloqui>();






    }
}
