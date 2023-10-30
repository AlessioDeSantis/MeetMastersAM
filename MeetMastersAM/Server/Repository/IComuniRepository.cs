using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public interface IComuniRepository : IRepositoryBase<Comuni>
    {
        public Task<IEnumerable<Comuni>> GetDetailsComuniAsync();
    }
}
