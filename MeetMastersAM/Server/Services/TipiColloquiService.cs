using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class TipiColloquiService : ServicesBase<TipiColloqui>, ITipiColloquiService
    {
        public TipiColloquiService(IRepositoryBase<TipiColloqui> data) : base(data)
        {
            
        }
    }
}
