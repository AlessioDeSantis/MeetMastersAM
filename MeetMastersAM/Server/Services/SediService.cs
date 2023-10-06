using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class SediService : ServicesBase<Sedi>, ISediService
    {
        public SediService(IRepositoryBase<Sedi> data) : base(data)
        {
            
        }
    }
}
