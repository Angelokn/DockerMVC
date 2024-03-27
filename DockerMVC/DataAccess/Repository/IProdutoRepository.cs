using DockerMVC.Models;

namespace DockerMVC.DataAcess.Repository
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
    }
}
