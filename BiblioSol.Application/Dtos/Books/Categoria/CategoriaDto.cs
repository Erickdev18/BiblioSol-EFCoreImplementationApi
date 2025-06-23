using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Dtos.Books.Categoria
{
    public record CategoriaDto 
    {
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
