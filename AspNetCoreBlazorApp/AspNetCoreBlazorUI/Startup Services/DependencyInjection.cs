using AspNetCoreBlazorLibrary.DataAccess;
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

        return builder; 
    }
}
