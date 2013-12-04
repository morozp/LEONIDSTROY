using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonidStroy.Store.Data.DomainObjects
{
    public class StoreContext : DbContext
    {
        public DbSet<Category> Category { get; set; } 
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductElement> ProductElements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
