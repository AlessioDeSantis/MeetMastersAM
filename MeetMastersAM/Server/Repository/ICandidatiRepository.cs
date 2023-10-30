using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    //L interfaccia si implementa
    public interface ICandidatiRepository : IRepositoryBase<Candidati>
    {
        public Task<IEnumerable<Candidati>> GetDetailsCandidatiAsync();
    }
}
