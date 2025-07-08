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
    public class datTPlatillo
    {
        #region Singleton
        private static readonly datTPlatillo _instance = new datTPlatillo();
        public static datTPlatillo Instancia
        {
            get { return datTPlatillo._instance; }
        }
        #endregion Singleton

        #region Metodos

        public List<entTPlatillo> ListarTPlatillo() {
            SqlCommand cmd = null;
            List<entTPlatillo> lista = new List<entTPlatillo>();
            try {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTiposPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) { 
                    entTPlatillo tp = new entTPlatillo
                    {
                        IdTipoPlatillo = Convert.ToInt32(dr["IDTipoPlatillo"]),
                        NombreTipo = dr["NombreTipo"].ToString(),
                        EstadoTPlatillo = Convert.ToBoolean(dr["Estado"])
                    };

                    lista.Add(tp);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean agregarTPlatillo (entTPlatillo tp) {
            SqlCommand cmd = null;
            Boolean agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spInsertarTipoPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoPlatillo", tp.IdTipoPlatillo);
                cmd.Parameters.AddWithValue("@NombreTipo", tp.NombreTipo);
                cmd.Parameters.AddWithValue("@Estado", tp.EstadoTPlatillo);
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
        public Boolean modificarTPlatillo (entTPlatillo tp) {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spEditarTipoPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                cmd.Parameters.AddWithValue("@IdTipoPlatillo", tp.IdTipoPlatillo);
                cmd.Parameters.AddWithValue("@NombreTipo", tp.NombreTipo);
                cmd.Parameters.AddWithValue("@EstadoTPlatillo", tp.EstadoTPlatillo);
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
        public Boolean inhabilitarTPlatillo (entTPlatillo tp) {
            SqlCommand cmd = null;
            Boolean inhabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spDeshabilitarTipoPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoPlatillo", tp.IdTipoPlatillo);
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
