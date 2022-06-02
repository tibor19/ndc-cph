var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World, from Actions, with swapping slots, and fixes!");

app.Run();
