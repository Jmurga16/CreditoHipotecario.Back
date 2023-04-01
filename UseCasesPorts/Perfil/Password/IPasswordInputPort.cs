using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesDTOs.Perfil.Password;

namespace UseCasesPorts.Perfil.Password
{
    public interface IPasswordInputPort
    {
        Task Password(PasswordRequest request);

    }
}
