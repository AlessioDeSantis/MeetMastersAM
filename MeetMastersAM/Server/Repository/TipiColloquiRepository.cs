using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class TipiColloquiRepository : RepositoryBase<TipiColloqui>, ITipiColloquiRepository
    {
        public TipiColloquiRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
