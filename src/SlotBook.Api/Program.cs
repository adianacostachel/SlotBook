using Microsoft.AspNetCore.Server.Kestrel.Transport.NamedPipes;
using SlotBook.api.Contracts;
using SlotBook.api.Data;
using SlotBook.api.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSingleton<InMemoryStore>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.MapGet("/slots", (InMemoryStore store) => store.Slots);
app.MapPost("/slots", (CreateSlotRequest request, InMemoryStore store) =>
{
    var slot = new Slot(Guid.NewGuid(), request.Resource, request.Start, request.End);
    store.AddSlot(slot);
    return Results.Created($"/slots/{slot.Id}", slot);
}
);

app.Run();

