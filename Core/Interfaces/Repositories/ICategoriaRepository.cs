using Core.Models;

namespace Core.Interfaces.Repositories
{
    public interface ICategoriaRepository
    {
        Task CadastrarAsync(Categoria categoria);
    }
}
