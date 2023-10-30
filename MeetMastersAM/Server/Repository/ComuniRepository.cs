using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace MeetMastersAM.Server.Repository
{
    public class ComuniRepository : RepositoryBase<Comuni>, IComuniRepository
    {
        private ApplicationDbContext _context;
        public ComuniRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Comuni>> GetDetailsComuniAsync()
        {
            return await _context.Set<Comuni>()
                .Include(e => e.ProvinciaNavigation)
                .Include(e => e.CandidatiNascita)
                .Include(e => e.CandidatiResidenza)
                .ToListAsync();
        }
    }
}
