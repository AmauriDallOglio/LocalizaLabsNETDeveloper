using Microsoft.AspNetCore.Hosting;
using NToastNotify;
using Vaquinha;
using Vaquinha.Extensions;
using Vaquinha.Repository.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddNToastNotifyNoty(new NotyOptions
{
    ProgressBar = true,
    Timeout = 5000
}, new NToastNotifyOption
{
    DefaultSuccessTitle = "Yeah!",
    DefaultSuccessMessage = "Operação realizada com sucesso!",

    DefaultErrorTitle = "Ops!",
    DefaultErrorMessage = "Algo deu errado!"

}).AddRazorRuntimeCompilation();


IConfiguration Configuration = builder.Configuration;
builder.Services.AddDbContext();
builder.Services.AddIocConfiguration(Configuration);
builder.Services.AddAutoMapper(Configuration);
builder.Services.AddCustomConfiguration(Configuration);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

 
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = scope.ServiceProvider.GetService<VaquinhaOnlineDBContext>();
VaquinhaOnLineSeed.Seed(context);

 


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
