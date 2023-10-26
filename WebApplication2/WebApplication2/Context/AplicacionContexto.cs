using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.Modelss;
using WebApplication2.Modelsss;

namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Email> email { get; set; }
        public DbSet<Videojuegos> videojuegos { get; set; }
    }
}
