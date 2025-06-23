using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Dtos.Facilities.Prestamo
{
   public record PrestamoDto
    {
        public string? Codigo { get; set; }
        public int? IdEstadoPrestamo { get; set; }
        public int? LibroID { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public DateTime? FechaConfirmacionDevolucion { get; set; }
        public bool EstadoEntregado { get; set; }
        public bool EstadoRecibido { get; set; }
    }
}
