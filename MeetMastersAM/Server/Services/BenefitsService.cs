using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class BenefitsService : ServicesBase<Benefits> , IBenefitsServices
    {
        public BenefitsService(IRepositoryBase<Benefits> data) : base(data) 
        {
            
        }
    }
}
