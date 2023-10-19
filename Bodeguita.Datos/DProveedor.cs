﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Bodeguita.Entidades;
using System.Data;

namespace Bodeguita.Datos
{
    public class DProveedor
    {
        public DataTable Listar()
        {

            MySqlDataReader Resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                Conexion cn = new Conexion();
                sqlcon = cn.conectar();
                MySqlCommand comando = new MySqlCommand("proveedor_listar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public DataTable Buscar(string valor)
        {
            MySqlDataReader Resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                Conexion cn = new Conexion();
                sqlcon = cn.conectar();
                String query = "SELECT idcategoria AS ID, nombre AS CATEGORIA, descripcion AS DESCRIPCION, estado AS ESTADO FROM proveedor WHERE nombre LIKE '%" + valor + "%' OR descripcion LIKE '%" + valor + "%' ORDER BY idcategoria;";
                MySqlCommand comando = new MySqlCommand(query, sqlcon);
                sqlcon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public string Insertar(Proveedor Objeto)
        {
            string Rpta;

            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                Conexion cn = new Conexion();
                sqlcon = cn.conectar();
                MySqlCommand comando = new MySqlCommand("proveedor_insertar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value = Objeto.nombre;
                comando.Parameters.Add("direccion", MySqlDbType.VarChar).Value = Objeto.direccion;
                comando.Parameters.Add("rfc",MySqlDbType.VarChar ).Value= Objeto.rfc;
                comando.Parameters.Add("telefono", MySqlDbType.VarChar).Value = Objeto.telefono;
                sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }


        public string Actualizar(Categoria Objeto)
        {
            string Rpta;

            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                Conexion cn = new Conexion();
                sqlcon = cn.conectar();
                MySqlCommand comando = new MySqlCommand("proveedor_actualizar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("id_cat", MySqlDbType.Int32).Value = Objeto.idcategoria;
                comando.Parameters.Add("nombre_cat", MySqlDbType.VarChar).Value = Objeto.nombre;
                comando.Parameters.Add("descripcion_cat", MySqlDbType.VarChar).Value = Objeto.descripcion;
                sqlcon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;
        }

        public string Desactivar(int id)
        {
            string rpta = "";
            MySqlConnection sqlcon = new MySqlConnection();

            try
            {
                Conexion cn = new Conexion();
                sqlcon = cn.conectar();
                MySqlCommand comando = new MySqlCommand("proveedor_desactivar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("id_cat", MySqlDbType.Int32).Value = id;
                sqlcon.Open();

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

        public string Activar(int id)
        {
            string rpta = "";
            MySqlConnection sqlcon = new MySqlConnection();

            try
            {
                Conexion cn = new Conexion();
                sqlcon = cn.conectar();
                MySqlCommand comando = new MySqlCommand("proveedor_activar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("id_prov", MySqlDbType.Int32).Value = id;
                sqlcon.Open();

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

        public string Eliminar(int id)
        {
            string rpta = "";
            MySqlConnection sqlcon = new MySqlConnection();

            try
            {
                Conexion cn = new Conexion();
                sqlcon = cn.conectar();
                MySqlCommand comando = new MySqlCommand("proveedor_eliminar", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("id_cat", MySqlDbType.Int32).Value = id;
                sqlcon.Open();

                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

    }
}
