using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace MeetMastersAM.Server.Repository
{
    public class SkillsRepository : RepositoryBase<Skills>, ISkillsRepository
    {
        private ApplicationDbContext _context;

        public SkillsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Skills>> GetDetailsSkillAsync()
        {
            return await _context.Set<Skills>()
                .Include(e => e.Candidati_Skills)
                .Include(e => e.Dipendenti_Skills)
                .ToListAsync();
        }
    }
}
