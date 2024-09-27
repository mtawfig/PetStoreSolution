using Microsoft.EntityFrameworkCore;
using PetStoreWebApp.Models;

namespace PetStoreWebApp.Data
{
    public class PetStoreDbContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }

        public PetStoreDbContext(DbContextOptions<PetStoreDbContext> options) : base(options)
        {
        }
    }
}
