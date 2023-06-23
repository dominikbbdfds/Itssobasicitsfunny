using InterestLandscape.Domain.Contracts;
using InterestLandscape.Domain.Model;
using InterestLandscape.Infrastructure.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IInterestRepository, InterestRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var interestsGroup = app.MapGroup("/interests");

interestsGroup.MapGet("", (IInterestRepository _interests, int page) =>
{
    return Results.Ok(_interests.GetInterests(page));
})
.WithName("Get all interests")
.WithOpenApi();

interestsGroup.MapGet("/{interestId}", (IInterestRepository _interests, Guid interestId) =>
{
    return Results.Ok(_interests.Get(interestId));
})
.WithName("Get interest")
.WithOpenApi();

interestsGroup.MapDelete("/{interestId}", (IInterestRepository _interests, Guid interestId) =>
{
    _interests.Delete(interestId);
    return Results.Ok();
})
.WithName("Delete interest")
.WithOpenApi();

interestsGroup.MapPost("/{interestId}", (IInterestRepository _interests, Interest interest) =>
{
    _interests.New(interest);
    return Results.Ok();
})
.WithName("Create interest")
.WithOpenApi();

app.Run();