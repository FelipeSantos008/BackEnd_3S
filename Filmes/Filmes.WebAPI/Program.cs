using Filmes.WebAPI.BdContextFilme;
using Filmes.WebAPI.Interface;
using Filmes.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FilmeContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultCOnnection")));

//adiciona o repositorio ao container de injeção de dependencia
builder.Services.AddScoped<IGeneroRepository, GeneroRepository > ();
builder.Services.AddScoped<IFilmeRepository, FilmeRepository > ();

//adiciona o sercviço de controllers
builder.Services.AddControllers();

var app = builder.Build();

//adiciona o mapeamento de Controllers
app.MapControllers();

app.Run();
