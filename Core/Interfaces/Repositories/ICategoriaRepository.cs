using Core.Models;

namespace Core.Interfaces.Repositories
{
    public interface ICategoriaRepository
    {
        Task CadastrarAsync(Categoria categoria);
        Task<IEnumerable<Categoria>> BuscarAsync();
        Task<Categoria> BuscarCategoriaPorIdAsync(int id);
        Task ExcluirAsync(int id);
        Task EditarCategoriaAsync(Categoria categoria);
    }
}
