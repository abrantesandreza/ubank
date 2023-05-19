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

        [HttpGet]
        public async Task <IActionResult> BuscarCategoria() => View("Index", await _categoriaRepository.BuscarAsync());

        [HttpGet("excluir")]
        public async Task<IActionResult> MostrarViewExcluir(int id)
        {
            if(id == default)
                return BadRequest("Categoria não encontrada");
            
            return View("Excluir", await _categoriaRepository.BuscarCategoriaPorIdAsync(id));
        }

        [HttpPost("excluir")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _categoriaRepository.ExcluirAsync(id);
            return Ok();
        }

        [HttpGet("editar")]
        public async Task<IActionResult> MostrarViewEditar(int id)
        {
            if(id == default)
                return BadRequest("Categoria não encontrada");
            
            return View("Editar",await _categoriaRepository.BuscarCategoriaPorIdAsync(id));
        }

        [HttpPost("editar")]
        public async Task<IActionResult> Editar(Categoria categoria)
        {
            await _categoriaRepository.EditarCategoriaAsync(categoria);
            return Ok();
        }
    }
}
