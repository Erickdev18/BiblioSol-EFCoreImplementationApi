using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Dtos.Facilities.EstadoPrestamo
{
    public record EstadoPrestamoDto
    {
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
