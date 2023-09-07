using BEcomentarios.Models;
using Microsoft.EntityFrameworkCore;

namespace BEcomentarios
{
    public class AplicacionDbContext : DbContext
    {
        public DbSet<Comentario>Comentario{ get; set; }
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options): base(options)
        {

        }
        
    }
}
