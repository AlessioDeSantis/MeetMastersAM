using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class SkillsService : ServicesBase<Skills> ,ISkillsService
    {
        private ISkillsRepository _skillRepository;
        public SkillsService(IRepositoryBase<Skills> data, ISkillsRepository skillRepository) : base(data)
        {

            _skillRepository = skillRepository;

        }

        public async Task<IEnumerable<Skills>> GetDetailsSkills()
        {
            return await _skillRepository.GetDetailsSkillAsync();
        }
    }
}
