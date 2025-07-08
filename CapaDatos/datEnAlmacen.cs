using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datEnAlmacen
    {
        #region Singleton
        private static readonly datEnAlmacen _instance = new datEnAlmacen();
        public static datEnAlmacen Instancia
        {
            get { return datEnAlmacen._instance; }
        }
        #endregion Singleton

        #region Metodos

        public List<entEnAlmacen> ListarEnAlmacen()
        {
            SqlCommand cmd = null;
            List<entEnAlmacen> lista = new List<entEnAlmacen>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarEnAlmacen", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEnAlmacen ea = new entEnAlmacen();
                    ea.IDEnAlmacen = Convert.ToInt32(dr["EncargadoalmacenID"]);
                    ea.Nombre = dr["Nombre"].ToString();
                    ea.DNI = dr["DNI"].ToString();
                    ea.Numero = dr["Numero"].ToString();
                    ea.FechaIngreso = Convert.ToDateTime(dr["FechaRegistro"]);
                    ea.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(ea);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean agregarEnAlmacen(entEnAlmacen ea)
        {
            SqlCommand cmd = null;
            Boolean agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEnAlmacen", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EncargadoalmacenID", ea.IDEnAlmacen);
                cmd.Parameters.AddWithValue("@Nombre", ea.Nombre);
                cmd.Parameters.AddWithValue("@DNI", ea.DNI);
                cmd.Parameters.AddWithValue("@Numero", ea.Numero);
                cmd.Parameters.AddWithValue("@FechaRegistro", ea.FechaIngreso);
                cmd.Parameters.AddWithValue("@Estado", ea.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    agregar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return agregar;
        }

        public Boolean modificarEnAlmacen(entEnAlmacen ea)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarEnAlmacen", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EncargadoalmacenID", ea.IDEnAlmacen);
                cmd.Parameters.AddWithValue("@Nombre", ea.Nombre);
                cmd.Parameters.AddWithValue("@DNI", ea.DNI);
                cmd.Parameters.AddWithValue("@Numero", ea.Numero);
                cmd.Parameters.AddWithValue("@FechaRegistro", ea.FechaIngreso);
                cmd.Parameters.AddWithValue("@Estado", ea.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modificar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return modificar;
        }
        public Boolean inhabilitarEnAlmacen(entEnAlmacen ea)
        {
            SqlCommand cmd = null;
            Boolean inhabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarEnAlmacen", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EncargadoalmacenID", ea.IDEnAlmacen);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inhabilitar = true;
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inhabilitar;
        }

        #endregion Metodos

    }
}
