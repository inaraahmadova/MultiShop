using Microsoft.EntityFrameworkCore;

namespace MultiShop.DataAccesLayer
{
    public class MultiShopContext : DbContext
    {
        public MultiShopContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer();
            base.OnConfiguring(options);
        }
    }
}
