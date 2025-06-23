using BiblioSol.Application.Dtos.Facilities.Prestamo;
using BiblioSol.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Services.Facilities
{
    public interface IPrestamoService
    {
        Task<OperationResult> AddPrestamoAsync(PrestamoAddDto prestamo);
        Task<OperationResult> GetAllPrestamosAsync();
        Task<OperationResult> GetPrestamoByIdAsync(int id);
        Task<OperationResult> UpdatePrestamoAsync(PrestamoUpdateDto prestamo);
        Task<OperationResult> DeletePrestamoAsync(int id);
    }
}
