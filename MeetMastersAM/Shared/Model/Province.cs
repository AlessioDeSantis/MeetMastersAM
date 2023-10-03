using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetMastersAM.Shared.Model
{
    public partial class Province
    {
        [Key]
        public int ProvinciaId { get; set; }
        public string? ProvinciaNome { get; set; }
        public int RegioneId { get; set; }

        public virtual Regioni RegioneNavigation { get; set; } = null!;
        public virtual ICollection<Comuni> Comuni { get; set; } = new List<Comuni>();


    }
}
