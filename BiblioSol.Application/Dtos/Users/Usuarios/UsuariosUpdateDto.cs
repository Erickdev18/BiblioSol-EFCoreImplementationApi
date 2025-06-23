using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSol.Application.Dtos.Users.Usuarios
{
    public record UsuariosUpdateDto : UsuariosDto
    {
        public int UsuarioId { get; set; }
        public DateTime? FechaMod { get; set; }
        public int? UsuarioMod { get; set; }
    }
}
