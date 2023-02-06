using AspNetCoreBlazorLibrary.DataAccess;
using AspNetCoreBlazorLibrary.Repository;
using AspNetCoreBlazorLibrary.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBlazorUI.Startup_Services;

public static class DependencyInjection
{
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnetion")
            ));
        builder.Services.AddScoped<ISeafarerRepository,SeafarerRepository>();

        return builder; 
    }
}
