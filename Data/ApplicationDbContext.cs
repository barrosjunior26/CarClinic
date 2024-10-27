using CarClinic.Models;
using Microsoft.EntityFrameworkCore;

namespace CarClinic.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<LoginModel> tb_login { get; set; }
    public DbSet<PortalModel> tb_portal { get; set; }
}