using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datInsumos
    {
        #region sigleton
        private static readonly datInsumos _instancia = new datInsumos();
        public static datInsumos Instancia
        {
            get
            {
                return datInsumos._instancia;
            }
        }
        #endregion singleton
        // 1. Listar insumos
        public List<entInsumos> ListarInsumos()
        {
            SqlCommand cmd = null;
            List<entInsumos> lista = new List<entInsumos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarInsumos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInsumos i = new entInsumos();
                    i.IdInsumo = Convert.ToInt32(dr["InsumosID"]);
                    i.NombreInsumo = dr["Nombre"].ToString();
                    i.Cantidad = dr["Cantidad"].ToString();
                    i.EstadoInsumos = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(i);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return lista;
        }

        // 2. Insertar insumo
        public bool InsertarInsumo(entInsumos insumo)
        {
            SqlCommand cmd = null;
            bool rpta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_InsertarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InsumosID", insumo.IdInsumo);
                cmd.Parameters.AddWithValue("@Nombre", insumo.NombreInsumo);
                cmd.Parameters.AddWithValue("@Cantidad", insumo.Cantidad);
                cmd.Parameters.AddWithValue("@Estado", insumo.EstadoInsumos);
                cn.Open();
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return rpta;
        }

        // 3. Modificar insumo
        public bool ModificarInsumo(entInsumos insumo)
        {
            SqlCommand cmd = null;
            bool rpta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ModificarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InsumosID", insumo.IdInsumo);
                cmd.Parameters.AddWithValue("@Nombre", insumo.NombreInsumo);
                cmd.Parameters.AddWithValue("@Cantidad", insumo.Cantidad);
                cmd.Parameters.AddWithValue("@Estado", insumo.EstadoInsumos);
                cn.Open();
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return rpta;
        }

        // 4. Inhabilitar insumo (Estado = 0)
        public bool InhabilitarInsumo(entInsumos insumo)
        {
            SqlCommand cmd = null;
            bool rpta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_InhabilitarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("InsumosID", insumo.IdInsumo);
                cn.Open();
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return rpta;
        }

    }
}
