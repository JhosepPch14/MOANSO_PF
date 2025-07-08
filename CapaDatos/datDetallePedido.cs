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
    public class datDetallePedido
    {
        #region Singleton
        private static readonly datDetallePedido _instance = new datDetallePedido();
        public static datDetallePedido Instancia
        {
            get { return datDetallePedido._instance; }
        }
        #endregion Singleton

        #region Metodos

        public List<entDetallePedido> ListarDetalles(int pedidoID)
        {
            SqlCommand cmd = null;
            List<entDetallePedido> list = new List<entDetallePedido>();
            try {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarDetallePorPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenpedidoID", pedidoID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    entDetallePedido dp = new entDetallePedido
                    {
                        PedidoID = Convert.ToInt32(dr["OrdenpedidoID"]),
                        DetalleID = Convert.ToInt32(dr["DetallepedidoID"]),
                        PlatilloID = Convert.ToInt32(dr["PlatilloID"]),
                        NombrePlatillo = dr["NombrePlatillo"].ToString(),
                        Cantidad = Convert.ToInt32(dr["Cantidad"]),
                        Precio = Convert.ToDecimal(dr["Precio"]),
                        Subtotal = Convert.ToDecimal(dr["Subtotal"])
                    };
                    list.Add(dp);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return list;
        }
        public Boolean registrarDetalle(List<entDetallePedido> ldp, int pedidoID) {
            SqlCommand cmd = null;
            Boolean registrar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cn.Open();

                foreach (var item in ldp)
                {
                    cmd = new SqlCommand("spInsertarDetallePedido", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@DetallepedidoID", pedidoID);
                    cmd.Parameters.AddWithValue("@OrdenpedidoID", pedidoID);
                    cmd.Parameters.AddWithValue("@PlatilloID", item.PlatilloID);
                    cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                    cmd.Parameters.AddWithValue("@Subtotal", item.Subtotal);

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
