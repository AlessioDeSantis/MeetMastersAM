using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;

namespace MeetMastersAM.Server.Repository
{
    public class NazioniRepository : RepositoryBase<Nazioni>, INazioneRepository
    {
        public NazioniRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
