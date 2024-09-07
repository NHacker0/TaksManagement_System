using Microsoft.EntityFrameworkCore;
using TaksManagement_System.Models;

namespace TaksManagement_System.Data
{
    public class TaskManagementContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Task { get; set; }

        public TaskManagementContext(DbContextOptions<TaskManagementContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
