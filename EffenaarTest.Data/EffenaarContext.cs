using EffenaarTest.Model;
using Microsoft.EntityFrameworkCore;

namespace EffenaarTest.Data
{
    public class EffenaarContext : DbContext
    {
        public DbSet<achievementModel> Achievement { get; set; }
        
        public DbSet<accountModel> Accounts { get; set; }

        public EffenaarContext(DbContextOptions options) : base(options)
        {
        }
    }
}