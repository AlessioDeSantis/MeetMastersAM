using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{

    public interface ISediRepository : IRepositoryBase<Sedi>
    {
        public Task<IEnumerable<Sedi>> GetDetailsSediAsync();

    }
}
