using Microsoft.EntityFrameworkCore;

namespace testeentity.Models
{
    public class _DbContext:DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options) : base(options){}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Cidades> cidades { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<ClienteFone> clienteFones { get; set; }
        public DbSet<ClienteEnderecos> clienteEnderecos { get; set; }
    }
}
