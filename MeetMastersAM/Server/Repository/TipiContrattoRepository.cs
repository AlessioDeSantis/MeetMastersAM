using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class TipiContrattoRepository : RepositoryBase<TipiContratto>, ITipiContrattoRepository
    {
        public TipiContrattoRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
