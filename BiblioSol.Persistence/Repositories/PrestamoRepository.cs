using BiblioSol.Application.Interfaces.Repositories.Facilities;
using BiblioSol.Domain.Entities.Facilities;
using BiblioSol.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Persistence.Repositories
{
    public sealed class PrestamoRepository :BaseRepository<Prestamo>, IPrestamoRepository
    {
        public PrestamoRepository(Context.DBBibliotecaContext context) : base(context)
        {
        }
        public override Task<Domain.Base.OperationResult> AddAsync(Prestamo entity)
        {
            return base.AddAsync(entity);
        }
    }
}
