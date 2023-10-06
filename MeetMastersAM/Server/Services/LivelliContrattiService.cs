using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class LivelliContrattiService : ServicesBase<LivelliContratti>, ILivelliContrattiService
    {
        public LivelliContrattiService(IRepositoryBase<LivelliContratti> data) : base(data)
        {
            
        }
    }
}
