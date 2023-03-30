using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.POCOEntities
{
    public class HistorialPassword
    {
        public int IdHistorial { get; set; }
        public int IdUser { get; set; }
        public string? Password { get; set; }
        public DateTime Date { get; set; }
    }
}
