using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class ColloquiService : ServicesBase<Colloqui>, IColloquiService
    {
        public ColloquiService(IRepositoryBase<Colloqui> data) : base(data)
        {
            
        }
    }
}
