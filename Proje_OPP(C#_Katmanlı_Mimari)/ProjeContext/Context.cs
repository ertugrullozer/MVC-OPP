using Microsoft.EntityFrameworkCore;
using Proje_OPP_C__Katmanlı_Mimari_.Entity;

namespace Proje_OPP_C__Katmanlı_Mimari_.ProjeContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-62HEUCO\\SQLEXPRESS;database=DbNewOopCore;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
