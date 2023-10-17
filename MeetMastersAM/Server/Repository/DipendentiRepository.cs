using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace MeetMastersAM.Server.Repository
{
    public class DipendentiRepository : RepositoryBase<Dipendenti>, IDipendentiRepository
    {
        private ApplicationDbContext _context;
        public DipendentiRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Dipendenti>> GetDetailsDipendentiAsync()
        {
            return await _context.Set<Dipendenti>()
                .Include(e => e.Mansioni)
                .ToListAsync();
        }
    }
}
