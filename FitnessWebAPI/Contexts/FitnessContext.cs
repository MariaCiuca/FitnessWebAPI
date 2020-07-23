using FitnessWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessWebAPI.Contexts
{
    public class FitnessContext : DbContext
    {
        public FitnessContext(DbContextOptions<FitnessContext> option)
            : base(option)
        {
            //Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Valability> Valability { get; set; }
    }
}
