var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/test", () => "I am Ricki!");



app.MapGet("/contact", () => "Ypu can find me on GitHub at TechAngelX");
app.Run();