using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class ComprobanteVenta : Form
    {
        public ComprobanteVenta()
        {
            InitializeComponent();
            listarComprobantes();
            llenarDatosCB();
        }
        public void listarComprobantes()
        {
            dgvComprobantes.DataSource = logComprobantePago.Instancia.ListarComprobantes();
        }
        public void limpiarVariables()
        {
            txtIDComprobante.Text = "";
            txtTComprobante.Text = "";
            txtMontoTotal.Text = "0";
        }
        public void llenarDatosCB() {
            cbCliente.DataSource = logCliente.Instancia.ListarCliente();
            cbCliente.DisplayMember = "DNI";
            cbCliente.ValueMember = "ClienteID";

            cbIDVenta.DataSource = logOrdenPedido.Instancia.ListarOrdenes();
            cbIDVenta.DisplayMember = "OrdenpedidoID";
            cbIDVenta.ValueMember = "PedidoID";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                entComprobantePago cop = new entComprobantePago();
                cop.ComprobanteID = Convert.ToInt32(txtIDComprobante.Text.Trim());
                cop.ClienteID = Convert.ToInt32(cbCliente.SelectedValue);
                cop.PedidoID = Convert.ToInt32(cbIDVenta.SelectedValue);
                cop.TipoComprobante = txtTComprobante.Text.Trim();
                cop.MontoTotal = Convert.ToDecimal(txtMontoTotal.Text.Trim());
                cop.FechaEmision = dtpFechaEmision.Value;
                cop.EstadoComprobante = chbCompVenta.Checked;
                logComprobantePago.Instancia.registrarComprobante( cop );
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            listarComprobantes();
        }

        private void btnAnularComprobante_Click(object sender, EventArgs e)
        {
            try {
                entComprobantePago cop = new entComprobantePago();
                cop.ComprobanteID = int.Parse(txtIDComprobante.Text.Trim());
                chbCompVenta.Checked = false;
                logComprobantePago.Instancia.deshabilitarComprobante(cop);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables() ;
            listarComprobantes() ;
        }

        private void dgvComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual  =dgvComprobantes.Rows[e.RowIndex];
            txtIDComprobante.Text = filaActual.Cells["ComprobanteDeVentaID"].Value.ToString();
            txtTComprobante.Text = filaActual.Cells["TipoComprobante"].Value.ToString();
            txtMontoTotal.Text = filaActual.Cells["MontoTotal"].Value.ToString();
            dtpFechaEmision.Text = filaActual.Cells["FechaEmision"].Value.ToString();
            chbCompVenta.Checked = Convert.ToBoolean(filaActual.Cells["EstadoComprobante"].Value);
        }

        private void btnNCliente_Click(object sender, EventArgs e)
        {
            MantenedorCliente formCliente = new MantenedorCliente();
            formCliente.Show();
        }

        private void cbIDVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            entOrdenPedido ordenSeleccionada = cbIDVenta.SelectedItem as entOrdenPedido;
            if (ordenSeleccionada != null)
            {
                txtMontoTotal.Text = ordenSeleccionada.Total.ToString();
            }
        }
    }
}
