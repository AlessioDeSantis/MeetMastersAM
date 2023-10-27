using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class BenefitsService : ServicesBase<Benefits> , IBenefitsServices
    {
        private IBenefitRepository _benefitRepository;
        public BenefitsService(IRepositoryBase<Benefits> data, IBenefitRepository benefitRepository) : base(data)
        {

            _benefitRepository = benefitRepository;

        }

        public async Task<IEnumerable<Benefits>> GetDetailsBenefits()
        {
            return await _benefitRepository.GetDetailsBenefitAsync();
        }
    }
}
