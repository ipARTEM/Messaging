using Restaurant.Notification;

Console.OutputEncoding = System.Text.Encoding.UTF8;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<Worker>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run();
