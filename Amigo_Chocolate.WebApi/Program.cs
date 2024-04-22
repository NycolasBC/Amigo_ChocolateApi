using Amigo_Chocolate.Dados.EntityFramework;
using Amigo_Chocolate.Dados.EntityFramework.Configurations;
using Amigo_Chocolate.Dados.Repositories;
using Amigo_Chocolate.Dominio.Interfaces;
using Amigo_Chocolate.Servico.AutoMapper;
using Amigo_Chocolate.Servico.Interfaces;
using Amigo_Chocolate.Servico.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

builder.Services.AddDbContext<Contexto>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
});

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));

builder.Services.AddScoped<IGrupoRepository, GrupoRepository>();
builder.Services.AddScoped<IGrupoService, GrupoService>();

builder.Services.AddScoped<IGrupoUsuarioRepository, GrupoUsuarioRepository>();
builder.Services.AddScoped<IGrupoUsuarioService, GrupoUsuarioService>();

builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<ILoginService, LoginService>();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

var app = builder.Build();

app.UseCors(options =>
{
    options.AllowAnyOrigin(); // Permitir solicitações de qualquer origem
    options.AllowAnyMethod(); // Permitir solicitações de qualquer método (GET, POST, etc.)
    options.AllowAnyHeader(); // Permitir qualquer cabeçalho na solicitação
});

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
