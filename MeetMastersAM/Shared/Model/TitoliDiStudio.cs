using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class TitoliDiStudio
    {
        [Key]
        public int TitoloDiStudioId { get; set; }

        [Required]
        public string? DescrizioneTitoloDiStudio { get; set; }

        public bool Attivo { get; set; }

    }
}
