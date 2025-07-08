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
    public partial class MantenedorBebida : Form
    {
        public MantenedorBebida()
        {
            InitializeComponent();
            gbBebida.Enabled = true;
            listarBebida();
            llenarDatosCB();
        }
        public void listarBebida()
        {
            dgvBebida.DataSource = logBebida.Instancia.ListarBebida();
        }
        public void limpiarVariables()
        {
            txtIdBebida.Text = "";
            txtNombreBebida.Text = "";
            txtPrecioBebida.Text = "";
        }
        public void llenarDatosCB()
        {
            cbTBebida.DataSource = logTipoBebida.Instancia.ListarTBebida();
            cbTBebida.DisplayMember = "NombreTipo";
            cbTBebida.ValueMember = "IdTipoBebida";
        }
        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            try
            {
                entBebida eb = new entBebida();
                eb.IdBebida = int.Parse(txtIdBebida.Text.Trim());
                eb.NombreBebida = txtNombreBebida.Text.Trim();
                eb.Precio = decimal.Parse(txtPrecioBebida.Text.Trim());
                eb.Tamaño = txtTamBebida.Text.Trim();
                eb.EstadoBebida = chbEstadoBebida.Checked;
                eb.TipoBebida = Convert.ToInt32(cbTBebida.SelectedValue);
                logBebida.Instancia.agregarBebida(eb);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbBebida.Enabled = false;
            listarBebida();
        }

        private void btnModificarBebida_Click(object sender, EventArgs e)
        {
            try
            {
                entBebida eb = new entBebida();
                eb.IdBebida = int.Parse(txtIdBebida.Text.Trim());
                eb.NombreBebida = txtNombreBebida.Text.Trim();
                eb.Precio = decimal.Parse(txtPrecioBebida.Text.Trim());
                eb.Tamaño = txtTamBebida.Text.Trim();
                eb.EstadoBebida = chbEstadoBebida.Checked;
                logBebida.Instancia.modificarBebida(eb);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbBebida.Enabled = false;
            listarBebida();
        }

        private void btnInhabilitarBebida_Click(object sender, EventArgs e)
        {
            try
            {
                entBebida eb = new entBebida();
                eb.IdBebida = int.Parse(txtIdBebida.Text.Trim());
                chbEstadoBebida.Checked = false;
                logBebida.Instancia.inhabilitarBebida(eb);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbBebida.Enabled = false;
            listarBebida();
        }

        private void dgvBebida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvBebida.Rows[e.RowIndex];
            txtIdBebida.Text = filaActual.Cells[0].Value.ToString();
            txtNombreBebida.Text = filaActual.Cells[1].Value.ToString();
            txtPrecioBebida.Text = filaActual.Cells[2].Value.ToString();
            txtTamBebida.Text = filaActual.Cells[3].Value.ToString();
            chbEstadoBebida.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbBebida.Enabled = true;
            btnModificarBebida.Enabled = true;
            limpiarVariables();
            btnAgregarBebida.Enabled = true;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            gbBebida.Enabled = true;
            btnModificarBebida.Enabled = true;
            btnAgregarBebida.Enabled = false;
        }
    }
}
