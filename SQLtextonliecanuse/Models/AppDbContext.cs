using Microsoft.EntityFrameworkCore;

namespace SQLtextonliecanuse.Models
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=DESKTOP-DLJIE2U\SQLEXPRESS;Database=TestPostSQL;Trusted_Connection=True;TrustServerCertificate=true");
        }

        public DbSet<Emlpyee> Emlpyee { get; set; } = null;

    }
}
