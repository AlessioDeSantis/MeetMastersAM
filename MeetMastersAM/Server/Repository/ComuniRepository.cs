using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class ComuniRepository : RepositoryBase<Comuni>, IComuniRepository
    {
        public ComuniRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
