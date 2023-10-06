using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class MansioniRepository : RepositoryBase<Mansioni>, IMansioniRepository
    {
        public MansioniRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
