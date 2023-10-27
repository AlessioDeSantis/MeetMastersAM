using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public interface ISkillsRepository : IRepositoryBase<Skills>
    {
        public Task<IEnumerable<Skills>> GetDetailsSkillAsync();
    }
}
