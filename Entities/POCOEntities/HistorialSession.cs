using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.POCOEntities
{
    public class HistorialSession
    {
        public int IdSession { get; set; }
        public int IdUser { get; set; }
        public string? Ip { get; set; }
        public DateTime Date { get; set; }
    }
}
