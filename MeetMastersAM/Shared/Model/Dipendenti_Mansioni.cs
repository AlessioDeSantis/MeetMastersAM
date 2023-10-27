using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Dipendenti_Mansioni
    {
        public int DipendenteId { get; set; }
        public int MansioneId { get; set; }
        public virtual Dipendenti? DipendenteNavigation { get; set; } = null!;
        public virtual Mansioni? MansioniNavigation { get; set; } = null!;
    }
}
