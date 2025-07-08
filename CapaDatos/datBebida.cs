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
    public class datBebida
    {
        #region Singleton
        private static readonly datBebida _instance = new datBebida();
        public static datBebida Instancia
        {
            get { return datBebida._instance; }
        }
        #endregion Singleton

        #region Metodos

        public List<entBebida> ListarBebida() { 
            SqlCommand cmd = null;
            List<entBebida> list = new List<entBebida>();
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarBebidas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) { 
                    entBebida b = new entBebida();
                    b.IdBebida = Convert.ToInt32(dr["BebidaID"]);
                    b.NombreBebida = dr["Nombre_Bebida"].ToString();
                    b.Precio = Convert.ToDecimal(dr["Precio"]);
                    b.Tamaño = dr["TamañoBebida"].ToString();
                    b.EstadoBebida = Convert.ToBoolean(dr["EstadoBebida"]);
                    b.TipoBebida = Convert.ToInt32(dr["TipobebidaID"]);
                    list.Add(b);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return list;
        }

        public Boolean agregarBebida (entBebida b) {
            SqlCommand cmd = null;
            Boolean agregar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarBebida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BebidaID", b.IdBebida);
                cmd.Parameters.AddWithValue("@Nombre_Bebida", b.NombreBebida);
                cmd.Parameters.AddWithValue("@Precio", b.Precio);
                cmd.Parameters.AddWithValue("@TamañoBebida", b.Tamaño);
                cmd.Parameters.AddWithValue("@EstadoBebida", b.EstadoBebida);
                cmd.Parameters.AddWithValue("@TipoBebidaID", b.TipoBebida);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    agregar = true;
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return agregar;
        }
        public Boolean modificarBebida (entBebida b) {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarBebida", cn);
                cmd.Parameters.AddWithValue("@BebidaID", b.IdBebida);
                cmd.Parameters.AddWithValue("@Nombre_Bebida", b.NombreBebida);
                cmd.Parameters.AddWithValue("@Precio", b.Precio);
                cmd.Parameters.AddWithValue("@TamañoBebida", b.Tamaño);
                cmd.Parameters.AddWithValue("@EstadoBebida", b.EstadoBebida);
                //cmd.Parameters.AddWithValue("@TipoBebida", b.TipoBebida);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modificar = true;
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return modificar;
        }
        public Boolean inhabilitarBebida (entBebida b) {
            SqlCommand cmd = null;
            Boolean inhabilitar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarBebida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BebidaID", b.IdBebida);
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
