using BiblioMonolitica.web.BLogin.Interfaces;
using BiblioMonolitica.web.BLogin.Logger;
using BiblioMonolitica.web.BLogin.Service;
using BiblioMonolitica.web.Data.Content;
using BiblioMonolitica.web.Data.DbObjects;
using BiblioMonolitica.web.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BibliotecaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BibliotecaContext"),
    sqlServerOptionsAction: sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
        maxRetryCount: 5,
        maxRetryDelay: TimeSpan.FromSeconds(30),
        errorNumbersToAdd: null);
    });
});
builder.Services.AddScoped<ICategoria, CategoriaDb>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<ILog, Log>();

builder.Services.AddScoped<INumeroCorrelativo, NumeroCorrelativoDb>();
builder.Services.AddScoped<INumeroCorrelativoService, NumeroCorrelativoservice>();

builder.Services.AddTransient<ICategoriaService, CategoriaService>();
builder.Services.AddTransient<INumeroCorrelativoService, NumeroCorrelativoservice>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
