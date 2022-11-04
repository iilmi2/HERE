#region namespace required to setup database services
using Microsoft.EntityFrameworkCore;
using TrainWatchSystem; // To be able to set extension method AddBackendDependencies in StartupExtensions.cs
#endregion


var builder = WebApplication.CreateBuilder(args);

#region code required to setup database service
var dbConnectionString = builder.Configuration.GetConnectionString("TrainWatchLocalDB");
builder.Services.AddBackendDependencies(options => options.UseSqlServer(dbConnectionString));

#endregion
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
