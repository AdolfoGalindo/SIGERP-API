using Microsoft.EntityFrameworkCore;
using SIGERP_API.Context;
using SIGERP_API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => {
    //options.UseSqlServer("Server=DESKTOP-FV37MM9\\SQLEXPRESS;Database=SigerpSAPPrd;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");
    options.UseSqlServer("Server=localhost;Database=SigerpSAPPrd;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");
    });

builder.Services.AddScoped<ICultivoRepository, CultivoRepository>();

//builder.Services.AddMvc()
//     .AddNewtonsoftJson(
//          options => {
//              options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
//          });

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
