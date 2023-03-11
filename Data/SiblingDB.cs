using Microsoft.EntityFrameworkCore;
using Sibling.Data.Model;

namespace Sibling.Data
{
    public class SiblingDB : DbContext
    {
        public SiblingDB() { }
        public SiblingDB(DbContextOptions<SiblingDB> contextOptions)
            : base(contextOptions) { }
        public DbSet<Father> Fathers { get; set; }
        public DbSet<Mother> Mothers { get; set; }
        public DbSet<Child> Children { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-1EUBJR9\SQLEXPRESS;Database=SiblingDB;Integrated Security=true;TrustServerCertificate=Yes;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}