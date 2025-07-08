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
    public class datCompraReq
    {
        #region Singleton
        private static readonly datCompraReq _instance = new datCompraReq();
        public static datCompraReq Instancia
        {
            get { return datCompraReq._instance; }
        }
        #endregion Singleton

        #region Metodos

        public List<entCompraReq> ListarCompraReq()
        {
            SqlCommand cmd = null;
            List<entCompraReq> lista = new List<entCompraReq>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCompraReq", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCompraReq cr = new entCompraReq();
                    cr.IdCompra = Convert.ToInt32(dr["ComprainsumosID"]);
                    cr.Encargado = dr["Encargado"].ToString();
                    cr.FechaCompra = Convert.ToDateTime(dr["FechaCompra"].ToString());
                    cr.MetodoPago = dr["MetodoPago"].ToString();
                    cr.MontoTotal = Convert.ToDecimal(dr["MontoTotal"]);
                    cr.IDRequerimiento = Convert.ToInt32(dr["RequerimientoDeInsumoID"]);
                    cr.IDProveedor = Convert.ToInt32(dr["ProveedorID"]);
                    cr.EstadoCompra = Convert.ToBoolean(dr["EstadoCompra"]);
                    lista.Add(cr);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        public Boolean registrarCompraReq(entCompraReq cr)
        {
            SqlCommand cmd = null;
            Boolean registrar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SpRegistrarCompraReq", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IdCompra", cr.IdCompra);
                cmd.Parameters.AddWithValue("@Encargado", cr.Encargado);
                cmd.Parameters.AddWithValue("@FechaCompra", cr.FechaCompra);
                cmd.Parameters.AddWithValue("@MetodoPago", cr.MetodoPago);
                cmd.Parameters.AddWithValue("@MontoTotal", cr.MontoTotal);
                cmd.Parameters.AddWithValue("@EstadoCompra", cr.EstadoCompra);
                cmd.Parameters.AddWithValue("@IDRequerimiento", cr.IDRequerimiento);
                cmd.Parameters.AddWithValue("@IDProveedor", cr.IDProveedor);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registrar = true;
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return registrar;
        }
        public Boolean anularCompraReq(entCompraReq cr)
        {
            SqlCommand cmd = null;
            Boolean anular = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAnularCompraReq", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCompra", cr.IdCompra);
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
