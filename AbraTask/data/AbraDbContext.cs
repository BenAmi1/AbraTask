using Microsoft.EntityFrameworkCore;
using AbraTaskAPI.Models.Domain;


namespace AbraTaskAPI.data
{
    public class AbraDbContext : DbContext
    {
        public AbraDbContext(DbContextOptions<AbraDbContext> options) : base(options)
        {

        }

        public DbSet<User> user { get; set; } // create region table for us in the data base
    }
}
