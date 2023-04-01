using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesDTOs.Perfil.Password;
using UseCasesPorts.Perfil.Password;

namespace Presenters.Perfil.Password
{
    public class PasswordPresenter : IPasswordOutputPort, IPresenter<IEnumerable<PasswordResponse>>
    {
        public IEnumerable<PasswordResponse> Content { get; private set; }

        public Task Handle(IEnumerable<PasswordResponse> response)
        {
            Content = response;
            return Task.CompletedTask;
        }
    }
}
