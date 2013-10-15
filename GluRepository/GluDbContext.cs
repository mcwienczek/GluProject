using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GluRepository
{
    public class GluDbContext : DbContext
    {
        public DbSet<DbFoodProduct> FoodProducts { get; set; }
        public DbSet<DbUser> Users { get; set; }

        public GluDbContext()
            : base("GluDbConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<GluDbContext>());
        }

        public GluDbContext(string connectionString) : base(connectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DbUser>().Property(x => x.Weight).HasPrecision(16, 2);
        }
    }
}