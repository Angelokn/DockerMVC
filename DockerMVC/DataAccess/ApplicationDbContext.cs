using DockerMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerMVC.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().HasData(
                new Produto {Id=1, Nome="Lápis", Categoria="Material", Quantidade=50, Preco=2.0M},
                new Produto {Id=2, Nome="Caderno 55", Categoria="Caderno", Quantidade=30, Preco=25.0M},
                new Produto {Id=3, Nome="Mochila verde", Categoria="Mochila", Quantidade=20, Preco=150.0M},
                new Produto {Id=4, Nome="Borracha", Categoria="Material", Quantidade=50, Preco=1.5M}
                );
        }
    }
}
