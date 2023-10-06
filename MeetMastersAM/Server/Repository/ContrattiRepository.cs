using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class ContrattiRepository : RepositoryBase<Contratti>, IContrattiReposistory
    {
        public ContrattiRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
