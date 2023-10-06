using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class EsperienzeService : ServicesBase<Esperienze>, IEsperienzeService
    {
        public EsperienzeService(IRepositoryBase<Esperienze> data) : base(data)
        {
            
        }
    }
}
