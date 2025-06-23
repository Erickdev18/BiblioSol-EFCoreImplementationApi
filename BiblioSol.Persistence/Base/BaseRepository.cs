
using BiblioSol.Application.Interfaces.Repositories;
using BiblioSol.Domain.Base;
using BiblioSol.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;

namespace BiblioSol.Persistence.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DBBibliotecaContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public BaseRepository(DBBibliotecaContext context)
        {
            _context = context; // Store the context for later use
            _dbSet = context.Set<TEntity>(); // Initialize the DbSet for the entity type
        }
        public virtual async Task<OperationResult> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            OperationResult OpResult = new OperationResult();
            try
            {
                var entities = await _dbSet.Where(filter).ToListAsync(); // Retrieve all entities matching the filter
                OpResult = OperationResult.Success($"Entity {typeof(TEntity)} recibido correctamente.", entities); // Set success status
            }
            catch (Exception ex)
            {

                OpResult = OperationResult.Failure($"Error al recibir  Entity {typeof(TEntity)}: de la base de Datos."); // Set failure status with error message
            }
            return OpResult; // Return the operation result
        }
        public virtual async Task<OperationResult> GetByIdAsync(int id)
        {
            OperationResult OpResult = new OperationResult();
            try
            {

                var entity = await _dbSet.FindAsync(id); // Retrieve all entities matching the filter
                if (entity is null) // Check if the entity was found
                {
                    OpResult = OperationResult.Failure("La entidad no ha sido encontrada en la base de datos."); // Return failure if not found
                    return OpResult; // Return the operation result                
                }
                OpResult = OperationResult.Success($"Entity {typeof(TEntity)} recibido correctamente.", entity); // Set success status
            }
            catch (Exception ex)
            {

                OpResult = OperationResult.Failure($"Error al recibir  Entity {typeof(TEntity)}: de la base de Datos."); // Set failure status with error message
            }
            return OpResult; // Return the operation result
        }
        public virtual async Task<OperationResult> AddAsync(TEntity entity)
        {
            OperationResult OpResult = new OperationResult();
            try
            {
                _dbSet.Add(entity); // Add the entity to the DbSet
                await _context.SaveChangesAsync(); // Save changes to the database
                OpResult = OperationResult.Success($"Entity {typeof(TEntity)} agregado correctamente.", entity); // Set success status
            }
            catch (Exception ex)
            {

                throw;
            }
            return OpResult;
        }
        public virtual async Task<OperationResult> UpdateAsync(TEntity entity)
        {
            OperationResult OpResult = new OperationResult();
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync(); // Save changes to the database
                OpResult = OperationResult.Success($"Entity {typeof(TEntity)} actualizado correctamente.", entity);
            }
            catch (Exception ex)
            {

                OpResult = OperationResult.Failure($"Error al actualizar la entidad {typeof(TEntity)} en la base de datos.");
            }
            return OpResult; // Return the operation result
        }
        public virtual async Task<OperationResult> DeleteAsync(TEntity entity)
        {
            OperationResult OpResult = new OperationResult();
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync(); // Save changes to the database
                OpResult = OperationResult.Success($"Entity {typeof(TEntity)} actualizado correctamente.", entity);
            }
            catch (Exception ex)
            {

                OpResult = OperationResult.Failure($"Error al actualizar la entidad {typeof(TEntity)} en la base de datos.");
            }
            return OpResult; // Return the operation result
        }
        public virtual async Task<bool> ExitsAsync(Expression<Func<TEntity, bool>> filter)
        {
            OperationResult OpResult = new OperationResult();
            try
            {
                var exists = await _dbSet.AnyAsync(filter); // Check if any entity matches the filter
                if (exists)
                {
                    OpResult = OperationResult.Success($"Entity {typeof(TEntity)} existe en la base de datos.");
                }
                else
                {
                    OpResult = OperationResult.Failure($"Entity {typeof(TEntity)} no existe en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                OpResult = OperationResult.Failure($"Error al actualizar la entidad {typeof(TEntity)} en la base de datos.");
            }
            return OpResult.IsSuccess; // Return true if the entity exists, false otherwise

        }
    }


}

