using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class ColloquiRepository : RepositoryBase<Colloqui>, IColloquiRepository
    {
        public ColloquiRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
