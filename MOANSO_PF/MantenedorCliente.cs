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
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            gbDatosCliente.Enabled = false;
            listarCliente();
        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }
        public void limpiarVariables()
        {
            txtIDCliente.Text = "";
            txtNombreCliente.Text = "";
            txtNumeroCliente.Text = "";
            txtCorreoCliente.Text = "";
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try { 
                entCliente c = new entCliente();
                c.ClienteID = int.Parse(txtIDCliente.Text.Trim());
                c.Nombre_Cliente = txtNombreCliente.Text.Trim();
                c.DNI = int.Parse(txtDNICliente.Text.Trim());
                c.Numero = int.Parse(txtNumeroCliente.Text.Trim());
                c.Correo = txtCorreoCliente.Text.Trim();
                c.Fecha = dtpFechaCliente.Value;
                c.EstadoCliente = chbEstadoCliente.Checked;
                logCliente.Instancia.agregarCliente(c);
            }
            catch (Exception exc) {
                MessageBox.Show("Error..."+exc);
            }
            limpiarVariables();
            gbDatosCliente.Enabled = false;
            listarCliente();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try {
                entCliente c = new entCliente();
                c.ClienteID = int.Parse(txtIDCliente.Text.Trim());
                c.Nombre_Cliente = txtNombreCliente.Text.Trim();
                c.DNI = int.Parse(txtDNICliente.Text.Trim());
                c.Numero = int.Parse(txtNumeroCliente.Text.Trim());
                c.Correo = txtCorreoCliente.Text.Trim();
                c.Fecha = dtpFechaCliente.Value;
                c.EstadoCliente = chbEstadoCliente.Checked;
                logCliente.Instancia.modificarCliente(c);
            }
            catch (Exception exc) {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosCliente.Enabled = false;
            listarCliente();
        }

        private void btnInhabilitarCliente_Click(object sender, EventArgs e)
        {
            try {
                entCliente c = new entCliente();
                c.ClienteID = int.Parse(txtIDCliente.Text.Trim());
                chbEstadoCliente.Checked = false;
                logCliente.Instancia.inhabilitarCliente(c);
            }
            catch (Exception exc) {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosCliente.Enabled = false;
            listarCliente();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
            Restaurante restaurante = new Restaurante();
            restaurante.Show();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
            txtIDCliente.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCliente.Text = filaActual.Cells[1].Value.ToString();
            txtDNICliente.Text = filaActual.Cells[2].Value.ToString();
            txtNumeroCliente.Text = filaActual.Cells[3].Value.ToString();
            txtCorreoCliente.Text = filaActual.Cells[4].Value.ToString();
            dtpFechaCliente.Text = filaActual.Cells[5].Value.ToString();
            chbEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }

        private void btnDatosCliente_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Enabled = true;
            btnModificarCliente.Enabled = true;
            btnAgregarCliente.Enabled = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Enabled = true;
            btnAgregarCliente.Enabled = true;
            limpiarVariables();
            btnModificarCliente.Enabled = false;
        }
    }
}
