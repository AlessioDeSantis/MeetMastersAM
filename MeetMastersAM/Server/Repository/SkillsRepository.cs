using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class SkillsRepository : RepositoryBase<Skills>, ISkillsRepository
    {
        public SkillsRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
