namespace Web.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index() => View();

        [HttpGet("cadastrar")]
        public IActionResult MostrarViewCadastrar() => View("Cadastrar");


    }
}
