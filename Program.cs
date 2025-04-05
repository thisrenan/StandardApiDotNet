var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi("documentation");

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

List<PersonRecord> people = [
    new ("Renan", "Romig", "renanromig@hotmail.com"),
    new ("Arianne", "Romig", "annesantos.03@hotmail.com"),
    new ("Nicole", "Romig", "nicoleromig@hotmail.com")
    ];

app.MapGet("/person", () => people);
app.MapGet("/person/{id}", (int id) => people[id]);
app.MapPost("/person", (PersonRecord p) => people.Add(p));
app.MapDelete("/person", (int id) => people.RemoveAt(id));

app.Run();

public record PersonRecord (string FirstName, string LastName, string Email);