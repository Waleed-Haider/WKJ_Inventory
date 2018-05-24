using System.Data.Entity;

namespace WKJ_Inventory.Models
{
    public class ItemDbContext : DbContext
    {
        public ItemDbContext():base("WkjDb")
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}