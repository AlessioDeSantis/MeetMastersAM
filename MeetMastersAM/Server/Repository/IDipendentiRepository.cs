using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public interface IDipendentiRepository : IRepositoryBase<Dipendenti>
    {
        public Task<IEnumerable<Dipendenti>> GetDetailsDipendentiAsync();
    }
}
