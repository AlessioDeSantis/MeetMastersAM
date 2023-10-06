using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class LivelliContrattiRepository : RepositoryBase<LivelliContratti>, ILivelliContrattiRepository
    {
        public LivelliContrattiRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
