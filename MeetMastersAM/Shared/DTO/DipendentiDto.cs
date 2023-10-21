using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.DTO
{
    public class DipendentiDto
    {
        public int DipendenteId { get; set; }
        public string NomeDipendente { get; set; }
        public string CognomeDipendente { get; set; }
        public string IndirizzoDipendente { get; set; }
        public string RecapitoDipendente { get; set; }
        public DateTime DataNascitaDipendente { get; set; }
        public string GenereDipendente { get; set; }
        public int? SedeId { get; set; }
        public bool IsReferent { get; set; }
    }
}
