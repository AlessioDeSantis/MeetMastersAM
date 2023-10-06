using MeetMastersAM.Server.Repository;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Services
{
    public class DipendentiService : ServicesBase<Dipendenti>, IDipendentiService
    {
        public DipendentiService(IRepositoryBase<Dipendenti> data) : base(data)
        {
            
        }
    }
}
