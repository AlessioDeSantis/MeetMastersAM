using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class ComuniService : ServicesBase<Comuni>, IComuniService
    {
        private readonly IComuniRepository _repository; 
        public ComuniService(IRepositoryBase<Comuni> data, IComuniRepository repository) : base(data)
        {

            _repository = repository;

        }

        public async Task<IEnumerable<Comuni>> GetDetailsComuni()
        {
            return await _repository.GetDetailsComuniAsync();
        }
    }
}
