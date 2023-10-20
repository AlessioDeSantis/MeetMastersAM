using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace MeetMastersAM.Server.Repository
{
    public class SediRepository : RepositoryBase<Sedi>, ISediRepository
    {
        private ApplicationDbContext _context;

        public SediRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Sedi>> GetDetailsSediAsync()
        {
            return await _context.Set<Sedi>()
                .Include(e => e.Dipendenti)
                .ToListAsync();
        }
    }
}
