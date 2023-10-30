using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class CandidatiService : ServicesBase<Candidati>, ICandidatiService
    {
        private ICandidatiRepository _candidatiRepository;
        public CandidatiService(IRepositoryBase<Candidati> data, ICandidatiRepository candidatiRepository) : base(data)
        {
            _candidatiRepository = candidatiRepository;
        }

        public async Task<IEnumerable<Candidati>> GetDetailsCandidati()
        {
            return await _candidatiRepository.GetDetailsCandidatiAsync();
        }
    }
}
