using System.Data.Entity;
using PartMng.Data.Entities;

namespace PartMng.Data
{
    public class PartsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Parts> Parts { get; set; }
        public DbSet<Wholesalers> Wholesalers { get; set; }

        public PartsContext() : base("name=ContractorDb")
        {
           // Database.SetInitializer<ContractorContext>(new DropCreateDatabaseAlways<ContractorContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
