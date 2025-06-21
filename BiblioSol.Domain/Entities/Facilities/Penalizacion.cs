using BiblioSol.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Domain.Entities.Facilities
{
    public abstract class Penalizacion : AuditEntity
    {
        public int IdPenalizacion { get; set; }
        public int IdPrestamo { get; set; }
        public int IdUsuario { get; set; }
        public int IdLibro { get; set; }
        public DateTime? Fecha_Retraso { get; set; }
        public DateTime? Dias_Retraso { get; set; }
        public int? Monto_Penalizacion { get; set; }
        public bool Estado_Penalizacion { get; set; } /*= true;*/ // Por defecto, la penalización está activa
        public DateTime Fecha_Pago { get; set; } /*= DateTime.Now;*/ // Fecha de pago por defecto es la fecha actual
        public string? Metodo_Pago { get; set; } /*= string.Empty;*/ // Método de pago por defecto es una cadena vacía

    }
}
