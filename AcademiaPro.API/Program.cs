using AcademiaPro.API.Extensions;
using AcademiaPro.Application;
using AcademiaPro.Domain.Interfaces.Log;
using AcademiaPro.Domain.Interfaces.Repositories;
using AcademiaPro.Infrastructure.Extensions;
using AcademiaPro.Infrastructure.Logs;
using AcademiaPro.Infrastructure.Repositories;
using NLog;

var builder = WebApplication.CreateBuilder(args);

LogManager.Setup().LoadConfigurationFromFile("/nlog.config");

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureInfrastructureServices();
builder.Services.ConfigureApplicationServices();
builder.Services.AddCors(policy => policy.AddPolicy("AllowAll", Opt => Opt
.AllowAnyHeader()
.AllowAnyOrigin()
.AllowAnyMethod()));

builder.Services.AddSingleton<ILoggerManager, LoggerManager>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

//var logger = app.Services.GetRequiredService<ILoggerManager>();
//app.ConfigureExceptionHandler(logger);
app.ConfigureCustomExceptionMiddleware();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.MigrateDatabase();

app.Run();
