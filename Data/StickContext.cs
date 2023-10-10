using Microsoft.EntityFrameworkCore;
using Megha_Stick.Models;

namespace Megha_Stick.Data
{
    public class StickContext : DbContext
    {
        public StickContext(DbContextOptions<StickContext> options)
            : base(options)
        {
        }

        public DbSet<Stick> Stick { get; set; }
    }
}
