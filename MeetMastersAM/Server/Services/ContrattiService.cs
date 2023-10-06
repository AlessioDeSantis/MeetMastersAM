using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class ContrattiService : ServicesBase<Contratti>, IContrattiService
    {
        public ContrattiService(IRepositoryBase<Contratti> data) : base(data)
        {
            
        }
    }
}
