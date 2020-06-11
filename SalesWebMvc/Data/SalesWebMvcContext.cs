
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Model
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : base(options)
        {

        }

        public DbSet<SalesWebMvc.Models.Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set;}
    }
}
