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
    public partial class RequerimientoInsumos : Form
    {
        public RequerimientoInsumos()
        {
            InitializeComponent();
            listarReqInsumos();
            llenarDatosCB();
        }
        private List<entDetalleReq> listaDetalles = new List<entDetalleReq>();
        public void listarReqInsumos() { 
            dgvReqInsum.DataSource = logReqInsumos.Instancia.ListarReqInsumos();
        }
        public void listarDetalleReq(int requerimientoID) {
            dgvDetalleReq.DataSource = logDetalleReq.Instancia.ListarDetallesReq(requerimientoID);
        }
        public void llenarDatosCB() {
            cbInsumos.DataSource = LogInsumos.Instancia.ListarInsumos();
            cbInsumos.DisplayMember = "NombreInsumo";
            cbInsumos.ValueMember = "IdInsumo";

            cbEnAlmacen.DataSource = logEnAlmacen.Instancia.ListarEnAlmacen();
            cbEnAlmacen.DisplayMember = "Nombre";
            cbEnAlmacen.ValueMember = "IDEnAlmacen";

        }
        private void limpiarVariables()
        {
            txtIDRequerimiento.Text = "";
            txtCantidad.Text = "";
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try { 
            entReqInsumos ri = new entReqInsumos();
                ri.IDRequerimiento = int.Parse(txtIDRequerimiento.Text.Trim());
                ri.FechaRegistro = dtpFRegistro.Value;
                ri.Estado = chbEstadoReq.Checked;
                ri.IDEncargado = Convert.ToInt32(cbEnAlmacen.SelectedValue);
                logReqInsumos.Instancia.registrarReq(ri);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            listarReqInsumos();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                entReqInsumos ri = new entReqInsumos();
                ri.IDRequerimiento = int.Parse(txtIDRequerimiento.Text.Trim());
                chbEstadoReq.Checked = false;
                logReqInsumos.Instancia.anularReq(ri);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            listarReqInsumos();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            try {
                int insumoID = Convert.ToInt32(cbInsumos.SelectedValue);
                string nombreInsumo = cbInsumos.Text;
                string cantidad = txtCantidad.Text;

                entDetalleReq der = new entDetalleReq { 
                    IDInsumo = insumoID,
                    NombreInsumo = nombreInsumo,
                    Cantidad = cantidad
                };
                listaDetalles.Add(der);

                dgvDetalleReq.DataSource = null;
                dgvDetalleReq.DataSource = listaDetalles;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }

        }
        
        private void btnRDetalle_Click(object sender, EventArgs e)
        {
            int requerimientoID = int.Parse(txtIDRequerimiento.Text);
            List<entDetalleReq> list = new List<entDetalleReq>();

            foreach (DataGridViewRow row in dgvDetalleReq.Rows) {
                if (row.Cells["IdInsumo"].Value != null) {
                    entDetalleReq der = new entDetalleReq
                    {
                        IDRequerimiento = requerimientoID,
                        IDInsumo = Convert.ToInt32(row.Cells["IDInsumo"].Value),
                        Cantidad = row.Cells["Cantidad"].Value.ToString()
                    };
                    list.Add(der);
                }
            }
            if (logDetalleReq.Instancia.registrarDetalleReq(list, requerimientoID))
            {
                MessageBox.Show("Compra registrada correctamente");
                listarDetalleReq(requerimientoID);
                listarReqInsumos();
            }
        }
        private int detalleSeleccionado = -1;
        private void dgvReqInsum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvReqInsum.Rows[e.RowIndex];
            txtIDRequerimiento.Text = filaActual.Cells[0].Value.ToString();
            chbEstadoReq.Checked = Convert.ToBoolean(filaActual.Cells[1].Value);
            dtpFRegistro.Value = Convert.ToDateTime(filaActual.Cells[2].Value);

            int requerimientoID = Convert.ToInt32(filaActual.Cells[0].Value);
            dgvDetalleReq.DataSource = logDetalleReq.Instancia.ListarDetallesReq(requerimientoID);
        }

        private void dgvDetalleReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDetalleReq.Rows[e.RowIndex];
            cbInsumos.Text = fila.Cells["NombreInsumo"].Value.ToString();
            txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
            detalleSeleccionado = e.RowIndex;
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (detalleSeleccionado >= 0 && detalleSeleccionado < listaDetalles.Count)
            {
                var confirmar = MessageBox.Show("¿Desea eliminar este insumo?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    listaDetalles.RemoveAt(detalleSeleccionado);

                    // Actualizar el DataGridView
                    dgvDetalleReq.DataSource = null;
                    dgvDetalleReq.DataSource = listaDetalles;

                    // Limpiar selección
                    detalleSeleccionado = -1;
                    dgvDetalleReq.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un insumo antes de eliminar.");
            }
        }
    }
}
