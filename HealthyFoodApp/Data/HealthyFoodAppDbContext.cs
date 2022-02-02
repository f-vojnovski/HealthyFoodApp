using HealthyFoodApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthyFoodApp.Data
{
    public class HealthyFoodAppDbContext : DbContext
    {
        public HealthyFoodAppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Food> Foods{ get; set; }
    }
}
