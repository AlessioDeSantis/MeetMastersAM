using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class TipiDiDocumentoRepository : RepositoryBase<TipiDiDocumenti>, ITipiDiDocumenti
    {
        public TipiDiDocumentoRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
