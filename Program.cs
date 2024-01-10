using FiveToSeven.Services.BSeven;
using FiveToSeven.Services.Five;
using FiveToSeven.Services.Seven;
using FiveToSeven.Services.Six;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFiveServices, FiveServices>();
builder.Services.AddScoped<ISixServices, SixServices>();
builder.Services.AddScoped<ISevenServices, SevenServices>();
builder.Services.AddScoped<IBSevenServices, BSevenServices>();

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
