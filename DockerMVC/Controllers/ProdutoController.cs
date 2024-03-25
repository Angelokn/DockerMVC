using DockerMVC.DataAcess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DockerMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtoRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private string message;

        public ProdutoController(IProdutoRepository produtoRepository, 
            IHttpContextAccessor httpContextAccessor)
        {
            _produtoRepository = produtoRepository;
            _httpContextAccessor = httpContextAccessor;
            var hostName = _httpContextAccessor.HttpContext.Request.Host.Value;
            message = $"Docker - ({hostName})";
        }

        public IActionResult Index()
        {
            ViewBag["Message"] = message;
            return View(_produtoRepository.Produtos);
        }
    }
}
