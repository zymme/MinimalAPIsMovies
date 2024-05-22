var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string change1 = "develop change";

app.MapGet("/", () => "Hello World!");

app.Run();
