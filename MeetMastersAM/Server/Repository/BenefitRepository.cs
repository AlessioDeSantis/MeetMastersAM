using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace MeetMastersAM.Server.Repository
{
    public class BenefitRepository : RepositoryBase<Benefits>, IBenefitRepository
    {
        private ApplicationDbContext _context;

        public BenefitRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Benefits>> GetDetailsBenefitAsync()
        {
            return await _context.Set<Benefits>()
                .Include(e => e.Contratti)
                .ToListAsync();
        }
    }
}
