using Microsoft.EntityFrameworkCore;

namespace ApiDb.Models
{
    public class ApiDbContext:DbContext
    {
        public ApiDbContext(DbContextOptions option) : base(option)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
