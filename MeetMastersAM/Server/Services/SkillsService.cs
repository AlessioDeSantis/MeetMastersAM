using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class SkillsService : ServicesBase<Skills> ,ISkillsService
    {
        public SkillsService(IRepositoryBase<Skills> data) : base(data)
        {
            
        }
    }
}
