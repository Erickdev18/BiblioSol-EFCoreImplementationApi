using BiblioSol.Application.Dtos.Facilities.EstadoPrestamo;
using BiblioSol.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Services.Facilities
{
    public interface IEstadoPrestamoService
    {
        Task<OperationResult> AddEstadoPrestamoAsync(EstadoPrestamoAddDto estadoPrestamo);
        Task<OperationResult> GetAllEstadoPrestamosAsync();
        Task<OperationResult> GetEstadoPrestamoByIdAsync(int id);
        Task<OperationResult> UpdateEstadoPrestamoAsync(EstadoPrestamoUpdateDto estadoPrestamo);
        Task<OperationResult> DeleteEstadoPrestamoAsync(int id);
    }
}
