using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datMesero
    {
        #region Singleton
        private static readonly datMesero _instance = new datMesero();
        public static datMesero Instancia
        {
            get { return datMesero._instance; }
        }
        #endregion Singleton

        #region Metodos
        public List<entMesero> ListarMesero() { 
            SqlCommand cmd = null;
            List<entMesero> list = new List<entMesero>();
            try { 
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SpListarMesero", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while ( rd.Read() ) {
                    entMesero m = new entMesero();
                    m.IdMesero = Convert.ToInt32(rd["MeseroID"]);
                    m.NombreMesero = rd["Nombre_Mesero"].ToString();
                    m.DNIMesero = Convert.ToInt32(rd["DNI_Mesero"]);
                    m.Telefono = Convert.ToInt32(rd["Telefono"]);
                    m.FechaIngreso = Convert.ToDateTime(rd["FechaIngreso"]);
                    m.EstadoMesero = Convert.ToBoolean(rd["EstadoMesero"]);
                    list.Add(m);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return list;
        }
        public Boolean agregarMesero( entMesero m ) {
            SqlCommand cmd = null;
            Boolean agregar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SpInsertarMesero", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MeseroID", m.IdMesero);
                cmd.Parameters.AddWithValue("Nombre_Mesero", m.NombreMesero);
                cmd.Parameters.AddWithValue("DNI_Mesero", m.DNIMesero);
                cmd.Parameters.AddWithValue("Telefono", m.Telefono);
                cmd.Parameters.AddWithValue("FechaIngreso", m.FechaIngreso);
                cmd.Parameters.AddWithValue("EstadoMesero", m.EstadoMesero);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { agregar = true; }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return agregar;
        }
        public Boolean modificarMesero( entMesero m ) {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMesero", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MeseroID", m.IdMesero);
                cmd.Parameters.AddWithValue("Nombre_Mesero", m.NombreMesero);
                cmd.Parameters.AddWithValue("DNI_Mesero", m.DNIMesero);
                cmd.Parameters.AddWithValue("Telefono", m.Telefono);
                cmd.Parameters.AddWithValue("FechaIngreso", m.FechaIngreso);
                cmd.Parameters.AddWithValue("EstadoMesero", m.EstadoMesero);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { modificar = true; }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return modificar;
        }
        public Boolean inhabilitarMesero( entMesero m ) {
            SqlCommand cmd = null;
            Boolean inhabilitar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMesero", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MeseroID", m.IdMesero);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { inhabilitar = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return inhabilitar;
        }
        #endregion Metodos
    }
}
