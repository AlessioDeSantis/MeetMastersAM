using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace MeetMastersAM.Server.Repository
{
    public class MansioniRepository : RepositoryBase<Mansioni>, IMansioniRepository
    {
        private ApplicationDbContext _context;

        public MansioniRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Mansioni>> GetDetailsMansioniAsync()
        {
            return await _context.Set<Mansioni>()
                .Include(e => e.Dipendenti_Mansioni)
                .Include(e => e.Esperienze)
                .ToListAsync();
        }
    }
}
