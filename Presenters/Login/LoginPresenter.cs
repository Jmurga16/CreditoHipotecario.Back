using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesDTOs.Login;
using UseCasesPorts.Login;

namespace Presenters.Login
{
    public class LoginPresenter : ILoginOutputPort, IPresenter<IEnumerable<LoginResponse>>
    {
        public IEnumerable<LoginResponse> Content { get; private set; }

        public Task Handle(IEnumerable<LoginResponse> loginResponses)
        {
            Content = loginResponses;
            return Task.CompletedTask;
        }

    }
}
