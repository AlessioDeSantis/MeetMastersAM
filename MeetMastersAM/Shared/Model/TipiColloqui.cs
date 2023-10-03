using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class TipiColloqui
    {
        [Key]
        public int TipoColloquioId { get; set; }

        [Required]
        [MaxLength(300)]
        public string DescrizioneTipoColloquio { get; set; }
        public virtual ICollection<Colloqui> Colloqui { get; set; } = new List<Colloqui>();

    }
}
