using BiblioSol.Application.Dtos.Books.Categoria;
using BiblioSol.Domain.Base;
using BiblioSol.Domain.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Services.Books
{
    public interface ICategoriaService
    {
        Task<OperationResult> AddCategoriaAsync(CategoriaAddDto categoria);
        Task<OperationResult> GetAllCategoriasAsync();
        Task<OperationResult> GetCategoriaByIdAsync(int id);
        Task<OperationResult> UpdateCategoriaAsync(CategoriaUpdateDto categoria);
    }
}
