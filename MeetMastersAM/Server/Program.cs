using MeetMastersAM.Server.Data;
using MeetMastersAM.Server.Repository;
using MeetMastersAM.Server.Services;
using MeetMastersAM.Shared.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddScoped<IRepositoryBase<Benefits>, RepositoryBase<Benefits>>();
builder.Services.AddScoped<IBenefitRepository, BenefitRepository>();
builder.Services.AddScoped<IServiceBase<Benefits>, ServicesBase<Benefits>>();
builder.Services.AddScoped<IBenefitsServices, BenefitsService>();
builder.Services.AddScoped<IRepositoryBase<Dipendenti>, RepositoryBase<Dipendenti>>();
builder.Services.AddScoped<IDipendentiRepository,  DipendentiRepository>();
builder.Services.AddScoped<IServiceBase<Dipendenti>, ServicesBase<Dipendenti>>();
builder.Services.AddScoped<IDipendentiService, DipendentiService>();




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
