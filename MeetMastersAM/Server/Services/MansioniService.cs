using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class MansioniService : ServicesBase<Mansioni>, IMansioniService
    {
        public MansioniService(IRepositoryBase<Mansioni> data) : base(data)
        {
            
        }
    }
}
