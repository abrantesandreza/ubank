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

        public async Task<IEnumerable<Categoria>> BuscarAsync() 
        {
            return await _dbContext.Categorias.ToListAsync();
        }

        public async Task<Categoria> BuscarCategoriaPorIdAsync(int id)
        {
            return await _dbContext.Categorias.FindAsync(id);
        }

        public async Task ExcluirAsync(int id)
        {
            var categoria = await BuscarCategoriaPorIdAsync(id);
            _dbContext.Categorias.Remove(categoria);
            await _dbContext.SaveChangesAsync();
        }
    }
}
