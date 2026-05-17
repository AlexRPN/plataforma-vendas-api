using Microsoft.EntityFrameworkCore;
using PlataformaVendas.Dominio.Usuarios.Entidades;
using PlataformaVendas.Dominio.UsuariosExterno.Entidades;
using PlataformaVendas.Dominio.UsuariosLocal.Entidades;

namespace PlataformaVendas.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioLocal> UsuarioLocal { get; set; }
        public DbSet<UsuarioExterno> UsuarioExterno { get; set; }
    }
}
