using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class LivelliContratti
    {
        [Key]
        public int? LivelloContrattoId { get; set; }
        [Required]
        public string? DescrizioneLivelloContratto { get; set; }
        public virtual ICollection<Contratti> Contratti { get; set; } = new List<Contratti>();

    }
}
