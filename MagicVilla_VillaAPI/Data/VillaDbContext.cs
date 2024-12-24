using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaDbContext : DbContext
    {
        public VillaDbContext(DbContextOptions<VillaDbContext> options)
            : base(options)
        {
                
        }
        public DbSet<Villa> Villas { get; set; }
    }
}
