using Microsoft.EntityFrameworkCore;
using System;
using DataAccess.Data;
using Microsoft.AspNetCore.Authentication.Certificate;
using Identity_server_4.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddAuthentication(
        CertificateAuthenticationDefaults.AuthenticationScheme)
    .AddCertificate();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Appdata"));
});
builder.Services.AddScoped<ICoffeeShopService, CoffeeShopService>();
var app = builder.Build();
app.UseAuthentication();
app.MapControllers();



app.Run();
