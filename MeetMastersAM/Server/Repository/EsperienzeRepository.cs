using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class EsperienzeRepository : RepositoryBase<Esperienze>, IEsperienzeRepository
    {
        public EsperienzeRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
