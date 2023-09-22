using AvaliacaoDjalma.Models;
using Microsoft.EntityFrameworkCore;

namespace AvaliacaoDjalma.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        //public DbSet<Marca> Marcas { get; set; }



    }
}
