using Microsoft.EntityFrameworkCore;

namespace ProgrammingInApplications.Data
{
    public class CreditDbContext : DbContext
    {
        public DbSet<Credit> Credits { get; set; }

        public CreditDbContext(DbContextOptions options) : base(options)
        {

        }
        
    }
}
