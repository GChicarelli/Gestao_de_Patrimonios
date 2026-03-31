using DotNetEnv;
using GestaoDePatrimonios.Applications.Services;
using GestaoDePatrimonios.Contexts;
using GestaoDePatrimonios.Interfaces;
using GestaoDePatrimonios.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// carregando o .env
Env.Load();

// pegando a connection string
string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

// Conexão com banco
builder.Services.AddDbContext<GestaoDePatrimoniosContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Áreas
builder.Services.AddScoped<IAreaRepository, AreaRepository>();
builder.Services.AddScoped<AreaService>();

// Localizações 
builder.Services.AddScoped<ILocalizacaoRepository, LocalizacaoRepository>();
builder.Services.AddScoped<LocalizacaoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
