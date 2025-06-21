using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioSol.Domain.Base;

namespace BiblioSol.Domain.Entities.Users
{
    public abstract class Usuarios : AuditEntity
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; } 
        public string? Apellido { get; set; } 
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string? Telefono { get; set; }

    }
}
