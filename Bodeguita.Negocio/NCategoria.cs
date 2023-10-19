using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bodeguita.Datos;
using Bodeguita.Entidades;
using System.Data;



namespace Bodeguita.Negocio
{
    public class NCategoria
    {

        public DataTable Listar() {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
        }

        public DataTable Buscar(string valor) {
            DCategoria dc = new DCategoria();
            return dc.Buscar(valor);
        }

        public string Insertar(string nombre, string descripcion)
        {
            Categoria cat = new Categoria();
            cat.nombre = nombre;
            cat.descripcion = descripcion;
            DCategoria Datos = new DCategoria();
            return Datos.Insertar(cat);
        }

        public string Actualizar(int id,string nombre, string descripcion)
        {
            Categoria cat = new Categoria();
            cat.idcategoria = id;
            cat.nombre = nombre;
            cat.descripcion = descripcion;
            DCategoria Datos = new DCategoria();
            return Datos.Actualizar(cat);
        }

        public string Desactivar(int id_cat) {
            DCategoria datos = new DCategoria();
            return datos.Desactivar(id_cat);
        }

        public string Activar(int id_cat)
        {
            DCategoria datos = new DCategoria();
            return datos.Activar(id_cat);
        }

        public string Eliminar(int id_cat) {
            DCategoria datos = new DCategoria();
            return datos.Eliminar(id_cat);
        }

    }
}
