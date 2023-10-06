using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class TipiContrattoService : ServicesBase<TipiContratto>, ITipiContrattoService
    {
        public TipiContrattoService(IRepositoryBase<TipiContratto> data) : base(data)
        {
            
        }
    }
}
