using BiblioSol.Application.Interfaces.Repositories.Books;
using BiblioSol.Domain.Base;
using BiblioSol.Domain.Entities.Books;
using BiblioSol.Persistence.Base;
using BiblioSol.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Persistence.Repositories
{
    public sealed class LibrosRepository : BaseRepository<Libros>, ILibrosRepository
    {
        public LibrosRepository(DBBibliotecaContext context) : base(context)
        {
        }
        public override Task<OperationResult> AddAsync(Libros entity)
        {
            return base.AddAsync(entity);
        }
    }

}
