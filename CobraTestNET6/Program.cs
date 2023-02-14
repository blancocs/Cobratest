using CobraTestNET6;
using CobraTestNET6.Controllers;
using CobraTestNET6.Entities.Models;
using CobraTestNET6.Repositories;
using CobraTestNET6.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var MiCors = "MiCors";
// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<AppSettings>(builder.Configuration);

builder.Services.AddDbContext<CobraTestContext>(options => options.UseSqlServer(
                                                    builder.Configuration.GetConnectionString("CobraTest")));


builder.Services.AddScoped<ICarservice, Carservice>();
builder.Services.AddScoped<ICobraTestRepository, CobraTestRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MiCors, builder =>
    {
        builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();

    });
});




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
app.UseCors(MiCors);

app.Run();
