using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.POCOEntities
{
    public class User
    {
        public int IdUser { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int IdUserType { get; set; }
        public bool IsActive { get; set; }
        public int IsTried { get; set; }
    }
}
