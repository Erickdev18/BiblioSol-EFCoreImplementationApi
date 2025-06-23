using BiblioSol.Application.Dtos.Users.Usuarios;
using BiblioSol.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Services.Users
{
    public interface IUsuariosService
    {
        Task<OperationResult> AddUsuarioAsync(UsuariosAddDto usuario);
        Task<OperationResult> GetAllUsuariosAsync();
        Task<OperationResult> GetUsuarioByIdAsync(int id);
        Task<OperationResult> UpdateUsuarioAsync(UsuariosUpdateDto usuario);
        Task<OperationResult> DeleteUsuarioAsync(int id);
    }
}
