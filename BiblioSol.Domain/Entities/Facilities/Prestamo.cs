using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioSol.Domain.Base;

namespace BiblioSol.Domain.Entities.Facilities
{
    public abstract class Prestamo : AuditEntity
    {
        public int IdPrestamo { get; set; }
        public string? Codigo { get; set; }
        public int? IdEstadoPrestamo { get; set; }
        public int? LibroID { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public DateTime? FechaConfirmacionDevolucion { get; set; }
        public bool? EstadoEntregado { get; set; } /*= false; */// Por defecto, el préstamo no está entregado
        public bool?EstadoRecibido { get; set; } /*= false;*/ // Por defecto, el préstamo no está recibido

    }
}
