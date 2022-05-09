using Microsoft.EntityFrameworkCore;


namespace Tummyfull.Models
{
    public class Menu_CardContext : DbContext
    {
        public Menu_CardContext(DbContextOptions<Menu_CardContext> options) : base(options)
        {

        }
        public DbSet<Menu_Card> Menu_Card { get; set; }
    }
}