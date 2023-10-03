using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetMastersAM.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    BenefitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneBenefit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.BenefitId);
                });

            migrationBuilder.CreateTable(
                name: "LivelliContratti",
                columns: table => new
                {
                    LivelloContrattoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneLivelloContratto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivelliContratti", x => x.LivelloContrattoId);
                });

            migrationBuilder.CreateTable(
                name: "Mansioni",
                columns: table => new
                {
                    MansioneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeMansione = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mansioni", x => x.MansioneId);
                });

            migrationBuilder.CreateTable(
                name: "Nazioni",
                columns: table => new
                {
                    NazioneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazioneNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nazioni", x => x.NazioneId);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneSkill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoSkill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "TipiColloqui",
                columns: table => new
                {
                    TipoColloquioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneTipoColloquio = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipiColloqui", x => x.TipoColloquioId);
                });

            migrationBuilder.CreateTable(
                name: "TipiContratto",
                columns: table => new
                {
                    TipoContrattoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneTipoContratto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipiContratto", x => x.TipoContrattoId);
                });

            migrationBuilder.CreateTable(
                name: "TipiDiDocumento",
                columns: table => new
                {
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneTipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipiDiDocumento", x => x.TipoDocumentoId);
                });

            migrationBuilder.CreateTable(
                name: "TitoliDiStudio",
                columns: table => new
                {
                    TitoloDiStudioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneTitoloDiStudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitoliDiStudio", x => x.TitoloDiStudioId);
                });

            migrationBuilder.CreateTable(
                name: "Regioni",
                columns: table => new
                {
                    RegioneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegioneNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NazioneId = table.Column<int>(type: "int", nullable: false),
                    NazioneNavigationNazioneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regioni", x => x.RegioneId);
                    table.ForeignKey(
                        name: "FK_Regioni_Nazioni_NazioneNavigationNazioneId",
                        column: x => x.NazioneNavigationNazioneId,
                        principalTable: "Nazioni",
                        principalColumn: "NazioneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinciaNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegioneId = table.Column<int>(type: "int", nullable: false),
                    RegioneNavigationRegioneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinciaId);
                    table.ForeignKey(
                        name: "FK_Province_Regioni_RegioneNavigationRegioneId",
                        column: x => x.RegioneNavigationRegioneId,
                        principalTable: "Regioni",
                        principalColumn: "RegioneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comuni",
                columns: table => new
                {
                    ComuneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeComune = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinciaId = table.Column<int>(type: "int", nullable: false),
                    ProvinciaNavigationProvinciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comuni", x => x.ComuneId);
                    table.ForeignKey(
                        name: "FK_Comuni_Province_ProvinciaNavigationProvinciaId",
                        column: x => x.ProvinciaNavigationProvinciaId,
                        principalTable: "Province",
                        principalColumn: "ProvinciaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidati",
                columns: table => new
                {
                    CandidatoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCandidato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CognomeCandidato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ComuneNascitaId = table.Column<int>(type: "int", nullable: false),
                    ComuneResidenzaId = table.Column<int>(type: "int", nullable: false),
                    RecapitoCandidato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailCandidato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoContrattoId = table.Column<int>(type: "int", nullable: false),
                    TipoContrattoNavigationTipoContrattoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidati", x => x.CandidatoId);
                    table.ForeignKey(
                        name: "FK_Candidati_Comuni_ComuneNascitaId",
                        column: x => x.ComuneNascitaId,
                        principalTable: "Comuni",
                        principalColumn: "ComuneId");
                    table.ForeignKey(
                        name: "FK_Candidati_Comuni_ComuneResidenzaId",
                        column: x => x.ComuneResidenzaId,
                        principalTable: "Comuni",
                        principalColumn: "ComuneId");
                    table.ForeignKey(
                        name: "FK_Candidati_TipiContratto_TipoContrattoNavigationTipoContrattoId",
                        column: x => x.TipoContrattoNavigationTipoContrattoId,
                        principalTable: "TipiContratto",
                        principalColumn: "TipoContrattoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidati_Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidatoId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    CandidatoNavigationCandidatoId = table.Column<int>(type: "int", nullable: false),
                    SkillNavigationSkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidati_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidati_Skills_Candidati_CandidatoNavigationCandidatoId",
                        column: x => x.CandidatoNavigationCandidatoId,
                        principalTable: "Candidati",
                        principalColumn: "CandidatoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidati_Skills_Skills_SkillNavigationSkillId",
                        column: x => x.SkillNavigationSkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidati_TipiDiDocumenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidatoId = table.Column<int>(type: "int", nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    CandidatoNavigationCandidatoId = table.Column<int>(type: "int", nullable: false),
                    TipiDiDocumentiNavigationTipoDocumentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidati_TipiDiDocumenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidati_TipiDiDocumenti_Candidati_CandidatoNavigationCandidatoId",
                        column: x => x.CandidatoNavigationCandidatoId,
                        principalTable: "Candidati",
                        principalColumn: "CandidatoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidati_TipiDiDocumenti_TipiDiDocumento_TipiDiDocumentiNavigationTipoDocumentoId",
                        column: x => x.TipiDiDocumentiNavigationTipoDocumentoId,
                        principalTable: "TipiDiDocumento",
                        principalColumn: "TipoDocumentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidati_TitoliDiStudios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidatoId = table.Column<int>(type: "int", nullable: false),
                    TitoloDiStudioId = table.Column<int>(type: "int", nullable: false),
                    CandidatoNavigationCandidatoId = table.Column<int>(type: "int", nullable: false),
                    TitoloDiStudioNavigationTitoloDiStudioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidati_TitoliDiStudios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidati_TitoliDiStudios_Candidati_CandidatoNavigationCandidatoId",
                        column: x => x.CandidatoNavigationCandidatoId,
                        principalTable: "Candidati",
                        principalColumn: "CandidatoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidati_TitoliDiStudios_TitoliDiStudio_TitoloDiStudioNavigationTitoloDiStudioId",
                        column: x => x.TitoloDiStudioNavigationTitoloDiStudioId,
                        principalTable: "TitoliDiStudio",
                        principalColumn: "TitoloDiStudioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Esperienze",
                columns: table => new
                {
                    EsperienzeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataInizio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MansioneId = table.Column<int>(type: "int", nullable: true),
                    Azienda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescrizioneAttivita = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CandidatoId = table.Column<int>(type: "int", nullable: false),
                    MansioneNavigationMansioneId = table.Column<int>(type: "int", nullable: false),
                    CandidatoNavigationCandidatoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Esperienze", x => x.EsperienzeId);
                    table.ForeignKey(
                        name: "FK_Esperienze_Candidati_CandidatoNavigationCandidatoId",
                        column: x => x.CandidatoNavigationCandidatoId,
                        principalTable: "Candidati",
                        principalColumn: "CandidatoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Esperienze_Mansioni_MansioneNavigationMansioneId",
                        column: x => x.MansioneNavigationMansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "MansioneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BenefitsContratti",
                columns: table => new
                {
                    BenefitsBenefitId = table.Column<int>(type: "int", nullable: false),
                    ContrattiContrattoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefitsContratti", x => new { x.BenefitsBenefitId, x.ContrattiContrattoId });
                    table.ForeignKey(
                        name: "FK_BenefitsContratti_Benefits_BenefitsBenefitId",
                        column: x => x.BenefitsBenefitId,
                        principalTable: "Benefits",
                        principalColumn: "BenefitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colloqui",
                columns: table => new
                {
                    ColloquioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataColloquio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SedeId = table.Column<int>(type: "int", nullable: false),
                    TipoColloquioId = table.Column<int>(type: "int", nullable: false),
                    CandidatoId = table.Column<int>(type: "int", nullable: false),
                    DipendenteId = table.Column<int>(type: "int", nullable: false),
                    ReferenteId = table.Column<int>(type: "int", nullable: true),
                    Valutazione = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SedeNavigationSedeId = table.Column<int>(type: "int", nullable: false),
                    TipiColloquioNavigationTipoColloquioId = table.Column<int>(type: "int", nullable: false),
                    CandidatoNavigationCandidatoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colloqui", x => x.ColloquioId);
                    table.ForeignKey(
                        name: "FK_Colloqui_Candidati_CandidatoNavigationCandidatoId",
                        column: x => x.CandidatoNavigationCandidatoId,
                        principalTable: "Candidati",
                        principalColumn: "CandidatoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colloqui_TipiColloqui_TipiColloquioNavigationTipoColloquioId",
                        column: x => x.TipiColloquioNavigationTipoColloquioId,
                        principalTable: "TipiColloqui",
                        principalColumn: "TipoColloquioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contratti",
                columns: table => new
                {
                    ContrattoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LivelloContrattoId = table.Column<int>(type: "int", nullable: false),
                    TipoContrattoId = table.Column<int>(type: "int", nullable: false),
                    DataStipuloContratto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataScadenzaContratto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DipendenteId = table.Column<int>(type: "int", nullable: true),
                    LivelloContrattoNavigationLivelloContrattoId = table.Column<int>(type: "int", nullable: false),
                    TipoContrattoNavigationTipoContrattoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratti", x => x.ContrattoId);
                    table.ForeignKey(
                        name: "FK_Contratti_LivelliContratti_LivelloContrattoNavigationLivelloContrattoId",
                        column: x => x.LivelloContrattoNavigationLivelloContrattoId,
                        principalTable: "LivelliContratti",
                        principalColumn: "LivelloContrattoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contratti_TipiContratto_TipoContrattoNavigationTipoContrattoId",
                        column: x => x.TipoContrattoNavigationTipoContrattoId,
                        principalTable: "TipiContratto",
                        principalColumn: "TipoContrattoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dipendenti",
                columns: table => new
                {
                    DipendenteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDipendente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CognomeDipendente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndirizzoDipendente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecapitoDipendente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascitaDipendente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenereDipendente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SedeId = table.Column<int>(type: "int", nullable: false),
                    IsReferent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dipendenti", x => x.DipendenteId);
                });

            migrationBuilder.CreateTable(
                name: "Dipendenti_Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DipendenteId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    DipendenteNavigationDipendenteId = table.Column<int>(type: "int", nullable: false),
                    SkillNavigationSkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dipendenti_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dipendenti_Skills_Dipendenti_DipendenteNavigationDipendenteId",
                        column: x => x.DipendenteNavigationDipendenteId,
                        principalTable: "Dipendenti",
                        principalColumn: "DipendenteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dipendenti_Skills_Skills_SkillNavigationSkillId",
                        column: x => x.SkillNavigationSkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DipendentiMansioni",
                columns: table => new
                {
                    DipendentiDipendenteId = table.Column<int>(type: "int", nullable: false),
                    MansioniMansioneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DipendentiMansioni", x => new { x.DipendentiDipendenteId, x.MansioniMansioneId });
                    table.ForeignKey(
                        name: "FK_DipendentiMansioni_Dipendenti_DipendentiDipendenteId",
                        column: x => x.DipendentiDipendenteId,
                        principalTable: "Dipendenti",
                        principalColumn: "DipendenteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DipendentiMansioni_Mansioni_MansioniMansioneId",
                        column: x => x.MansioniMansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "MansioneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sedi",
                columns: table => new
                {
                    SedeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrizioneSede = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IndirizzoSede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecapitoSede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailSede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedi", x => x.SedeId);
                    table.ForeignKey(
                        name: "FK_Sedi_Dipendenti_ReferenteId",
                        column: x => x.ReferenteId,
                        principalTable: "Dipendenti",
                        principalColumn: "DipendenteId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BenefitsContratti_ContrattiContrattoId",
                table: "BenefitsContratti",
                column: "ContrattiContrattoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_ComuneNascitaId",
                table: "Candidati",
                column: "ComuneNascitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_ComuneResidenzaId",
                table: "Candidati",
                column: "ComuneResidenzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_TipoContrattoNavigationTipoContrattoId",
                table: "Candidati",
                column: "TipoContrattoNavigationTipoContrattoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_Skills_CandidatoNavigationCandidatoId",
                table: "Candidati_Skills",
                column: "CandidatoNavigationCandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_Skills_SkillNavigationSkillId",
                table: "Candidati_Skills",
                column: "SkillNavigationSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_TipiDiDocumenti_CandidatoNavigationCandidatoId",
                table: "Candidati_TipiDiDocumenti",
                column: "CandidatoNavigationCandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_TipiDiDocumenti_TipiDiDocumentiNavigationTipoDocumentoId",
                table: "Candidati_TipiDiDocumenti",
                column: "TipiDiDocumentiNavigationTipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_TitoliDiStudios_CandidatoNavigationCandidatoId",
                table: "Candidati_TitoliDiStudios",
                column: "CandidatoNavigationCandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_TitoliDiStudios_TitoloDiStudioNavigationTitoloDiStudioId",
                table: "Candidati_TitoliDiStudios",
                column: "TitoloDiStudioNavigationTitoloDiStudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_CandidatoNavigationCandidatoId",
                table: "Colloqui",
                column: "CandidatoNavigationCandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_DipendenteId",
                table: "Colloqui",
                column: "DipendenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_ReferenteId",
                table: "Colloqui",
                column: "ReferenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_SedeNavigationSedeId",
                table: "Colloqui",
                column: "SedeNavigationSedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_TipiColloquioNavigationTipoColloquioId",
                table: "Colloqui",
                column: "TipiColloquioNavigationTipoColloquioId");

            migrationBuilder.CreateIndex(
                name: "IX_Comuni_ProvinciaNavigationProvinciaId",
                table: "Comuni",
                column: "ProvinciaNavigationProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratti_DipendenteId",
                table: "Contratti",
                column: "DipendenteId",
                unique: true,
                filter: "[DipendenteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contratti_LivelloContrattoNavigationLivelloContrattoId",
                table: "Contratti",
                column: "LivelloContrattoNavigationLivelloContrattoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratti_TipoContrattoNavigationTipoContrattoId",
                table: "Contratti",
                column: "TipoContrattoNavigationTipoContrattoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_SedeId",
                table: "Dipendenti",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_Skills_DipendenteNavigationDipendenteId",
                table: "Dipendenti_Skills",
                column: "DipendenteNavigationDipendenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_Skills_SkillNavigationSkillId",
                table: "Dipendenti_Skills",
                column: "SkillNavigationSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_DipendentiMansioni_MansioniMansioneId",
                table: "DipendentiMansioni",
                column: "MansioniMansioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Esperienze_CandidatoNavigationCandidatoId",
                table: "Esperienze",
                column: "CandidatoNavigationCandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Esperienze_MansioneNavigationMansioneId",
                table: "Esperienze",
                column: "MansioneNavigationMansioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Province_RegioneNavigationRegioneId",
                table: "Province",
                column: "RegioneNavigationRegioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Regioni_NazioneNavigationNazioneId",
                table: "Regioni",
                column: "NazioneNavigationNazioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Sedi_ReferenteId",
                table: "Sedi",
                column: "ReferenteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BenefitsContratti_Contratti_ContrattiContrattoId",
                table: "BenefitsContratti",
                column: "ContrattiContrattoId",
                principalTable: "Contratti",
                principalColumn: "ContrattoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Colloqui_Dipendenti_DipendenteId",
                table: "Colloqui",
                column: "DipendenteId",
                principalTable: "Dipendenti",
                principalColumn: "DipendenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colloqui_Dipendenti_ReferenteId",
                table: "Colloqui",
                column: "ReferenteId",
                principalTable: "Dipendenti",
                principalColumn: "DipendenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colloqui_Sedi_SedeNavigationSedeId",
                table: "Colloqui",
                column: "SedeNavigationSedeId",
                principalTable: "Sedi",
                principalColumn: "SedeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contratti_Dipendenti_DipendenteId",
                table: "Contratti",
                column: "DipendenteId",
                principalTable: "Dipendenti",
                principalColumn: "DipendenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dipendenti_Sedi_SedeId",
                table: "Dipendenti",
                column: "SedeId",
                principalTable: "Sedi",
                principalColumn: "SedeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sedi_Dipendenti_ReferenteId",
                table: "Sedi");

            migrationBuilder.DropTable(
                name: "BenefitsContratti");

            migrationBuilder.DropTable(
                name: "Candidati_Skills");

            migrationBuilder.DropTable(
                name: "Candidati_TipiDiDocumenti");

            migrationBuilder.DropTable(
                name: "Candidati_TitoliDiStudios");

            migrationBuilder.DropTable(
                name: "Colloqui");

            migrationBuilder.DropTable(
                name: "Dipendenti_Skills");

            migrationBuilder.DropTable(
                name: "DipendentiMansioni");

            migrationBuilder.DropTable(
                name: "Esperienze");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.DropTable(
                name: "Contratti");

            migrationBuilder.DropTable(
                name: "TipiDiDocumento");

            migrationBuilder.DropTable(
                name: "TitoliDiStudio");

            migrationBuilder.DropTable(
                name: "TipiColloqui");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Candidati");

            migrationBuilder.DropTable(
                name: "Mansioni");

            migrationBuilder.DropTable(
                name: "LivelliContratti");

            migrationBuilder.DropTable(
                name: "Comuni");

            migrationBuilder.DropTable(
                name: "TipiContratto");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Regioni");

            migrationBuilder.DropTable(
                name: "Nazioni");

            migrationBuilder.DropTable(
                name: "Dipendenti");

            migrationBuilder.DropTable(
                name: "Sedi");
        }
    }
}
