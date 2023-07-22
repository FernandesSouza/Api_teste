using Api_teste.Data;
using Api_teste.Repositores;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorio, Repositorio>();

builder.Services.AddDbContext<BancoContext>
(options => options.UseSqlServer("Server=DESKTOP-OSABV13\\SQL_SERVER2022;Database=CarrosDD;User Id=sa;Password=130901; TrustServerCertificate=True"));


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
