using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Skills
    {
        [Key]
        public int SkillId { get; set; }

        [Required]
        public string? DescrizioneSkill { get; set; }

        [Required]
        public string? TipoSkill { get; set; }

        public bool Attivo { get; set; }

        public virtual ICollection<Candidati_Skills> Candidati_Skills { get; set; } = new List<Candidati_Skills>();
        public virtual ICollection<Dipendenti_Skills> Dipendenti_Skills { get; set; } = new List<Dipendenti_Skills>();


    }
}
