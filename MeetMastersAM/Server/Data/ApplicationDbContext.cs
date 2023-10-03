using MeetMastersAM.Shared.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MeetMastersAM.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Benefits> Benefits { get; set; }
        public virtual DbSet<Candidati> Candidati { get; set; }
        public virtual DbSet<Candidati_Skills> Candidati_Skills { get; set; }
        public virtual DbSet<Candidati_TipiDiDocumenti> Candidati_TipiDiDocumenti { get; set; }
        public virtual DbSet<Candidati_TitoliDiStudio> Candidati_TitoliDiStudios { get; set; }
        public virtual DbSet<Colloqui> Colloqui { get; set; }
        public virtual DbSet<Comuni> Comuni { get; set; }
        public virtual DbSet<Contratti> Contratti { get; set; }
        public virtual DbSet<Dipendenti> Dipendenti { get; set; }
        public virtual DbSet<Dipendenti_Skills> Dipendenti_Skills { get; set; }
        public virtual DbSet<Esperienze> Esperienze { get; set; }
        public virtual DbSet<LivelliContratti> LivelliContratti { get; set; }
        public virtual DbSet<Mansioni> Mansioni { get; set; }
        public virtual DbSet<Nazioni> Nazioni { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Regioni> Regioni { get; set; }
        public virtual DbSet<Sedi> Sedi { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<TipiColloqui> TipiColloqui { get; set; }
        public virtual DbSet<TipiContratto> TipiContratto { get; set; }
        public virtual DbSet<TipiDiDocumenti> TipiDiDocumento { get; set; }
        public virtual DbSet<TitoliDiStudio> TitoliDiStudio { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Candidati>(entity =>
            {
                entity.HasOne(p => p.ComuniNascitaNavigation)
                      .WithMany(p => p.CandidatiNascita)
                      .HasForeignKey(p => p.ComuneNascitaId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(p => p.ComuniResidenzaNavigation)
                      .WithMany(p => p.CandidatiResidenza)
                      .HasForeignKey(p => p.ComuneResidenzaId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Colloqui>(entity =>
            {
                entity.HasOne(p => p.DipendentiNavigation)
                      .WithMany(p => p.ColloquiDipendenti)
                      .HasForeignKey(p => p.DipendenteId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(p => p.ReferenteNavigation)
                      .WithMany(p => p.ColloquiReferenti)
                      .HasForeignKey(p => p.ReferenteId)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Dipendenti>(entity =>
            {
                entity.HasOne(p => p.SedeNavigation)
                      .WithMany(p => p.Dipendenti)
                      .HasForeignKey(p => p.SedeId)
                      .IsRequired()
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(c => c.ContrattoNavigation)
                      .WithOne(d => d.DipendenteNavigation)
                      .HasForeignKey<Contratti>(d => d.DipendenteId)
                      .OnDelete(DeleteBehavior.NoAction);
            });

            
        }
    }
}
