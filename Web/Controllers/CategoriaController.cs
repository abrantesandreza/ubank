using Core.Interfaces.Repositories;

namespace Web.Controllers
{
    [Route("categoria")]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaController(ICategoriaRepository categoriaRepository) 
        {
            _categoriaRepository = categoriaRepository;
        }
        
        public IActionResult Index() => View();

        [HttpGet("cadastrar")]
        public IActionResult MostrarViewCadastrar() => View("Cadastrar");

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Categoria categoria) 
        {
            await _categoriaRepository.CadastrarAsync(categoria);
            return Ok();
        }
    }
}
