namespace Data
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext(AppSettings appSettings) : base(appSettings, "Application")
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}