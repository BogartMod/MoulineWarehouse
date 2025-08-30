using Microsoft.EntityFrameworkCore;

namespace MoulineWarehouse.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Таблица с цветами
        public DbSet<ThreadColor> ThreadColors { get; set; }

        // Таблица со складом
        public DbSet<StockItem> StockItems { get; set; }

        // Таблица с наборами
        public DbSet<Kit> Kits { get; set; }

        // Таблица с составом наборов
        public DbSet<KitItem> KitItems { get; set; }
    }
}
