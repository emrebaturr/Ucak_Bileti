using UcakBileti.Business.Abstract;
using UcakBileti.Business.Concrete;
using UcakBileti.Data;
using UcakBileti.Data.Abstract;
using UcakBileti.Data.Concrete;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddTransient<IFlightService, FlightManager>();
builder.Services.AddTransient<IFlightRepository, FlightRepository>();

builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<ICustomerService,CustomerManager>();

builder.Services.AddTransient<IFlightDetailRepository, FlightDetailRepository>();
builder.Services.AddTransient<IFlightDetailService, FlightDetailManager>();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.MapControllers();
 DataSeeder.SeedData();

app.Run();
