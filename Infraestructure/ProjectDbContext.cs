using Domains.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Endereco> Enderecos { get; set; } // Nome da tabela banco

        public ProjectDbContext(DbContextOptions options) : base(options) { }
    }
}
