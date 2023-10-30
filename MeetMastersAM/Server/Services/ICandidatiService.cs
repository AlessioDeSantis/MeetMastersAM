using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public interface ICandidatiService : IServiceBase<Candidati>
    {
        public Task<IEnumerable<Candidati>> GetDetailsCandidati();

    }
}
