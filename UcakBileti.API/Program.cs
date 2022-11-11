using UcakBileti.Business.Abstract;
using UcakBileti.Business.Concrete;
using UcakBileti.Data.Abstract;
using UcakBileti.Data.Concrete;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<IUcusService, UcusManager>();
builder.Services.AddSingleton<IUcusRepository, UcusRepository>();

var app = builder.Build();
app.MapControllers();

//app.MapGet("/", () => "Hello World!");

app.Run();
