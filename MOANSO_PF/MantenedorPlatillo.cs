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
    public partial class MantenedorPlatillo : Form
    {
        public MantenedorPlatillo()
        {
            InitializeComponent();
            gbDatosPlatillo.Enabled = false;
            listarPlatillo();
            llenarDatosCBTPlatillo();
        }
        public void listarPlatillo() { 
            dgvPlatillo.DataSource = logPlatillo.Instancia.ListarPlatillo();
        }
        public void limpiarVariables(){
            txtIdPlatillo.Text = "";
            txtNombrePlatillo.Text = "";
            txtPrecioPlatillo.Text = "";
        }
        public void llenarDatosCBTPlatillo()
        {
            cbTPlatillo.DataSource = logTPlatillo.Instancia.ListarTPlatillo();
            cbTPlatillo.DisplayMember = "NombreTipo";
            cbTPlatillo.ValueMember = "IdTipoPlatillo";
        }
        private void btnAgregarPlatillo_Click(object sender, EventArgs e)
        {
            try
            {
                entPlatillo pl = new entPlatillo();
                pl.IdPlatillo = int.Parse(txtIdPlatillo.Text.Trim());
                pl.NombrePlatillo = txtNombrePlatillo.Text.Trim();
                pl.PrecioPlatillo = decimal.Parse(txtPrecioPlatillo.Text.Trim());
                pl.EstadoPlatillo = chbEstadoPlatillo.Checked;
                pl.IdTipoPlatillo = Convert.ToInt32(cbTPlatillo.SelectedValue);
                logPlatillo.Instancia.InsertarPlatillo(pl);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosPlatillo.Enabled = false;
            listarPlatillo();
        }

        private void btnModificarPlatillo_Click(object sender, EventArgs e)
        {
            try
            {
                entPlatillo pl = new entPlatillo();
                pl.IdPlatillo = int.Parse(txtIdPlatillo.Text.Trim());
                pl.NombrePlatillo = txtNombrePlatillo.Text.Trim();
                pl.PrecioPlatillo = decimal.Parse(txtPrecioPlatillo.Text.Trim());
                pl.EstadoPlatillo = chbEstadoPlatillo.Checked;
                logPlatillo.Instancia.ModificarPlatillo(pl);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosPlatillo.Enabled = false;
            listarPlatillo();
        }

        private void btnInhabilitarPlatillo_Click(object sender, EventArgs e)
        {
            try
            {
                entPlatillo pl = new entPlatillo();
                pl.IdPlatillo = int.Parse(txtIdPlatillo.Text.Trim());
                chbEstadoPlatillo.Checked = false;
                logPlatillo.Instancia.InsertarPlatillo(pl);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosPlatillo.Enabled = false;
            listarPlatillo();
        }

        private void dgvPlatillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPlatillo.Rows[e.RowIndex];
            txtIdPlatillo.Text = filaActual.Cells[0].Value.ToString();
            txtNombrePlatillo.Text = filaActual.Cells[1].Value.ToString();
            txtPrecioPlatillo.Text = filaActual.Cells[2].Value.ToString();
            chbEstadoPlatillo.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }

        private void btnNuevoPlatillo_Click(object sender, EventArgs e)
        {
            gbDatosPlatillo.Enabled = true;
            btnModificarPlatillo.Enabled = false;
            btnAgregarPlatillo.Enabled = true;
        }

        private void btnDatosPlatillo_Click(object sender, EventArgs e)
        {
            gbDatosPlatillo.Enabled = true;
            btnAgregarPlatillo.Enabled = false;
            limpiarVariables();
            btnModificarPlatillo.Enabled = true;
        }
    }
}
