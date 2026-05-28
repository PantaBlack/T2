using Microsoft.EntityFrameworkCore;
using T2_Naranjo_Gianino.Models;
namespace T2_Naranjo_Gianino.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }
        public DbSet<Distribuidor> Distribuidor { get; set; }
    }
}