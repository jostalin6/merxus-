using Microsoft.EntityFrameworkCore;
using CatterPillerDevelopement.Controllers;
using CatterPiller_Development.Entity;

namespace Developement.Helper
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<User> User { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Reason> Reason { get; set; }
        public DbSet<AssemblyUnit> AssemblyUnit { get; set; }
        public DbSet<Stage> Stage { get; set; }

    }
}
