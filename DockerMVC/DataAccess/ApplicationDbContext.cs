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
    }
}
