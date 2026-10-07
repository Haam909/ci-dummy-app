using Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Greeting.For("world"));
app.MapGet("/health", () => Results.Ok("healthy"));

app.Run();
