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
    public class datOrdenPedido
    {
        #region Singleton
        private static readonly datOrdenPedido _instance = new datOrdenPedido();
        public static datOrdenPedido Instancia
        {
            get { return datOrdenPedido._instance; }
        }
        #endregion Singleton

        #region Metodos
        public List<entOrdenPedido> ListarOrden()
        {
            SqlCommand cmd = null;
            List<entOrdenPedido> lista = new List<entOrdenPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarOrdenPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenPedido op = new entOrdenPedido
                    {
                        PedidoID = Convert.ToInt32(dr["OrdenpedidoID"]),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        NroMesa = Convert.ToInt32(dr["NroMesa"]),
                        Total = Convert.ToInt32(dr["Total"]),
                        EstadoPedido = Convert.ToBoolean(dr["Estado"]),
                        NombreMesero = dr["Nombre_Mesero"].ToString(),
                        MeseroID = Convert.ToInt32(dr["MeseroID"])
                    };
                    lista.Add(op);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return lista;
        }

        public Boolean agregarOrden(entOrdenPedido op) {
            SqlCommand cmd = null;
            Boolean agregar = false;
            try{
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarOrdenPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenpedidoID", op.PedidoID);
                cmd.Parameters.AddWithValue("@Fecha", op.Fecha);
                cmd.Parameters.AddWithValue("@NroMesa", op.NroMesa);
                cmd.Parameters.AddWithValue("@Total", op.Total);
                cmd.Parameters.AddWithValue("@Estado", op.EstadoPedido);
                cmd.Parameters.AddWithValue("@MeseroID", op.MeseroID);
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
        public Boolean modificarOrden(entOrdenPedido op) {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try{
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SpIModificarOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenpedidoID", op.PedidoID);
                cmd.Parameters.AddWithValue("@NroMesa", op.NroMesa);
                cmd.Parameters.AddWithValue("@Total", op.Total);
                cmd.Parameters.AddWithValue("@Estado", op.EstadoPedido);
                cmd.Parameters.AddWithValue("@MeseroID", op.MeseroID);
                cn.Open();
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
        public Boolean inhabilitarOrden(entOrdenPedido op) {
            SqlCommand cmd = null;
            Boolean inhabilitar = false;
            try{
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarOrdenPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrdenpedidoID", op.PedidoID);
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
        public bool actualizarTotal(int pedidoID, decimal total)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Ordenpedido SET Total = @Total WHERE OrdenpedidoID = @PedidoID", Conexion.Instancia.Conectar());
            cmd.Parameters.AddWithValue("@PedidoID", pedidoID);
            cmd.Parameters.AddWithValue("@Total", total);

            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            return i > 0;
        }


        #endregion Metodos
    }
}
