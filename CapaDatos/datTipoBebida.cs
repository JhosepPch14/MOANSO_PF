using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datTipoBebida
    {
        #region Singleton
        private static readonly datTipoBebida _instancia = new datTipoBebida();
        public static datTipoBebida Instancia => _instancia;
        #endregion

        //Listar
        public List<entTipoBebida> ListarTBebida()
        {
            List<entTipoBebida> lista = new List<entTipoBebida>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoBebida", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new entTipoBebida
                    {
                        IdTipoBebida = Convert.ToInt32(dr["IdTipoBebida"]),
                        NombreTipo = dr["NombreTipo"].ToString(),
                        Estado = Convert.ToBoolean(dr["Estado"])
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return lista;
        }

        //Insertar 
        public bool InsertarTBebida(entTipoBebida tb)
        {
            SqlCommand cmd = null;
            bool rpta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_InsertarTipoBebida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoBebida", tb.IdTipoBebida);
                cmd.Parameters.AddWithValue("@NombreTipo", tb.NombreTipo);
                cmd.Parameters.AddWithValue("@Estado", tb.Estado);
                cn.Open();
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception) { throw; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return rpta;
        }

        //Modificar 
        public bool ModificarTBebida(entTipoBebida tb)
        {
            SqlCommand cmd = null;
            bool rpta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ModificarTipoBebida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoBebida", tb.IdTipoBebida);
                cmd.Parameters.AddWithValue("@NombreTipo", tb.NombreTipo);
                cmd.Parameters.AddWithValue("@Estado", tb.Estado);
                cn.Open();
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception) { throw; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return rpta;
        }

        //Inhabilitar
        public bool InhabilitarTBebida(entTipoBebida tb)
        {
            SqlCommand cmd = null;
            bool rpta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_InhabilitarTipoBebida", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoBebida", tb.IdTipoBebida);
                cn.Open();
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception) { throw; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return rpta;
        }
    }
}

