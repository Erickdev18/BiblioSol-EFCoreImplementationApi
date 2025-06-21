using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioSol.Domain.Base;

namespace BiblioSol.Domain.Entities.Facilities
{
    public abstract class EstadoPrestamo: AuditEntity
    {
        public int IdEstadoPrestamo { get; set; }

    }
   
}
