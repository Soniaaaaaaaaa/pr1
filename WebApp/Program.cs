using Core;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<CoreDbContext>(opt => opt.UseSqlServer(connectionString));
var app = builder.Build();
Database.Migrate(app);

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
