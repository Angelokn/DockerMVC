using DockerMVC.DataAccess;
using DockerMVC.Models;

namespace DockerMVC.DataAcess.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private ApplicationDbContext _db;

        public ProdutoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Produto> Produtos => _db.Produtos;


        //private static Produto[] produtos = new Produto[]
        //{
        //    new Produto {Id=1, Nome="Lápis", Categoria="Material", Quantidade=50, Preco=2.0M},
        //    new Produto {Id=2, Nome="Caderno abc", Categoria="Caderno", Quantidade=30, Preco=25.0M},
        //    new Produto {Id=3, Nome="Mochila azul", Categoria="Mochila", Quantidade=20, Preco=150.0M},
        //    new Produto {Id=4, Nome="Borracha", Categoria="Material", Quantidade=50, Preco=1.5M},
        //};

        //public IEnumerable<Produto> Produtos { get => produtos; }
    }
}
