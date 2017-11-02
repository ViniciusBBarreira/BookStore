using BookStore.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("Autor");

            Property(x => x.Nome)
                .HasMaxLength(60)
                .IsRequired();

            HasMany(x => x.Livros)
              .WithMany(x => x.Autores)
              .Map(x => x.ToTable("LivroAutor"));
        }
    }
}