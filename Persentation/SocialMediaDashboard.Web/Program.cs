using SocialMediaDashboard.Web.Infrastructure.Dependency;
using SocialMediaDashboard.Web.Infrastructure.Routing;

var builder = WebApplication.CreateBuilder(args);

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

#region Registor Dependency

DependencyContainer.RegisterDependency(app.Services, app.Configuration);

#endregion

#region Registor Routing

RouteProvider.RegistorRoute(app);

#endregion

app.UseAuthorization();

app.MapRazorPages();

app.Run();
