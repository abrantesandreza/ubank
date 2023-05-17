namespace Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoriaRepository(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task CadastrarAsync(Categoria categoria)
        {
            await _dbContext.Categorias.AddAsync(categoria);
            await _dbContext.SaveChangesAsync();
        }
    }
}
