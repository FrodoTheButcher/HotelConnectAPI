using Microsoft.Extensions.DependencyModel;
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
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