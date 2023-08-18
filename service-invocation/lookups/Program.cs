var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Lookup service running...");

app.MapGet("/say", () => new
{
    message = "Hello World!"
});

app.Run();
