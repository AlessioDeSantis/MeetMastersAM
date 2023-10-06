using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class NazioniService : ServicesBase<Nazioni>, INazioniService
    {
        public NazioniService(IRepositoryBase<Nazioni> data) : base(data)
        {
            
        }
    }
}
