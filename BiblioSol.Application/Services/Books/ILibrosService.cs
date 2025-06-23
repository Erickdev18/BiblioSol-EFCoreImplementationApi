using BiblioSol.Application.Dtos.Books.Libros;
using BiblioSol.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Services.Books
{
    public interface ILibrosService
    {
        Task<OperationResult> AddLibroAsync(LibroAddDto libro);
        Task<OperationResult> GetAllLibrosAsync();
        Task<OperationResult> GetLibroByIdAsync(int id);
        Task<OperationResult> UpdateLibroAsync(LibroUpdateDto libro);
        Task<OperationResult> DeleteLibroAsync(int id);
    }
}
