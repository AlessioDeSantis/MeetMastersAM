using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class RegioniService : ServicesBase<Regioni> ,IRegioniService
    {
        public RegioniService(IRepositoryBase<Regioni> data) : base(data)
        {
            
        }
    }
}
