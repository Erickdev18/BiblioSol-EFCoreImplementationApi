using BiblioSol.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Domain.Entities.Users
{
    public abstract class Rol : AuditEntity
    {
        public int RolId { get; set; }  
        public string Nombre { get; set; } /*= string.Empty;*/ // Nombre del rol, por ejemplo: "Administrador", "Usuario", etc.
    
    }
}
