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
    public partial class CompraInsumos : Form
    {
        public CompraInsumos()
        {
            InitializeComponent();
            listarCompraReq();
            llenarDatosCB();
        }
        public void listarCompraReq()
        {
            dgvCompraReq.DataSource = logCompraReq.Instancia.ListarCompraReq();
        }
        public void limpiarVariables()
        {
            txtIDCompra.Text = "";
            txtEncargado.Text = "";
            txtMetodoPago.Text = "";
            txtMontoTotal.Text = ""; 
        }
        public void llenarDatosCB()
        {
            cbIDReq.DataSource = logReqInsumos.Instancia.ListarReqInsumos();
            cbIDReq.DisplayMember = "IDRequerimiento";
            cbIDReq.ValueMember = "IDRequerimiento";

            cbIDProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
            cbIDProveedor.DisplayMember = "NombreProveedor";
            cbIDProveedor.ValueMember = "IDProveedor";
        }
        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                entCompraReq cr = new entCompraReq();
                cr.IdCompra = int.Parse(txtIDCompra.Text.Trim());
                cr.IDRequerimiento = Convert.ToInt32(cbIDReq.SelectedValue);
                cr.IDProveedor = Convert.ToInt32(cbIDProveedor.SelectedValue);
                cr.Encargado = txtEncargado.Text.Trim();
                cr.FechaCompra = dtpFechaCompra.Value;
                cr.MetodoPago = txtMetodoPago.Text.Trim();
                cr.MontoTotal = Convert.ToDecimal(txtMontoTotal.Text.Trim());
                cr.EstadoCompra = chbEstadoCompra.Checked;
                logCompraReq.Instancia.registrarCompraReq(cr);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            listarCompraReq();
        }

        private void btnAnularReq_Click(object sender, EventArgs e)
        {
            try
            {
                entCompraReq cr = new entCompraReq();
                cr.IdCompra = int.Parse(txtIDCompra.Text.Trim());
                chbEstadoCompra.Checked = false;
                logCompraReq.Instancia.anularCompraReq(cr);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            listarCompraReq();
        }

        private void dgvCompraReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCompraReq.Rows[e.RowIndex];
            txtIDCompra.Text = filaActual.Cells["IdCompra"].Value.ToString();
            txtEncargado.Text = filaActual.Cells["Encargado"].Value.ToString();
            txtMetodoPago.Text = filaActual.Cells["IdCompra"].Value.ToString();
            txtMontoTotal.Text = filaActual.Cells["MontoTotal"].Value.ToString();
            chbEstadoCompra.Checked = Convert.ToBoolean(filaActual.Cells["EstadoCompra"].Value);
        }
    }
}
