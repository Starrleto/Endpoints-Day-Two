using RasuliEEndpointsD2.Controllers;
using RasuliEEndpointsD2.Services;
using RasuliEEndpointsD2.Services.Madlib;
using RasuliEEndpointsD2.Services.ReverseString;
using RasuliEEndpointsD2.Services.OddOrEven;
using RasuliEEndpointsD2.Services.ReverseNum;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadlibService, MadlibService>();
builder.Services.AddScoped<IOddEvenService, OddEvenService>();
builder.Services.AddScoped<IReverseStringService, ReverseStringService>();
builder.Services.AddScoped<IReverseNumService, ReverseNumService>();

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
