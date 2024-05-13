using Microsoft.EntityFrameworkCore;
using MultiShop.Models;

namespace MultiShop.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=LAPTOP-ACG39MDK\\SQLEXPRESS;Database=MultiShopp;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(options);
        }
    }
   
}
