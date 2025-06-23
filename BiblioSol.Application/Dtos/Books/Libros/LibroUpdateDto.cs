using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Dtos.Books.Libros
{
    public record LibroUpdateDto : LibroDto
    {
        public DateTime? FechaMod { get; set; }
        public int? UsuarioMod { get; set; }
    }
}
