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
    public sealed class PenalizacionRepository : BaseRepository<Penalizacion>, IPenalizacionRepository
    {
        
        public PenalizacionRepository(Context.DBBibliotecaContext context) : base(context)
        {
        }

        public override Task<Domain.Base.OperationResult> AddAsync(Penalizacion entity)
        {
            return base.AddAsync(entity);
        }
    }
}
