using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace MeetMastersAM.Server.Repository
{
    //le classi si estendono
    public class CandidatiRepository : RepositoryBase<Candidati>, ICandidatiRepository
    {
        private ApplicationDbContext _context;
        public CandidatiRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Candidati>> GetDetailsCandidatiAsync()
        {
            return await _context.Set<Candidati>()
                .Include(e => e.ComuniNascitaNavigation)
                .Include(e => e.ComuniResidenzaNavigation)
                .Include(e => e.TipoContrattoNavigation)
                .Include(e => e.Esperienze)
                .Include(e => e.Candidati_Skills)
                .ThenInclude(e => e.SkillNavigation)
                .Include(e => e.Candidati_TipiDiDocumenti)
                .ThenInclude(e => e.TipiDiDocumentiNavigation)
                .Include(e => e.Candidati_TitoliDiStudi)
                .ThenInclude(e => e.TitoloDiStudioNavigation)
                .ToListAsync();
        }
    }
}
