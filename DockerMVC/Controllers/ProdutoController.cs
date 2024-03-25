using DockerMVC.DataAcess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DockerMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtoRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProdutoController(IProdutoRepository produtoRepository, 
            IHttpContextAccessor httpContextAccessor)
        {
            _produtoRepository = produtoRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
