using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class ComuniService : ServicesBase<Comuni>, IComuniService
    {
        public ComuniService(IRepositoryBase<Comuni> data) : base(data)
        {
            
        }
    }
}
