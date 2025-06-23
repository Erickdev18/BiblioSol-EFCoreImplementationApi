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
    public sealed class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(DBBibliotecaContext context) : base(context)
        {
        }
        public override Task<OperationResult> AddAsync (Categoria entity)
        {
            return base.AddAsync(entity);
        }
        public override Task<OperationResult> GetAllAsync (System.Linq.Expressions.Expression<Func<Categoria, bool>> filter)
        {
            return base.GetAllAsync(filter);
        }
        public override Task<OperationResult> GetByIdAsync(int id)
        {
            return base.GetByIdAsync(id);
        }
        public override Task<OperationResult> UpdateAsync(Categoria entity)
        {
            return base.UpdateAsync(entity);
        }
        //pendiente a implementar
    }
}
