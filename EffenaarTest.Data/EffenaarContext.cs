using EffenaarTest.Model;
using Microsoft.EntityFrameworkCore;

namespace EffenaarTest.Data
{
    public class EffenaarContext
    {
        public DbSet<accountModel> Accounts { get; set; }

        public EffenaarContext(DbContextOptions options) : base(options)
        {
        }
    }
}