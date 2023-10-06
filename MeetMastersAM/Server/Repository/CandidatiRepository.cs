using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    //le classi si estendono
    public class CandidatiRepository : RepositoryBase<Candidati>, ICandidatiRepository
    {
        public CandidatiRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
