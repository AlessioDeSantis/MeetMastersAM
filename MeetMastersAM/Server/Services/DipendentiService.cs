using MeetMastersAM.Client.Shared;
using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class DipendentiService : ServicesBase<Dipendenti>, IDipendentiService
    {
        private IDipendentiRepository _dipendentiRepository;
        public DipendentiService(IRepositoryBase<Dipendenti> data, IDipendentiRepository dipendentiRepository) : base(data)
        {
            _dipendentiRepository = dipendentiRepository;
        }

        public async Task<IEnumerable<Dipendenti>> GetDetailsDipendenti()
        {
            return await _dipendentiRepository.GetDetailsDipendentiAsync();
        }
        public async Task UpdateDipendentiManyToMany(Dipendenti entity)
        {
            await _dipendentiRepository.HandleManyToMany(entity);
        }

    }
}
