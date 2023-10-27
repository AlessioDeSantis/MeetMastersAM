using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public interface IBenefitsServices : IServiceBase<Benefits>
    {
        public Task<IEnumerable<Benefits>> GetDetailsBenefits();
    }
}
