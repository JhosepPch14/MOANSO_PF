using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datProveedor
    {
        #region singleton
        // Patrón Singleton: Garantiza que solo haya una instancia de esta clase.
        private static readonly datProveedor _instancia = new datProveedor();

        public static datProveedor Instancia
        {
            get{
                return datProveedor._instancia;}
        }
        #endregion singleton

        #region metodos
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                // Usa la instancia de la clase Conexion para conectar
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProveedores", cn); 
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor prov = new entProveedor();
                    prov.IdProveedor = Convert.ToInt32(dr["ProveedorID"]);
                    prov.NombreProveedor = dr["NombreProveedor"].ToString();
                    prov.RUC = dr["RUC"].ToString();
                    prov.EmailProveedor = dr["EmailProveedor"].ToString();
                    prov.FechaRProveedor = Convert.ToDateTime(dr["FechaProveedor"].ToString());
                    prov.EstadoProveedor = Convert.ToBoolean(dr["EstadoProveedor"]);
                    lista.Add(prov);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar proveedores: " + e.Message, e);
            }
            finally
            {
                    cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarProveedor(entProveedor prov)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", prov.IdProveedor);
                cmd.Parameters.AddWithValue("@NombreProveedor", prov.NombreProveedor);
                cmd.Parameters.AddWithValue("@RUC", prov.RUC);
                cmd.Parameters.AddWithValue("@EmailProveedor", prov.EmailProveedor);
                cmd.Parameters.AddWithValue("@FechaProveedor", prov.FechaRProveedor);
                cmd.Parameters.AddWithValue("@EstadoProveedor", prov.EstadoProveedor);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar proveedor: " + e.Message, e);
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }
        public Boolean EditarProveedor(entProveedor prov)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", prov.IdProveedor);
                cmd.Parameters.AddWithValue("@NombreProveedor", prov.NombreProveedor);
                cmd.Parameters.AddWithValue("@RUC", prov.RUC);
                cmd.Parameters.AddWithValue("@EmailProveedor", prov.EmailProveedor);
                cmd.Parameters.AddWithValue("@FechaProveedor", prov.FechaRProveedor);
                cmd.Parameters.AddWithValue("@EstadoProveedor", prov.EstadoProveedor);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al editar proveedor: " + e.Message, e);
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return edita;
        }
        public Boolean DeshabilitarProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean deshabilitado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", Pro.IdProveedor);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitado = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al deshabilitar proveedor: " + e.Message, e);
            }
            finally
            {
                    cmd.Connection.Close();
            }
            return deshabilitado;
        }
        #endregion metodos
    }
}
