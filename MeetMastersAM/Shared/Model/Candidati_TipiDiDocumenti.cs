using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Candidati_TipiDiDocumenti
    {
        public int Id { get; set; }
        public int CandidatoId { get; set;}
        public int TipoDocumentoId { get; set; }
        public virtual Candidati CandidatoNavigation { get; set; } = null!;
        public virtual TipiDiDocumenti TipiDiDocumentiNavigation { get; set; } = null!;
    }
}
