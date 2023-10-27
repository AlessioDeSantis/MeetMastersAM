using MeetMastersAM.Server.Data;
using MeetMastersAM.Shared.Model;
using Microsoft.CodeAnalysis;
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
                .Include(e => e.LuogoDiLavoroSedeNavigation)
                .Include(e => e.Mansioni_Dipendenti)!
                .ThenInclude(e => e.MansioniNavigation)
                .AsSplitQuery()
                .ToListAsync();
        }

        public async Task HandleManyToMany(Dipendenti entity)
        {
            var mansioniSet = await _context.Set<Dipendenti_Mansioni>().Where(e => e.DipendenteId == entity.DipendenteId).ToListAsync();
            foreach (var mansione in mansioniSet)
            {
                if (entity.Mansioni_Dipendenti!.Any(e => e.MansioneId == mansione.MansioneId))
                {
                    continue;
                }
                else
                {
                    _context.Set<Dipendenti_Mansioni>().Remove(mansione);
                }
            }
            foreach (var mansione in entity.Mansioni_Dipendenti!)
            {
                if (mansioniSet.Any(e => e.MansioneId == mansione.MansioneId))
                {
                    continue;
                }
                else
                {
                    _context.Set<Dipendenti_Mansioni>().Add(mansione);
                }
            }
            _context.Set<Dipendenti>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
