using System.Data.Entity;

namespace Entities
{
    public class EntitesContext : DbContext
    {
        public DbSet<Company> Companys { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<HaspKey> HaspKeys { get; set; }
        public DbSet<TypeKey> TypeKeys { get; set; }
    }
}
