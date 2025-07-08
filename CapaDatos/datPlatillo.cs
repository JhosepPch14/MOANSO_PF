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
    public class datPlatillo
    {
        #region singleton
        private static readonly datPlatillo _instancia = new datPlatillo();

        public static datPlatillo Instancia
        {
            get
            {
                return datPlatillo._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entPlatillo> ListarPlatillo()
        {
            SqlCommand cmd = null;
            List<entPlatillo> lista = new List<entPlatillo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPlatillos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPlatillo platillo = new entPlatillo();
                    platillo.IdPlatillo = Convert.ToInt32(dr["PlatilloID"]);
                    platillo.NombrePlatillo = dr["NombrePlatillo"].ToString();
                    platillo.PrecioPlatillo = Convert.ToDecimal(dr["Precio"]);
                    platillo.EstadoPlatillo = Convert.ToBoolean(dr["EstadoPlatillo"]);
                    platillo.IdTipoPlatillo = Convert.ToInt32(dr["TipoPlatilloID"]);
                    lista.Add(platillo);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar platillos: " + e.Message, e);
            }
            finally
            {
                    cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarPlatillo(entPlatillo platillo)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlatilloID", platillo.IdPlatillo);
                cmd.Parameters.AddWithValue("@NombrePlatillo", platillo.NombrePlatillo);
                cmd.Parameters.AddWithValue("@Precio", platillo.PrecioPlatillo);
                cmd.Parameters.AddWithValue("@EstadoPlatillo", platillo.EstadoPlatillo);
                cmd.Parameters.AddWithValue("@TipoPlatilloID", platillo.IdTipoPlatillo);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar platillo: " + e.Message, e);
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

        public Boolean EditarPlatillo(entPlatillo platillo)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlatilloID", platillo.IdPlatillo);
                cmd.Parameters.AddWithValue("@NombrePlatillo", platillo.NombrePlatillo);
                cmd.Parameters.AddWithValue("@Precio", platillo.PrecioPlatillo);
                cmd.Parameters.AddWithValue("@EstadoPlatillo", platillo.EstadoPlatillo);
                //cmd.Parameters.AddWithValue("@TipoPlatilloID", platillo.IdTipoPlatillo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al editar platillo: " + e.Message, e);
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

        public Boolean DeshabilitarPlatillo(entPlatillo pla)
        {
            SqlCommand cmd = null;
            Boolean deshabilitado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarPlatillo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlatilloID", pla.IdPlatillo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitado = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al deshabilitar platillo: " + e.Message, e);
            }
            finally
            {
                if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return deshabilitado;
        }
        #endregion metodos
    }
}