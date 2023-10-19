using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodeguita.Entidades
{
    public class Proveedor
    {
        public int idproveedor { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string rfc { get; set; }
        public string telefono { get; set; }
        public int estado { get; set; }
    }
}
