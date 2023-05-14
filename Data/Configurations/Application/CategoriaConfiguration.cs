namespace Data.Configurations.Application
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria");

            builder.HasKey(x => x.Id).HasName("pk_categoria");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Descricao).HasColumnName("descricao");
            builder.Property(x => x.Grupo).HasColumnName("grupo");
        }
    }
}
