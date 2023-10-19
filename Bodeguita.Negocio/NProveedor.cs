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
   public class NProveedor
    {

          public DataTable Listar()
        {
            DProveedor Datos = new DProveedor();
            return Datos.Listar();
        }

        public DataTable Buscar(string valor)
        {
            DProveedor dc = new DProveedor();
            return dc.Buscar(valor);
        }

        public string Insertar(string nombre, string direccion, string rfc, string telefono)
        {
            Proveedor cat = new Proveedor();
            cat.nombre = nombre;
            cat.direccion = direccion;
            cat.rfc = rfc;
            cat.telefono = telefono;

            DProveedor Datos = new DProveedor();
            return Datos.Insertar(cat);
        }

        public string Actualizar(int id, string nombre, string descripcion)
        {
            Categoria cat = new Categoria();
            cat.idcategoria = id;
            cat.nombre = nombre;
            cat.descripcion = descripcion;
            DCategoria Datos = new DCategoria();
            return Datos.Actualizar(cat);
        }

        public string Desactivar(int id_cat)
        {
            DProveedor datos = new DProveedor();
            return datos.Desactivar(id_cat);
        }

        public string Activar(int id_cat)
        {
            DProveedor datos = new DProveedor();
            return datos.Activar(id_cat);
        }

        public string Eliminar(int id_cat)
        {
            DProveedor datos = new DProveedor();
            return datos.Eliminar(id_cat);
        }

    }
}
