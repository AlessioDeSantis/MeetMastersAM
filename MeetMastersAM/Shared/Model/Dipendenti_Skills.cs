using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Dipendenti_Skills
    {
        public int Id { get; set; }
        public int DipendenteId { get; set; }
        public int SkillId { get; set; }
        public virtual Dipendenti DipendenteNavigation { get; set; } = null!;
        public virtual Skills SkillNavigation { get; set; } = null!;
    }
}
