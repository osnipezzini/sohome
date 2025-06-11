using SOHome.Cooking;
using SOHome.Cooking.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSOHomeCooking(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseSOHomeCooking();

app.MapGroup("/cooking")
    .MapPost("/recipes", (Recipe recipe) => recipe);

app.Run();
