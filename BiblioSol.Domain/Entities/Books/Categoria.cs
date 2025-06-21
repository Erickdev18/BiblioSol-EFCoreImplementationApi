using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioSol.Domain.Base;

namespace BiblioSol.Domain.Entities.Books
{
    public abstract class Categoria : AuditEntity
    {
        public int IdCategoria { get; set; }


    }
}
