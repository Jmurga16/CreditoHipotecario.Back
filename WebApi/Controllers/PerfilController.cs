using Microsoft.AspNetCore.Mvc;
using Presenters.Perfil.Password;
using UseCasesDTOs.Perfil.Password;
using UseCasesPorts.Perfil.Password;

namespace WebApi.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : Controller
    {

        readonly IPasswordInputPort PasswordInputPort;
        readonly IPasswordOutputPort PasswordOutputPort;


        public PerfilController
            (IPasswordInputPort passwordInputPort, IPasswordOutputPort passwordOutputPort) =>
            (PasswordInputPort, PasswordOutputPort) = (passwordInputPort, passwordOutputPort);


        #region EndPoint: Password Usuario
        [HttpPost("change-password")]
        public async Task<IEnumerable<PasswordResponse>> Password(PasswordRequest request)
        {

            await PasswordInputPort.Password(request);

            var Presenter = PasswordOutputPort as PasswordPresenter;

            return Presenter.Content;
        }
        #endregion
    }
}
