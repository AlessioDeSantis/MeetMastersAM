using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class TipiDiDoucmentiService : ServicesBase<TipiDiDocumenti>, ITipiDiDocumentiService
    {
        public TipiDiDoucmentiService(IRepositoryBase<TipiDiDocumenti> data) : base(data)
        {
            
        }
    }
}
