using FiveToSeven.Services.BSeven;
using FiveToSeven.Services.Eight;
using FiveToSeven.Services.Five;
using FiveToSeven.Services.Mini;
using FiveToSeven.Services.Seven;
using FiveToSeven.Services.Six;
using FiveToSeven.Services.Ten;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(option =>{
    option.AddPolicy("CorsPolicy",
                    builder =>{
                        builder.AllowAnyHeader() // Allows any additional info sent with request (cookies)
                        .AllowAnyMethod() // Allows any Http Methods (HttpGet, HttpPut, etc)
                        .AllowAnyOrigin(); // Allows any domain to access your API
                    }
    );
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFiveServices, FiveServices>();
builder.Services.AddScoped<ISixServices, SixServices>();
builder.Services.AddScoped<ISevenServices, SevenServices>();
builder.Services.AddScoped<IBSevenServices, BSevenServices>();
builder.Services.AddScoped<IgreaterThanLessThan, greaterThanLessThan>();
builder.Services.AddScoped<InameAndWakeUpTime, nameAndWakeUpTime>();
builder.Services.AddScoped<ITwoToFour, TwoToFour>();
builder.Services.AddScoped<IEightServices, EightServices>();
builder.Services.AddScoped<ITenServices, TenServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
