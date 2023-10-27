using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public interface ISkillsService : IServiceBase<Skills>
    {
        public Task<IEnumerable<Skills>> GetDetailsSkills();

    }
}
