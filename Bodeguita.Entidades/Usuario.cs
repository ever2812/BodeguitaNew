using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodeguita.Entidades
{
    public class Usuario
    {
        public int idusuario { get; set; }
        public int idrol { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string clave { get; set; }
        public int estado { get; set; }
    }
}
