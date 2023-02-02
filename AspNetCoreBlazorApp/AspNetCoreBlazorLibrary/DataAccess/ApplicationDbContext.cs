using AspNetCoreBlazorLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBlazorLibrary.DataAccess;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{

	}

	public DbSet<Seafarer> Seafarers{ get; set; }
	public DbSet<Experience> Experiences { get; set; }
}
