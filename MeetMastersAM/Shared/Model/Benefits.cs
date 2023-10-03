using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Benefits
    {
        [Key]
        public int BenefitId { get; set; }
        public string? DescrizioneBenefit { get; set; }
        public virtual ICollection<Contratti> Contratti { get; set; } = new List<Contratti>();

    }
}
