using ADONet;
using Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesDTOs.Login;
using UseCasesPorts.Login;

namespace UseCases.Login
{
    public class LoginInteractor : ILoginInputPort
    {
        readonly Conexion conexion;
        readonly ILoginOutputPort OutputPort;

        public LoginInteractor(Conexion conexion, ILoginOutputPort outputPort)
        {
            this.conexion = new Conexion();
            OutputPort = outputPort;
        }

        public async Task Login(LoginRequest request)
        {

            IEnumerable<LoginResponse> response;

            try
            {

                List<LoginResponse> lista = new List<LoginResponse>();

                //Opcion 1 : Listar Todo

                using (IDataReader dr = conexion.ejecutarDataReader("USP_MNT_Login", request.UserName, request.Password))
                {
                    while (dr.Read())
                    {
                        LoginResponse entity = new()
                        {
                            Message = Convert.ToString(dr["Message"]),
                            IdUser = Convert.ToInt32(dr["IdUser"]),
                            IdUserType = Convert.ToInt32(dr["IdUserType"])
                        };

                        lista.Add(entity);

                    }

                    response = lista;

                }

            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al ingresar.", ex.Message);
            }

            await OutputPort.Handle(response);
        }


    }
}
