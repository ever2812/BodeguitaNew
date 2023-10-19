using MySql.Data.MySqlClient;

namespace Bodeguita.Datos
{
   public class Conexion
    {

        public string Servidor = "127.0.0.1";
        public string Base = "bodeguita";
        public string Usuario = "root";
        public string Clave = ""
;
        public MySqlConnection conectar()
        {
            MySqlConnection con = new MySqlConnection("server="+ this.Servidor +";database="+this.Base+";Uid="+this.Usuario+";pdw="+this.Clave+";");
            return con;        
        }
      
    }
}

