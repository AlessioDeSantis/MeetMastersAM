using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class ProvinceService : ServicesBase<Province>, IProvinceService
    {
        public ProvinceService(IRepositoryBase<Province> data) : base(data)
        {
            
        }
    }
}
