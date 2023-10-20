using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class SediService : ServicesBase<Sedi>, ISediService
    {
        private ISediRepository _sediRepository { get; set; }
        public SediService(IRepositoryBase<Sedi> data, ISediRepository sediRepository) : base(data)
        {
            _sediRepository = sediRepository;
        }

        public async Task<IEnumerable<Sedi>> GetDetailsSedi()
        {
            return await _sediRepository.GetDetailsSediAsync();
        }
    }
}
