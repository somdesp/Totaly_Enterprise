using Totaly.Services.Identidade.API.Configuration;
using Totaly.WebApi.Core.Identidade;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration();
builder.Services.AddSwaggerConfiguration();
builder.Services.AddIdentityConfiguration(builder.Configuration);
builder.Services.AddMessageBusConfiguration(builder.Configuration);


var app = builder.Build();
app.UseApiConfiguration(builder.Environment);
app.UseAuthConfiguration();
app.UseSwaggerConfiguration();

app.MapControllers();

app.Run();
