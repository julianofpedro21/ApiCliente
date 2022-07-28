using testeentity.Models;
using Microsoft.EntityFrameworkCore;
using testeentity.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Dados da conexao com o banco
builder.Services.AddDbContext<_DbContext>(x => x.UseNpgsql(
    builder.Configuration.GetConnectionString("DefaultConnection"),
    options => options.SetPostgresVersion(new Version(9, 5))
    ));

// Injeção de dependencias dos repositórios
builder.Services.AddScoped<IClientesRepository, ClientesRepository>();
builder.Services.AddScoped<ICidadesRepository, CidadesRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Adicionado para não ocorrer erro de fuso horario no banco de dados
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

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
