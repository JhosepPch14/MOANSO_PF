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
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            gbProveedor.Enabled = false;
            listarProveedor();
        }
        public void listarProveedor() {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }
        public void limpiarVariables() {
            txtIdProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtRucProveedor.Text = "";
            txtCorreoProveedor.Text = "";
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try { 
                entProveedor p = new entProveedor();
                p.IdProveedor = int.Parse(txtIdProveedor.Text);
                p.NombreProveedor = txtNombreProveedor.Text.Trim();
                p.RUC = txtRucProveedor.Text.Trim();
                p.EmailProveedor = txtCorreoProveedor.Text.Trim();
                p.FechaRProveedor = dtpFRegistro.Value;
                p.EstadoProveedor = chbEstadoProveedor.Checked;
                logProveedor.Instancia.InsertarProveedor(p);
            }
            catch (Exception exc) {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbProveedor.Enabled = false;
            listarProveedor();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.IdProveedor = int.Parse(txtIdProveedor.Text.Trim());
                p.NombreProveedor = txtNombreProveedor.Text.Trim();
                p.RUC = txtRucProveedor.Text.Trim();
                p.EmailProveedor = txtCorreoProveedor.Text.Trim();
                p.FechaRProveedor = dtpFRegistro.Value;
                p.EstadoProveedor = chbEstadoProveedor.Checked;
                logProveedor.Instancia.ModificarProveedor(p);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbProveedor.Enabled = false;
            listarProveedor();
        }

        private void btnInhabilitarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor();
                p.IdProveedor = int.Parse(txtIdProveedor.Text.Trim());
                chbEstadoProveedor.Checked = false;
                logProveedor.Instancia.InsertarProveedor(p);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbProveedor.Enabled = false;
            listarProveedor();
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProveedor.Rows[e.RowIndex];
            txtIdProveedor.Text = filaActual.Cells[0].Value.ToString();
            txtNombreProveedor.Text = filaActual.Cells[1].Value.ToString();
            txtRucProveedor.Text = filaActual.Cells[2].Value.ToString();
            txtCorreoProveedor.Text = filaActual.Cells[3].Value.ToString();
            dtpFRegistro.Text = filaActual.Cells[4].Value.ToString();
            chbEstadoProveedor.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbProveedor.Enabled = true;
            btnAgregarProveedor.Enabled = true;
            limpiarVariables();
            btnModificarProveedor.Enabled = true;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            gbProveedor.Enabled = true;
            btnModificarProveedor.Enabled = true;
            btnAgregarProveedor.Enabled = false;
        }
    }
}
