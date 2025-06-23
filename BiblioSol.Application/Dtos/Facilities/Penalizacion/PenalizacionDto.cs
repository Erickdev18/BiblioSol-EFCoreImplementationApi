using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Dtos.Facilities.Penalizacion
{
    public record PenalizacionDto
    {
        public int IdPrestamo { get; set; }
        public int IdUsuario { get; set; }
        public int IdLibro { get; set; }
        public DateTime Fecha_Retraso { get; set; }
        public int? Dias_Retraso { get; set; }
        public int? Monto_Penalizacion { get; set; }
        public bool Estado_Penalizacion { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public string? Metodo_Pago { get; set; }
        public string? Descripcion { get; set; }
    }
}
