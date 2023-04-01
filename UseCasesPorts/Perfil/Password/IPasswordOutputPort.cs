using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesDTOs.Login;
using UseCasesDTOs.Perfil.Password;

namespace UseCasesPorts.Perfil.Password
{
    public interface IPasswordOutputPort
    {
        Task Handle(IEnumerable<PasswordResponse> response);

    }
}
