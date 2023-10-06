using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class TitoliDiStudioRepository : RepositoryBase<TitoliDiStudio>, ITitoliDiStudioRepository
    {
        public TitoliDiStudioRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
