using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoWeb.DOMAIN.Core.Interfaces;
using ProyectoWeb.DOMAIN.Infrastructure.Data;
using ProyectoWeb.DOMAIN.Infrastructure.Mapping;
using ProyectoWeb.DOMAIN.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IEmpleadoRepository, EmpleadoRepository>();
builder.Services.AddTransient<IEntrenadorRepository, EntrenadorRepository>();
builder.Services.AddTransient<IAreaRepository, AreaRepository>();
builder.Services.AddTransient<IPersonaRepository, PersonaRepository>();
builder.Services.AddTransient<IPlanesRepository, PlanesRepository>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<IPromocionRepository, PromocionRepository>();
builder.Services.AddTransient<IProveedorRepository, ProveedorRepository>();
builder.Services.AddTransient<IPuestoRepository, PuestoRepository>();





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//get devconnection 
var cnx = builder.Configuration.GetConnectionString("DevConnection");



//agregando dbcontext
builder.Services.AddDbContext<GymisLifeContext>(Options => Options.UseSqlServer(cnx));

//Add automaperprofile
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutomapperProfile());


});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
