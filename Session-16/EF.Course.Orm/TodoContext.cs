using Microsoft.EntityFrameworkCore;
using EF.Course.Model;
namespace EF.Course.Orm
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    }
}
