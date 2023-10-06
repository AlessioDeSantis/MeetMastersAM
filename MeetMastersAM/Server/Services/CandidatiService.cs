using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class CandidatiService : ServicesBase<Candidati>, ICandidatiService
    {
        public CandidatiService(IRepositoryBase<Candidati> data) : base(data)
        {
            
        }
    }
}
