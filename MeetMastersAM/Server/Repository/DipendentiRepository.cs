using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class DipendentiRepository : RepositoryBase<Dipendenti>, IDipendentiRepository
    {
        public DipendentiRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
