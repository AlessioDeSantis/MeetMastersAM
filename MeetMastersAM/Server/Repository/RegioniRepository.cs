using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class RegioniRepository : RepositoryBase<Regioni>, IRegioniRepository
    {
        public RegioniRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
