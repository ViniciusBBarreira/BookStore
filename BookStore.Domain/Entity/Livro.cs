using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Livro
    {
        public Livro()
        {
            Autores = new List<Autor>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(maximumLength: 30, MinimumLength = 3, ErrorMessage = "Campo inválido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(maximumLength: 30, MinimumLength = 3, ErrorMessage = "Campo inválido")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<Autor> Autores { get; set; }
    }
}