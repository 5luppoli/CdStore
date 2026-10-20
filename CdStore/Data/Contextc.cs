using CdStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CdStore.Data
{
    public class Context(DbContextOptions<Context> options) : Context
        public Dbset<CDs> Cd { get; set; }


    rotected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfiguration(new ProductConfiguration());
    }
}

}
    
