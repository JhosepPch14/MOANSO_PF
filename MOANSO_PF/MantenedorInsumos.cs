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
    public partial class MantenedorInsumos : Form
    {
        public MantenedorInsumos()
        {
            InitializeComponent();
            gbDatosInsumo.Enabled = false;
            listarInsumos();
        }
        public void listarInsumos()
        {
            dgvInsumos.DataSource = LogInsumos.Instancia.ListarInsumos();
        }
        public void limpiarVariables() {
            txtIDInsumo.Text = "";
            txtNombreInsumo.Text = "";
            txtCantidadInsumo.Text = "";
        }
        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            try { 
                entInsumos c = new entInsumos();
                c.IdInsumo = int.Parse(txtIDInsumo.Text.Trim());
                c.NombreInsumo = txtNombreInsumo.Text.Trim();
                c.Cantidad = txtCantidadInsumo.Text.Trim();
                c.EstadoInsumos = chbEstadoInsumo.Checked;
                LogInsumos.Instancia.InsertarInsumo(c);
            }
            catch (Exception exc) { 
                MessageBox.Show("Error..." +exc);
            }
            limpiarVariables();
            gbDatosInsumo.Enabled = false;
            listarInsumos();
        }
        private void btnModificarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                entInsumos c = new entInsumos();
                c.IdInsumo = int.Parse(txtIDInsumo.Text.Trim());
                c.NombreInsumo = txtNombreInsumo.Text.Trim();
                c.Cantidad = txtCantidadInsumo.Text.Trim();
                c.EstadoInsumos = chbEstadoInsumo.Checked;
                LogInsumos.Instancia.ModificarInsumo(c);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosInsumo.Enabled = false;
            listarInsumos();
        }

        private void btnInhabilitarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                entInsumos c = new entInsumos();
                c.IdInsumo = int.Parse(txtIDInsumo.Text.Trim());
                c.EstadoInsumos = chbEstadoInsumo.Checked;
                LogInsumos.Instancia.InhabilitarInsumo(c);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosInsumo.Enabled = false;
            listarInsumos();
        }
        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvInsumos.Rows[e.RowIndex];
            txtIDInsumo.Text = filaActual.Cells[0].Value.ToString();
            txtNombreInsumo.Text = filaActual.Cells[1].Value.ToString();
            txtCantidadInsumo.Text = filaActual.Cells[2].Value.ToString();
            chbEstadoInsumo.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosInsumo.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
            Restaurante restaurante = new Restaurante();
            restaurante.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosInsumo.Enabled = true;
            btnAgregarInsumo.Enabled = true;
            limpiarVariables();
            btnModificarInsumo.Enabled = true;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            gbDatosInsumo.Enabled = true;
            btnModificarInsumo.Enabled=true;
            btnAgregarInsumo.Enabled = false;
        }
    }
}
