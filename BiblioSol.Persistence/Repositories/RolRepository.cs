using BiblioSol.Application.Interfaces.Repositories.Users;
using BiblioSol.Domain.Entities.Users;
using BiblioSol.Persistence.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Persistence.Repositories
{
    public sealed class RolRepository : BaseRepository<Rol>, IRolRepository
    {
        public RolRepository(Context.DBBibliotecaContext context) : base(context)
        {
        }
        public override Task<Domain.Base.OperationResult> AddAsync(Rol entity)
        {
            return base.AddAsync(entity);
        }
    }
    
}
