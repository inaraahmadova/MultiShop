using Microsoft.EntityFrameworkCore;
using MultiShop.Models;

namespace MultiShop.DataAccesLayer
{
    public class MultiShopContext : DbContext
    {
        public MultiShopContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=LAPTOP-ACG39MDK\\SQLEXPRESS;Database=MultiShop;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(options);
        }
    }
}
