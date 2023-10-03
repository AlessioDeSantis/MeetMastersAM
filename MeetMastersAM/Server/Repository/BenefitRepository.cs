using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class BenefitRepository : RepositoryBase<Benefits>, IBenefitRepository
    {
        public BenefitRepository(ApplicationDbContext context) : base(context) 
        {
            
        }
    }
}
