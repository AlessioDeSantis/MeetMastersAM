using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class TipiDiDocumenti
    {
        [Key]
        public int TipoDocumentoId { get; set; }

        [Required]
        public string? DescrizioneTipoDocumento { get; set; }

        public bool Attivo { get; set; }

    }
}
