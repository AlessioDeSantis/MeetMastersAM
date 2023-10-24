using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public interface IMansioniService : IServiceBase<Mansioni>
    {
        public Task<IEnumerable<Mansioni>> GetDetailsMansioni();
    }
}
