using System.ComponentModel;
using System.Runtime.Loader;

var builder = WebApplication.CreateBuilder(args);

#region Add and configure Services
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                  policy =>
                  {
                      policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
                  });
});

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Services.AddLogging();

var files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "CapitalPlatforms*.dll");
var assemblies = files.Select(f => AssemblyLoadContext.Default.LoadFromAssemblyPath(f));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAdvancedDependencyInjection();

builder.Services.Scan(f => f.FromAssemblies(assemblies)
    .AddClasses()
    .AsMatchingInterface());

#endregion

#region Pipeline
var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseAdvancedDependencyInjection();


app.Run();
#endregion