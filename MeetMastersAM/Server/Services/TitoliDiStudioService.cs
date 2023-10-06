using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class TitoliDiStudioService : ServicesBase<TitoliDiStudio> ,ITitoliDiStudioService
    {
        public TitoliDiStudioService(IRepositoryBase<TitoliDiStudio> data) : base(data)
        {
            
        }
    }
}
