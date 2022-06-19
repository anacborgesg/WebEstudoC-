using Microsoft.EntityFrameworkCore;
using WebEstudo.Models;

namespace WebEstudo.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }

        public static IEnumerable<object>? Client { get; internal set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
