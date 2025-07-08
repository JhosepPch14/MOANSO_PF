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
    public class datDetalleReq
    {
        #region Singleton
        private static readonly datDetalleReq _instance = new datDetalleReq();
        public static datDetalleReq Instancia
        {
            get { return datDetalleReq._instance; }
        }
        #endregion Singleton

        #region Metodos

        public List<entDetalleReq> ListarDetalles(int requerimientoID) {
            SqlCommand cmd = null;
            List<entDetalleReq> list = new List<entDetalleReq>();
            try {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarDetalleReq", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequerimientoDeInsumoID", requerimientoID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    entDetalleReq dri = new entDetalleReq()
                    {
                        IDDetalle = Convert.ToInt32(dr["DetallesReqID"]),
                        IDRequerimiento = Convert.ToInt32(dr["RequerimientoDeInsumoID"]),
                        IDInsumo = Convert.ToInt32(dr["InsumosID"]),
                        NombreInsumo = dr["Nombre"].ToString(),
                        Cantidad = dr["Cantidad"].ToString(),
                    };
                    list.Add(dri);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return list;
        }

        public Boolean registrarDetalleReq(List<entDetalleReq> ldr, int requerimientoID)
        {
            SqlCommand cmd = null;
            Boolean registrar = false;
            try {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();

                foreach (var item in ldr)
                {
                    cmd = new SqlCommand("spInsertarDetalleReq", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RequerimientoDeInsumoID", requerimientoID);
                    cmd.Parameters.AddWithValue("@InsumosID", item.IDInsumo);
                    cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) registrar = true;
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return registrar;
        }

        #endregion Metodos
    }
}
