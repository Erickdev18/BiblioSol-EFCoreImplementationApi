using BiblioSol.Application.Dtos.Users.Rol;
using BiblioSol.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Services.Users
{
    public interface IRolService
    {
        Task<OperationResult> AddRolAsync(RolAddDto rol);
        Task<OperationResult> GetAllRolsAsync();
        Task<OperationResult> GetRolByIdAsync(int id);
        Task<OperationResult> UpdateRolAsync(RolUpdateDto rol);
        Task<OperationResult> DeleteRolAsync(int id);
    }
}
