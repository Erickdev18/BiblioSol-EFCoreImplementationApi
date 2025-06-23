using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Dtos.Books.Categoria
{
    public record CategoriaAddDto : CategoriaDto
    {

        public DateTime FechaCreacion { get; set; } 
        public int UsuarioCreacionId { get; set; }
    }
}
