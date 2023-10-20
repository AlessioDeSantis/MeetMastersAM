using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public interface ISediService : IServiceBase<Sedi>
    {
        public Task<IEnumerable<Sedi>> GetDetailsSedi();

    }
}
