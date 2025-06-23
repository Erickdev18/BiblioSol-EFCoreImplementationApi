using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Dtos.Facilities.Prestamo
{
    public record PrestamoUpdateDto : PrestamoDto
    {
        public int IdPrestamo { get; set; }
        public DateTime? FechaMod { get; set; }
        public int? UsuarioMod { get; set; }
    }
}
