
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstExcercise1
{
    internal class TodoDbContext: DbContext
    {
        public DbSet<Models.Task> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =.\SQLExpress; Database = TodoDatabase; Trusted_Connection = True; TrustServerCertificate = true");
        }
    }
}
