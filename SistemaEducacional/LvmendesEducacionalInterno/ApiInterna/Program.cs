using Lvmendes.Educacional.Comum.Repositorio;
using Lvmendes.Educacional.Comum.Repositorio.Interfaces;
using Lvmendes.Educacional.Comum.Servico;
using Lvmendes.Educacional.Comum.Servico.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICursoServico, CursoServico>();
builder.Services.AddScoped<ICursoRepositorio, CursoRepositorio>();



builder.Services.AddScoped<ITurnoServico, TurnoServico>();
builder.Services.AddScoped<ITurnoRepositorio, TurnoRepositorio>();

builder.Services.AddScoped<IProfessorServico, ProfessorServico>();
builder.Services.AddScoped<IProfessorRepositorio, ProfessorRepositorio>();




var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ComumBDContext>(options => {
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options =>
{
    options.WithOrigins("http://localhost:4200");
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
