using Microsoft.EntityFrameworkCore;

namespace T.Domain
{
    public class TDbContext : DbContext
    {
        public TDbContext(DbContextOptions<TDbContext> options)
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassHistory> ClassHistorys { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<DynamicRule> DynamicRules { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AddressBook> AddressBooks { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
