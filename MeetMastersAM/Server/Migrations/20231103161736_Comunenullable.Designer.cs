﻿// <auto-generated />
using System;
using MeetMastersAM.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MeetMastersAM.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231103161736_Comunenullable")]
    partial class Comunenullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BenefitsContratti", b =>
                {
                    b.Property<int>("BenefitsBenefitId")
                        .HasColumnType("int");

                    b.Property<int>("ContrattiContrattoId")
                        .HasColumnType("int");

                    b.HasKey("BenefitsBenefitId", "ContrattiContrattoId");

                    b.HasIndex("ContrattiContrattoId");

                    b.ToTable("BenefitsContratti");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Benefits", b =>
                {
                    b.Property<int>("BenefitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BenefitId"));

                    b.Property<string>("DescrizioneBenefit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BenefitId");

                    b.ToTable("Benefits");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Candidati", b =>
                {
                    b.Property<int>("CandidatoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidatoId"));

                    b.Property<string>("CognomeCandidato")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ComuneNascitaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ComuneResidenzaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("EmailCandidato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCandidato")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RecapitoCandidato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoContrattoId")
                        .HasColumnType("int");

                    b.HasKey("CandidatoId");

                    b.HasIndex("ComuneNascitaId");

                    b.HasIndex("ComuneResidenzaId");

                    b.HasIndex("TipoContrattoId");

                    b.ToTable("Candidati");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Candidati_Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("CandidatoNavigationCandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("SkillNavigationSkillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoNavigationCandidatoId");

                    b.HasIndex("SkillNavigationSkillId");

                    b.ToTable("Candidati_Skills");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Candidati_TipiDiDocumenti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("CandidatoNavigationCandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("TipiDiDocumentiNavigationTipoDocumentoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoDocumentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoNavigationCandidatoId");

                    b.HasIndex("TipiDiDocumentiNavigationTipoDocumentoId");

                    b.ToTable("Candidati_TipiDiDocumenti");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Candidati_TitoliDiStudio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("CandidatoNavigationCandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("TitoloDiStudioId")
                        .HasColumnType("int");

                    b.Property<int>("TitoloDiStudioNavigationTitoloDiStudioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoNavigationCandidatoId");

                    b.HasIndex("TitoloDiStudioNavigationTitoloDiStudioId");

                    b.ToTable("Candidati_TitoliDiStudios");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Colloqui", b =>
                {
                    b.Property<int>("ColloquioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColloquioId"));

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("CandidatoNavigationCandidatoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataColloquio")
                        .HasColumnType("datetime2");

                    b.Property<int>("DipendenteId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReferenteId")
                        .HasColumnType("int");

                    b.Property<int>("SedeId")
                        .HasColumnType("int");

                    b.Property<int>("SedeNavigationSedeId")
                        .HasColumnType("int");

                    b.Property<int>("TipiColloquioNavigationTipoColloquioId")
                        .HasColumnType("int");

                    b.Property<int>("TipoColloquioId")
                        .HasColumnType("int");

                    b.Property<int?>("Valutazione")
                        .HasColumnType("int");

                    b.HasKey("ColloquioId");

                    b.HasIndex("CandidatoNavigationCandidatoId");

                    b.HasIndex("DipendenteId");

                    b.HasIndex("ReferenteId");

                    b.HasIndex("SedeNavigationSedeId");

                    b.HasIndex("TipiColloquioNavigationTipoColloquioId");

                    b.ToTable("Colloqui");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Comuni", b =>
                {
                    b.Property<int>("ComuneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComuneId"));

                    b.Property<string>("NomeComune")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("ComuneId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Comuni");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Contratti", b =>
                {
                    b.Property<int>("ContrattoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContrattoId"));

                    b.Property<DateTime?>("DataScadenzaContratto")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataStipuloContratto")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("DipendenteId")
                        .HasColumnType("int");

                    b.Property<int>("LivelloContrattoId")
                        .HasColumnType("int");

                    b.Property<int>("LivelloContrattoNavigationLivelloContrattoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoContrattoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoContrattoNavigationTipoContrattoId")
                        .HasColumnType("int");

                    b.HasKey("ContrattoId");

                    b.HasIndex("DipendenteId")
                        .IsUnique()
                        .HasFilter("[DipendenteId] IS NOT NULL");

                    b.HasIndex("LivelloContrattoNavigationLivelloContrattoId");

                    b.HasIndex("TipoContrattoNavigationTipoContrattoId");

                    b.ToTable("Contratti");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Dipendenti", b =>
                {
                    b.Property<int>("DipendenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DipendenteId"));

                    b.Property<string>("CognomeDipendente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DataNascitaDipendente")
                        .HasColumnType("datetime2");

                    b.Property<string>("GenereDipendente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndirizzoDipendente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsReferent")
                        .HasColumnType("bit");

                    b.Property<string>("NomeDipendente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RecapitoDipendente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SedeId")
                        .HasColumnType("int");

                    b.HasKey("DipendenteId");

                    b.HasIndex("SedeId");

                    b.ToTable("Dipendenti");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Dipendenti_Mansioni", b =>
                {
                    b.Property<int>("MansioneId")
                        .HasColumnType("int");

                    b.Property<int>("DipendenteId")
                        .HasColumnType("int");

                    b.HasKey("MansioneId", "DipendenteId");

                    b.HasIndex("DipendenteId");

                    b.ToTable("Dipendenti_Mansioni");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Dipendenti_Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DipendenteId")
                        .HasColumnType("int");

                    b.Property<int>("DipendenteNavigationDipendenteId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("SkillNavigationSkillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DipendenteNavigationDipendenteId");

                    b.HasIndex("SkillNavigationSkillId");

                    b.ToTable("Dipendenti_Skills");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Esperienze", b =>
                {
                    b.Property<Guid>("EsperienzeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Azienda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<int>("CandidatoNavigationCandidatoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFine")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInizio")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescrizioneAttivita")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("MansioneId")
                        .HasColumnType("int");

                    b.Property<int>("MansioneNavigationMansioneId")
                        .HasColumnType("int");

                    b.HasKey("EsperienzeId");

                    b.HasIndex("CandidatoNavigationCandidatoId");

                    b.HasIndex("MansioneNavigationMansioneId");

                    b.ToTable("Esperienze");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.LivelliContratti", b =>
                {
                    b.Property<int?>("LivelloContrattoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("LivelloContrattoId"));

                    b.Property<string>("DescrizioneLivelloContratto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LivelloContrattoId");

                    b.ToTable("LivelliContratti");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Mansioni", b =>
                {
                    b.Property<int>("MansioneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MansioneId"));

                    b.Property<string>("NomeMansione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MansioneId");

                    b.ToTable("Mansioni");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Nazioni", b =>
                {
                    b.Property<int>("NazioneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NazioneId"));

                    b.Property<string>("NazioneNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NazioneId");

                    b.ToTable("Nazioni");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Province", b =>
                {
                    b.Property<int>("ProvinciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProvinciaId"));

                    b.Property<string>("ProvinciaNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegioneId")
                        .HasColumnType("int");

                    b.HasKey("ProvinciaId");

                    b.HasIndex("RegioneId");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Regioni", b =>
                {
                    b.Property<int>("RegioneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegioneId"));

                    b.Property<int>("NazioneId")
                        .HasColumnType("int");

                    b.Property<string>("RegioneNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegioneId");

                    b.HasIndex("NazioneId");

                    b.ToTable("Regioni");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Sedi", b =>
                {
                    b.Property<int>("SedeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SedeId"));

                    b.Property<string>("DescrizioneSede")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmailSede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndirizzoSede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecapitoSede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReferenteId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("SedeId");

                    b.HasIndex("ReferenteId")
                        .IsUnique();

                    b.ToTable("Sedi");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Skills", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("DescrizioneSkill")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoSkill")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.TipiColloqui", b =>
                {
                    b.Property<int>("TipoColloquioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoColloquioId"));

                    b.Property<string>("DescrizioneTipoColloquio")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("TipoColloquioId");

                    b.ToTable("TipiColloqui");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.TipiContratto", b =>
                {
                    b.Property<int>("TipoContrattoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoContrattoId"));

                    b.Property<string>("DescrizioneTipoContratto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoContrattoId");

                    b.ToTable("TipiContratto");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.TipiDiDocumenti", b =>
                {
                    b.Property<int>("TipoDocumentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoDocumentoId"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("DescrizioneTipoDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoDocumentoId");

                    b.ToTable("TipiDiDocumento");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.TitoliDiStudio", b =>
                {
                    b.Property<int>("TitoloDiStudioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TitoloDiStudioId"));

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("DescrizioneTitoloDiStudio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TitoloDiStudioId");

                    b.ToTable("TitoliDiStudio");
                });

            modelBuilder.Entity("BenefitsContratti", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Benefits", null)
                        .WithMany()
                        .HasForeignKey("BenefitsBenefitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.Contratti", null)
                        .WithMany()
                        .HasForeignKey("ContrattiContrattoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Candidati", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Comuni", "ComuniNascitaNavigation")
                        .WithMany("CandidatiNascita")
                        .HasForeignKey("ComuneNascitaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.Comuni", "ComuniResidenzaNavigation")
                        .WithMany("CandidatiResidenza")
                        .HasForeignKey("ComuneResidenzaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.TipiContratto", "TipoContrattoNavigation")
                        .WithMany("Candidati")
                        .HasForeignKey("TipoContrattoId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("ComuniNascitaNavigation");

                    b.Navigation("ComuniResidenzaNavigation");

                    b.Navigation("TipoContrattoNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Candidati_Skills", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Candidati", "CandidatoNavigation")
                        .WithMany("Candidati_Skills")
                        .HasForeignKey("CandidatoNavigationCandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.Skills", "SkillNavigation")
                        .WithMany("Candidati_Skills")
                        .HasForeignKey("SkillNavigationSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CandidatoNavigation");

                    b.Navigation("SkillNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Candidati_TipiDiDocumenti", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Candidati", "CandidatoNavigation")
                        .WithMany("Candidati_TipiDiDocumenti")
                        .HasForeignKey("CandidatoNavigationCandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.TipiDiDocumenti", "TipiDiDocumentiNavigation")
                        .WithMany()
                        .HasForeignKey("TipiDiDocumentiNavigationTipoDocumentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CandidatoNavigation");

                    b.Navigation("TipiDiDocumentiNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Candidati_TitoliDiStudio", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Candidati", "CandidatoNavigation")
                        .WithMany("Candidati_TitoliDiStudi")
                        .HasForeignKey("CandidatoNavigationCandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.TitoliDiStudio", "TitoloDiStudioNavigation")
                        .WithMany()
                        .HasForeignKey("TitoloDiStudioNavigationTitoloDiStudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CandidatoNavigation");

                    b.Navigation("TitoloDiStudioNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Colloqui", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Candidati", "CandidatoNavigation")
                        .WithMany()
                        .HasForeignKey("CandidatoNavigationCandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.Dipendenti", "DipendentiNavigation")
                        .WithMany("ColloquiDipendenti")
                        .HasForeignKey("DipendenteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.Dipendenti", "ReferenteNavigation")
                        .WithMany("ColloquiReferenti")
                        .HasForeignKey("ReferenteId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("MeetMastersAM.Shared.Model.Sedi", "SedeNavigation")
                        .WithMany("Colloquis")
                        .HasForeignKey("SedeNavigationSedeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.TipiColloqui", "TipiColloquioNavigation")
                        .WithMany("Colloqui")
                        .HasForeignKey("TipiColloquioNavigationTipoColloquioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CandidatoNavigation");

                    b.Navigation("DipendentiNavigation");

                    b.Navigation("ReferenteNavigation");

                    b.Navigation("SedeNavigation");

                    b.Navigation("TipiColloquioNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Comuni", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Province", "ProvinciaNavigation")
                        .WithMany("Comuni")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("ProvinciaNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Contratti", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Dipendenti", "DipendenteNavigation")
                        .WithOne("ContrattoNavigation")
                        .HasForeignKey("MeetMastersAM.Shared.Model.Contratti", "DipendenteId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("MeetMastersAM.Shared.Model.LivelliContratti", "LivelloContrattoNavigation")
                        .WithMany("Contratti")
                        .HasForeignKey("LivelloContrattoNavigationLivelloContrattoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.TipiContratto", "TipoContrattoNavigation")
                        .WithMany("Contratti")
                        .HasForeignKey("TipoContrattoNavigationTipoContrattoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DipendenteNavigation");

                    b.Navigation("LivelloContrattoNavigation");

                    b.Navigation("TipoContrattoNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Dipendenti", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Sedi", "LuogoDiLavoroSedeNavigation")
                        .WithMany("Dipendenti")
                        .HasForeignKey("SedeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("LuogoDiLavoroSedeNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Dipendenti_Mansioni", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Dipendenti", "DipendenteNavigation")
                        .WithMany("Mansioni_Dipendenti")
                        .HasForeignKey("DipendenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.Mansioni", "MansioniNavigation")
                        .WithMany("Dipendenti_Mansioni")
                        .HasForeignKey("MansioneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DipendenteNavigation");

                    b.Navigation("MansioniNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Dipendenti_Skills", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Dipendenti", "DipendenteNavigation")
                        .WithMany("Dipendenti_Skills")
                        .HasForeignKey("DipendenteNavigationDipendenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.Skills", "SkillNavigation")
                        .WithMany("Dipendenti_Skills")
                        .HasForeignKey("SkillNavigationSkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DipendenteNavigation");

                    b.Navigation("SkillNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Esperienze", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Candidati", "CandidatoNavigation")
                        .WithMany("Esperienze")
                        .HasForeignKey("CandidatoNavigationCandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeetMastersAM.Shared.Model.Mansioni", "MansioneNavigation")
                        .WithMany("Esperienze")
                        .HasForeignKey("MansioneNavigationMansioneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CandidatoNavigation");

                    b.Navigation("MansioneNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Province", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Regioni", "RegioneNavigation")
                        .WithMany("Province")
                        .HasForeignKey("RegioneId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("RegioneNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Regioni", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Nazioni", "NazioneNavigation")
                        .WithMany("Regioni")
                        .HasForeignKey("NazioneId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("NazioneNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Sedi", b =>
                {
                    b.HasOne("MeetMastersAM.Shared.Model.Dipendenti", "ReferenteNavigation")
                        .WithOne("ReferenteSedeNavigation")
                        .HasForeignKey("MeetMastersAM.Shared.Model.Sedi", "ReferenteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ReferenteNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Candidati", b =>
                {
                    b.Navigation("Candidati_Skills");

                    b.Navigation("Candidati_TipiDiDocumenti");

                    b.Navigation("Candidati_TitoliDiStudi");

                    b.Navigation("Esperienze");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Comuni", b =>
                {
                    b.Navigation("CandidatiNascita");

                    b.Navigation("CandidatiResidenza");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Dipendenti", b =>
                {
                    b.Navigation("ColloquiDipendenti");

                    b.Navigation("ColloquiReferenti");

                    b.Navigation("ContrattoNavigation");

                    b.Navigation("Dipendenti_Skills");

                    b.Navigation("Mansioni_Dipendenti");

                    b.Navigation("ReferenteSedeNavigation");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.LivelliContratti", b =>
                {
                    b.Navigation("Contratti");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Mansioni", b =>
                {
                    b.Navigation("Dipendenti_Mansioni");

                    b.Navigation("Esperienze");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Nazioni", b =>
                {
                    b.Navigation("Regioni");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Province", b =>
                {
                    b.Navigation("Comuni");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Regioni", b =>
                {
                    b.Navigation("Province");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Sedi", b =>
                {
                    b.Navigation("Colloquis");

                    b.Navigation("Dipendenti");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.Skills", b =>
                {
                    b.Navigation("Candidati_Skills");

                    b.Navigation("Dipendenti_Skills");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.TipiColloqui", b =>
                {
                    b.Navigation("Colloqui");
                });

            modelBuilder.Entity("MeetMastersAM.Shared.Model.TipiContratto", b =>
                {
                    b.Navigation("Candidati");

                    b.Navigation("Contratti");
                });
#pragma warning restore 612, 618
        }
    }
}
