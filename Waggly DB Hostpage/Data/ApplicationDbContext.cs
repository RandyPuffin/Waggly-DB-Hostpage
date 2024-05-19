using Microsoft.EntityFrameworkCore;
using Waggly_DB_Hostpage.Models;

namespace Waggly_DB_Hostpage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LeadEntity> Leads { get; set; }
    }
}
