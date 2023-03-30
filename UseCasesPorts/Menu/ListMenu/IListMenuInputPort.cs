using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UseCasesPorts.Menu.ListMenu
{
    public interface IListMenuInputPort
    {
        Task GetMenus();
    }
}
