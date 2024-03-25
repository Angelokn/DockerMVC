using Microsoft.AspNetCore.Mvc;

namespace DockerMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
