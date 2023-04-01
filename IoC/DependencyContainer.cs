using ADONet;
using UseCases.Menu.ListMenu;
using UseCasesPorts.Menu.ListMenu;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presenters.Menu.ListMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Login;
using UseCasesPorts.Login;
using Presenters.Login;
using UseCases.Perfil.Password;
using UseCasesPorts.Perfil.Password;
using Presenters.Perfil.Password;

namespace IoC
{
    //Clase de Inyección de Dependencias
    public static class DependencyContainer
    {
        public static IServiceCollection AddInventoryServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<Conexion>();            

            services.AddScoped<IListMenuInputPort, ListMenuInteractor>();
            services.AddScoped<IListMenuOutputPort, ListMenuPresenter>();

            services.AddScoped<ILoginInputPort, LoginInteractor>();
            services.AddScoped<ILoginOutputPort, LoginPresenter>();

            services.AddScoped<IPasswordInputPort, PasswordInteractor>();
            services.AddScoped<IPasswordOutputPort, PasswordPresenter>();

            return services;
        }
    }
}
