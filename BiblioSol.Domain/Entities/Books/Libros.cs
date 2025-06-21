using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioSol.Domain.Base;

namespace BiblioSol.Domain.Entities.Books
{
    public abstract class Libros : AuditEntity
    {
        public int LibroID { get; set; }
        public string Titulo { get; set; } /*= string.Empty;*/
        public string Autor { get; set; } /*= string.Empty;*/
        public string ISBN { get; set; } /*= string.Empty;*/
        public int Ejemplares { get; set; }
        public string? Editorial { get; set; } /*= string.Empty;*/
        public int IdCategoria { get; set; }

    }
}
