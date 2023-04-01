using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCasesDTOs.Login
{
    public class LoginResponse
    {
        public string? Message { get; set; } 
        public int IdUser { get; set; }
        public int IdUserType { get; set; }
    }
}
