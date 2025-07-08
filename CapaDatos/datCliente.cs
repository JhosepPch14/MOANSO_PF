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
    public class datCliente
    {
        #region Singleton
        private static readonly datCliente _instance = new datCliente();
        public static datCliente Instancia { 
            get { return datCliente._instance; }
        }
        #endregion Singleton

        #region Metodos

        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cli.Nombre_Cliente = dr["Nombre_Cliente"].ToString();
                    Cli.DNI = Convert.ToInt32(dr["DNI"]);
                    Cli.Numero = Convert.ToInt32(dr["Numero"]);
                    Cli.Correo = dr["Correo"].ToString();
                    Cli.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    Cli.EstadoCliente = Convert.ToBoolean(dr["EstadoCliente"]);
                    lista.Add(Cli);
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

        public Boolean agregarCliente (entCliente Cli) { 
            SqlCommand cmd = null;
            Boolean agregar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SpInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                cmd.Parameters.AddWithValue("@Nombre_Cliente", Cli.Nombre_Cliente);
                cmd.Parameters.AddWithValue("@DNI", Cli.DNI);
                cmd.Parameters.AddWithValue("@Numero", Cli.Numero);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                cmd.Parameters.AddWithValue("@Fecha", Cli.Fecha);
                cmd.Parameters.AddWithValue("@EstadoCliente", Cli.EstadoCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { 
                    agregar = true;
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally {
                if (cmd != null) cmd.Connection.Close();
            }
            return agregar;
        }

        public Boolean modificarCliente (entCliente Cli) {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                cmd.Parameters.AddWithValue("@Nombre_Cliente", Cli.Nombre_Cliente);
                cmd.Parameters.AddWithValue("@DNI", Cli.DNI);
                cmd.Parameters.AddWithValue("@Numero", Cli.Numero);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
                cmd.Parameters.AddWithValue("@Fecha", Cli.Fecha);
                cmd.Parameters.AddWithValue("@EstadoCliente", Cli.EstadoCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) {
                    modificar = true;
                }
            }
            catch (Exception e) {
                throw e;
            }
            finally { 
                if (cmd != null) cmd.Connection.Close();
            }
            return modificar;
        }

        public Boolean inhabilitarCliente (entCliente Cli) { 
            SqlCommand cmd = null;
            Boolean inhabilitar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
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
