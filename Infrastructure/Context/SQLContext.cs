using Fluent.Infrastructure.FluentModel;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Infrastructure.Context
{
    public class SQLContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Logs> Log { get; set; }


        public SQLContext(DbContextOptions<SQLContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure o modelo aqui, se necessário.
        }
    }
}
