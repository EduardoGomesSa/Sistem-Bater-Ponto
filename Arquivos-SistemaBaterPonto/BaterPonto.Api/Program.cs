using BaterPonto.Application.CadastroFuncionarioHandler;
using BaterPonto.Application.Commands;
using BaterPonto.Application.Interfaces;
using BaterPonto.Domain.Entities;
using BaterPonto.Infra.Interfaces;
using BaterPonto.Infra.Maps;
using BaterPonto.Infra.Repositories;
using BaterPonto.Infra.Services;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IRequestHandler<AdicionarFuncionario, bool>, CadastroFuncionarioHandler>();
builder.Services.AddScoped<ICadastroFuncionarioService, CadastroFuncionarioService>();
builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
builder.Services.AddScoped<IBaseRepository<Funcionario>, BaseRepository<Funcionario, FuncionarioMap>>();


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
