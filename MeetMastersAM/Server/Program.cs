using MeetMastersAM.Server.Data;
using MeetMastersAM.Server.Repository;
using MeetMastersAM.Server.Services;
using MeetMastersAM.Shared.Model;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews()
    .AddJsonOptions(option =>
    option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});


//Benefits
builder.Services.AddScoped<IRepositoryBase<Benefits>, RepositoryBase<Benefits>>();
builder.Services.AddScoped<IBenefitRepository, BenefitRepository>();
builder.Services.AddScoped<IServiceBase<Benefits>, ServicesBase<Benefits>>();
builder.Services.AddScoped<IBenefitsServices, BenefitsService>();
//Candidati
builder.Services.AddScoped<IRepositoryBase<Candidati>, RepositoryBase<Candidati>>();
builder.Services.AddScoped<ICandidatiRepository, CandidatiRepository>();
builder.Services.AddScoped<IServiceBase<Candidati>, ServicesBase<Candidati>>();
builder.Services.AddScoped<ICandidatiService, CandidatiService>();
//Comuni
builder.Services.AddScoped<IRepositoryBase<Comuni>, RepositoryBase<Comuni>>();
builder.Services.AddScoped<IComuniRepository, ComuniRepository>();
builder.Services.AddScoped<IServiceBase<Comuni>, ServicesBase<Comuni>>();
builder.Services.AddScoped<IComuniService, ComuniService>();
//Dipendenti
builder.Services.AddScoped<IRepositoryBase<Dipendenti>, RepositoryBase<Dipendenti>>();
builder.Services.AddScoped<IDipendentiRepository,  DipendentiRepository>();
builder.Services.AddScoped<IServiceBase<Dipendenti>, ServicesBase<Dipendenti>>();
builder.Services.AddScoped<IDipendentiService, DipendentiService>();
//Nazioni
builder.Services.AddScoped<IRepositoryBase<Nazioni>, RepositoryBase<Nazioni>>();
builder.Services.AddScoped<INazioneRepository, NazioniRepository>();
builder.Services.AddScoped<IServiceBase<Nazioni>, ServicesBase<Nazioni>>();
builder.Services.AddScoped<INazioniService, NazioniService>();
//Province
builder.Services.AddScoped<IRepositoryBase<Province>, RepositoryBase<Province>>();
builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
builder.Services.AddScoped<IServiceBase<Province>, ServicesBase<Province>>();
builder.Services.AddScoped<IProvinceService, ProvinceService>();
//Regioni
builder.Services.AddScoped<IRepositoryBase<Regioni>, RepositoryBase<Regioni>>();
builder.Services.AddScoped<IRegioniRepository, RegioniRepository>();
builder.Services.AddScoped<IServiceBase<Regioni>, ServicesBase<Regioni>>();
builder.Services.AddScoped<IRegioniService, RegioniService>();
//Sedi
builder.Services.AddScoped<IRepositoryBase<Sedi>, RepositoryBase<Sedi>>();
builder.Services.AddScoped<ISediRepository, SediRepository>();
builder.Services.AddScoped<IServiceBase<Sedi>, ServicesBase<Sedi>>();
builder.Services.AddScoped<ISediService, SediService>();
//Skills
builder.Services.AddScoped<IRepositoryBase<Skills>, RepositoryBase<Skills>>();
builder.Services.AddScoped<ISkillsRepository, SkillsRepository>();
builder.Services.AddScoped<IServiceBase<Skills>, ServicesBase<Skills>>();
builder.Services.AddScoped<ISkillsService, SkillsService>();
//Mansioni
builder.Services.AddScoped<IRepositoryBase<Mansioni>, RepositoryBase<Mansioni>>();
builder.Services.AddScoped<IMansioniRepository, MansioniRepository>();
builder.Services.AddScoped<IServiceBase<Mansioni>, ServicesBase<Mansioni>>();
builder.Services.AddScoped<IMansioniService, MansioniService>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
