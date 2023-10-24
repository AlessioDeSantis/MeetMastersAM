using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class MansioniService : ServicesBase<Mansioni>, IMansioniService
    {
        private IMansioniRepository _mansioniRepository;
        public MansioniService(IRepositoryBase<Mansioni> data, IMansioniRepository mansioniRepository) : base(data)
        {

            _mansioniRepository = mansioniRepository;

        }

        public async Task<IEnumerable<Mansioni>> GetDetailsMansioni()
        {
            return await _mansioniRepository.GetDetailsMansioniAsync();
        }
    }
}
