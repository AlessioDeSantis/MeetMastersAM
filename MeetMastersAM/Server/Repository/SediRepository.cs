using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class SediRepository : RepositoryBase<Sedi>, ISediRepository
    {
        public SediRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
