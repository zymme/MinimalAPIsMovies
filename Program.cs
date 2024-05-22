var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string change1 = "develop change";

string change2 = "change on mr release 1.0.l branch";

string change3 = "maint ticket for MR change 3";


app.MapGet("/", () => "Hello World!");

app.Run();
