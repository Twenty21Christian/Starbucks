using Microsoft.EntityFrameworkCore;
using Starbucks.Domain;
using System.Security.Cryptography.X509Certificates;

namespace Starbucks.Persistence
{
    public class StarbucksDbContext : DbContext
    {
        public StarbucksDbContext(DbContextOptions<StarbucksDbContext> options) : base(options)
        {
            
        }

        public required DbSet<Category> Categories { get; set; }

        public required DbSet<Coffe> Coffes { get; set; }

        public required DbSet<Ingredient> Ingredients { get; set; }
    }
}
