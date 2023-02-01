using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Models;

namespace SistemaWebMisRecetas.Data
{
    public class RecetasContext : DbContext
    {
        public RecetasContext(DbContextOptions<RecetasContext> options) : base(options) { }
        public DbSet<Receta> Recetas { get; set; }
    }
}
