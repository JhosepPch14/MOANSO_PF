using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datComprobantePago
    {
        #region Singleton
        private static readonly datComprobantePago _instance = new datComprobantePago();
        public static datComprobantePago Instancia
        {
            get { return datComprobantePago._instance; }
        }
        #endregion Singleton

        #region Metodos

        public List<entComprobantePago> ListarComprobantes()
        {
            SqlCommand cmd = null;
            List<entComprobantePago> lista = new List<entComprobantePago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarComprobantes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entComprobantePago cop = new entComprobantePago();
                    cop.ComprobanteID = Convert.ToInt32(dr["ComprobanteDeVentaID"]);
                    cop.PedidoID = Convert.ToInt32(dr["OrdenpedidoID"]);
                    cop.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    cop.FechaEmision = Convert.ToDateTime(dr["FechaEmision"]);
                    cop.TipoComprobante = dr["TipoComprobante"].ToString();
                    cop.MontoTotal = Convert.ToDecimal(dr["MontoTotal"]);
                    cop.EstadoComprobante = Convert.ToBoolean(dr["EstadoComprobante"]);
                    lista.Add(cop);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean registrarComprobante(entComprobantePago cop) {
            SqlCommand cmd = null;
            Boolean agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SpInsertarComprobante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ComprobanteDeVentaID", cop.ComprobanteID);
                cmd.Parameters.AddWithValue("@ClienteID", cop.ClienteID);
                cmd.Parameters.AddWithValue("@OrdenpedidoID", cop.PedidoID);
                cmd.Parameters.AddWithValue("@TipoComprobante", cop.TipoComprobante);
                cmd.Parameters.AddWithValue("@MontoTotal", cop.MontoTotal);
                cmd.Parameters.AddWithValue("@FechaEmision", cop.FechaEmision);
                cmd.Parameters.AddWithValue("@EstadoComprobante", cop.EstadoComprobante);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    agregar = true;
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return agregar;
        }
        public Boolean deshabilitarComprobante(entComprobantePago cop) {
            SqlCommand cmd = null;
            Boolean inhabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAnularComprobante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ComprobanteDeVentaID", cop.ComprobanteID);
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
