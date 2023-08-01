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


builder.Services.AddScoped<ICidadeServico, CidadeServico>();
builder.Services.AddScoped<ICidadeRepositorio, CidadeRepositorio>();

builder.Services.AddScoped<ISalaServico, SalaServico>();
builder.Services.AddScoped<ISalaRepositorio, SalaRepositorio>();

builder.Services.AddScoped<IHorariosServico, HorariosServico>();
builder.Services.AddScoped<IHorariosRepositorio, HorariosRepositorio>();

builder.Services.AddScoped<IConteudoMateriaServico, ConteudoMateriaServico>();
builder.Services.AddScoped<IConteudoMateriaRepositorio, ConteudoMateriaRepositorio>();

builder.Services.AddScoped<IMateriasServico, MateriasServico>();
builder.Services.AddScoped<IMateriasRepositorio, MateriasRepositorio>();



builder.Services.AddScoped<IAlunoServico, AlunoServico>();
builder.Services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();



builder.Services.AddScoped<IInstalacaoServico, InstalacaoServico>();
builder.Services.AddScoped<IInstalacaoRepositorio, InstalacaoRepositorio>();


builder.Services.AddScoped<ICursoOfertadoServico, CursoOfertadoServico>();
builder.Services.AddScoped<ICursoOfertadoRepositorio, CursoOfertadoRepositorio>();


builder.Services.AddScoped<IDisciplinaServico, DisciplinaServico>();
builder.Services.AddScoped<IDisciplinaRepositorio, DisciplinaRepositorio>();

builder.Services.AddScoped<IDisciplinaCursadaServico, DisciplinaCursadaServico>();
builder.Services.AddScoped<IDisciplinaCursadaRepositorio, DisciplinaCursadaRepositorio>();

builder.Services.AddScoped<IInstituicaoServico, InstituicaoServico>();
builder.Services.AddScoped<IInstituicaoRepositorio, InstituicaoRepositorio>();

builder.Services.AddScoped<IMatriculaServico, MatriculaServico>();
builder.Services.AddScoped<IMatriculaRepositorio, MatriculaRepositorio>();

builder.Services.AddScoped<IPeriodoServico, PeriodoServico>();
builder.Services.AddScoped<IPeriodoRepositorio, PeriodoRepositorio>();

builder.Services.AddScoped<ITurmaServico, TurmaServico>();
builder.Services.AddScoped<ITurmaRepositorio, TurmaRepositorio>();

builder.Services.AddScoped<IResponsavelServico, ResponsavelServico>();
builder.Services.AddScoped<IResponsavelRepositorio, ResponsavelRepositorio>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ComumBDContext>(options => {
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    options.EnableSensitiveDataLogging(true);
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
