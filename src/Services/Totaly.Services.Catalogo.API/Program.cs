using Totaly.Services.Catalogo.API.Configuration;
using Totaly.WebApi.Core.Identidade;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApiConfiguration(builder.Configuration);
builder.Services.RegisterServices();
builder.Services.AddSwaggerConfiguration();
builder.Services.AddJwtConfiguration(builder.Configuration);

var app = builder.Build();

app.UseApiConfiguration(builder.Environment);
app.UseSwaggerConfiguration();
app.MapControllers();

app.Run();
