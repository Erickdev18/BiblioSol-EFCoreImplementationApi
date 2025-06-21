using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Domain.Base
{
    public abstract class AuditEntity
    {
        public bool? Estado { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioCreacionId { get; set; }
        public DateTime? FechaMod { get; set; }
        public int? UsuarioMod { get; set; }

    }
}

