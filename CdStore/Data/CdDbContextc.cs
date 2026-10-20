using CdStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CdStore.Data
{
    public class CdDbContext : DbContext
    {
        public CdDbContext (DbContextOptions<CdDbContext> options) : base(options)
        {
        }

        public DbSet<CDs> CDs { get; set; }
    }
}