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
    public class datReqInsumos
    {
        #region Singleton
        private static readonly datReqInsumos _instance = new datReqInsumos();
        public static datReqInsumos Instancia
        {
            get { return datReqInsumos._instance; }
        }
        #endregion Singleton

        #region Metodos

        public List<entReqInsumos> ListarReq()
        {
            SqlCommand cmd = null;
            List<entReqInsumos> list = new List<entReqInsumos>();
            try {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarRequerimientos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    entReqInsumos ri = new entReqInsumos()
                    {
                        IDRequerimiento = Convert.ToInt32(dr["RequerimientoDeInsumoID"]),
                        Estado = Convert.ToBoolean(dr["Estado"].ToString()),
                        FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]),
                        IDEncargado = Convert.ToInt32(dr["IDEncargado"])
                    };
                    list.Add(ri);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return list;
        }
        public Boolean registrarReq(entReqInsumos ri) {
            SqlCommand cmd = null;
            Boolean registrar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequerimientoDeInsumoID", ri.IDRequerimiento);
                cmd.Parameters.AddWithValue("@Estado", ri.Estado);
                cmd.Parameters.AddWithValue("@FechaRegistro", ri.FechaRegistro);
                cmd.Parameters.AddWithValue("@EncargadoalmacenID", ri.IDEncargado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registrar = true;
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return registrar;
        }
        public Boolean anularReq(entReqInsumos ri)
        {
            SqlCommand cmd = null;
            Boolean anular = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAnularRequerimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequerimientoDeInsumoID", ri.IDRequerimiento);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    anular = true;
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return anular;
        }

        #endregion Metodos
    }
}
