using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.DataAccess;

// INFO: Configuraciones de nuestra aplicacion
// Add services to the container.
var builder = WebApplication.CreateBuilder(args);


//  2. Conexion con la bsae de datos
const string ConnectionName = "DBUniveristy";
var connectionString = builder.Configuration.GetConnectionString(ConnectionName);

//  3. Agregar Conexto
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));

//  TODO: Conexion con la base de datos

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//Busca los controlers con la ruta establecida
app.MapControllers();

//Ejecuta la aplicacion
app.Run();
