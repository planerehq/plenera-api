using Microsoft.Extensions.DependencyInjection;
using Plenera.Infrastructure.DI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddLogging(configure =>
{
    // Add specific logging providers
    configure.AddConsole(); // Logs to the console
    configure.AddDebug();   // Logs to the debug output window

    // Optional: Set minimum log level
    configure.SetMinimumLevel(LogLevel.Information);
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure();

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
