using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Dtos.Books.Categoria
{
    public record CategoriaUpdateDto : CategoriaDto
    {
        public int IdCategoria { get; set; }

        public DateTime? FechaMod { get; set; }
        public int? UsuarioMod { get; set; }
    }
}
