using BiblioSol.Application.Dtos.Facilities.Penalizacion;
using BiblioSol.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Services.Facilities
{
   public interface IPenalizacionService
    {
        Task<OperationResult> AddPenalizacionAsync(PenalizacionAddDto penalizacion);
        Task<OperationResult> GetAllPenalizacionesAsync();
        Task<OperationResult> GetPenalizacionByIdAsync(int id);
        Task<OperationResult> UpdatePenalizacionAsync(PenalizacionUpdateDto penalizacion);
        Task<OperationResult> DeletePenalizacionAsync(int id);
    }
}
