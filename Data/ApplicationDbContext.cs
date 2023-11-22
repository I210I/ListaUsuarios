using lista_usuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace lista_usuarios.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
