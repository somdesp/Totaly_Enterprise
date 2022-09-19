using Totaly.WebApp.MVC.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices(builder.Configuration);
builder.Services.AddIdentityConfiguration();
builder.Services.AddMvcConfiguration(builder.Configuration);


var app = builder.Build();

app.UseMvcConfiguration(app.Environment);

app.Run();
