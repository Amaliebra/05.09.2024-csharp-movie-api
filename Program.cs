var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => { return 10; });

app.MapGet("/fire", () =>
{
    return "Yooo! this is lit!";
});

app.Run();
