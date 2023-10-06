using MeetMastersAM.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetMastersAM.Server.Controllers
{
    public class SkillController : ControllerBase
    {
        private readonly ISkillsService _skillsService;
        public SkillController(ISkillsService skillsService)
        {
            _skillsService = skillsService;
        }
    }
}
