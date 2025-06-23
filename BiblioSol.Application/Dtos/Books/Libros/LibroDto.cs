using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Dtos.Books.Libros
{
    public record LibroDto
    {
        public int LibroID { get; set; }
        public string Titulo { get; set; }
        public string? Autor { get; set; }
        public string? ISBN { get; set; }
        public int? Ejemplares { get; set; }
        public string? Editorial { get; set; }
        public int IdCategoria { get; set; }
        public bool Estado { get; set; }
    }
}
