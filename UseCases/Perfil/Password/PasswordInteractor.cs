using ADONet;
using Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasesDTOs.Perfil.Password;
using UseCasesPorts.Perfil.Password;

namespace UseCases.Perfil.Password
{
    public class PasswordInteractor : IPasswordInputPort
    {
        readonly Conexion conexion;
        readonly IPasswordOutputPort OutputPort;

        public PasswordInteractor(Conexion conexion, IPasswordOutputPort outputPort)
        {
            this.conexion = new Conexion();
            OutputPort = outputPort;
        }

        public async Task Password(PasswordRequest request)
        {

            IEnumerable<PasswordResponse> response;

            try
            {

                List<PasswordResponse> lista = new List<PasswordResponse>();

                //Opcion 1 : Listar Todo

                using (IDataReader dr = conexion.ejecutarDataReader("USP_MNT_Password", request.UserName, request.OldPassword, request.NewPassword))
                {
                    while (dr.Read())
                    {
                        PasswordResponse entity = new()
                        {
                            Result = Convert.ToString(dr["result"]),
                         
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
