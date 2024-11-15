using Microsoft.Extensions.DependencyModel;
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using HotelConnect.DataBase.MongoDB;
using MongoDB.Driver;
using HotelConnect.DataAbstraction.MongoDB;
using HotelConnect.DataAbstraction;
internal class Program
{
  private static Assembly[] assemblies;
  private static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);
    assemblies = LoadApplicationAssemblies();
    // Add services to the container.

    builder.Services.AddMediatR(x=>x.RegisterServicesFromAssemblies(assemblies));
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddFluentValidation(opt => opt.RegisterValidatorsFromAssemblies(assemblies));

    var mongoSettings = new MongoDBConfiguration();
    builder.Configuration.GetSection("MongoDBConfig").Bind(mongoSettings);

    //create a single instance of Mongo db Database that can be used everywhere we need it
    builder.Services.AddSingleton<IDatabase>(provider =>
    {
      var mongoClient = new MongoClient(mongoSettings.ConnectionURI);
      var db = mongoClient.GetDatabase(mongoSettings.DatabaseName);

      HotelConnect.DataBase.MongoDB.Database database = new();
      database.db = db;
      return database;
    });

    builder.Services.Scan(scan => scan.FromAssemblies(assemblies)
    .AddClasses(type => type.AssignableTo(typeof(IRepositorie<>))).AsImplementedInterfaces().WithScopedLifetime());

    var app = builder.Build();

    

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
      app.UseSwagger();
      app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
  }

  private static Assembly[] LoadApplicationAssemblies()
  {
    var context = DependencyContext.Default;
    return context.RuntimeLibraries.SelectMany(library => library.GetDefaultAssemblyNames(context))
      .Where(assemblyName => assemblyName.FullName.Contains("HotelConnect"))
      .Select(Assembly.Load)
      .ToArray();
  }
  
}