using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MVCProjectCodeFirst.Models;

namespace MVCProjectCodeFirst.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() : base ("UserContext")
        {
        }

        public DbSet<Users> UserSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}