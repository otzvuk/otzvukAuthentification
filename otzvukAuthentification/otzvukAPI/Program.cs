using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using OtzvukAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ISheduleService, SheduleService>();
var app = builder.Build();

app.MapControllers();
app.Run();
