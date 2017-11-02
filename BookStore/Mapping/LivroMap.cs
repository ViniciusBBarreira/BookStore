using BookStore.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livro");

            Property(x => x.Nome)
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.ISBN)
                .HasMaxLength(15)
                .IsRequired();

            Property(x => x.DataLancamento)
                .IsRequired();
        }
    }
}