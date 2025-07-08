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
    public partial class MantenedorTipoPlatillo : Form
    {
        public MantenedorTipoPlatillo()
        {
            InitializeComponent();
            gbDatosTPlatillo.Enabled = false;
            listarTPlatillo();
        }
        public void listarTPlatillo()
        {
            dgvTPlatillo.DataSource = logTPlatillo.Instancia.ListarTPlatillo();
        }
        public void limpiarVariables()
        {
            txtIdTPlatillo.Text = "";
            txtNombreTPlatillo.Text = "";
        }

        private void btnAgregarTPlatillo_Click(object sender, EventArgs e)
        {
            try { 
                entTPlatillo tp = new entTPlatillo();
                tp.IdTipoPlatillo = int.Parse(txtIdTPlatillo.Text.Trim());
                tp.NombreTipo = txtNombreTPlatillo.Text.Trim();
                tp.EstadoTPlatillo = chbEstadoTPlatillo.Checked;
                logTPlatillo.Instancia.agregarTPLatillo(tp);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosTPlatillo.Enabled = false;
            listarTPlatillo();
        }

        private void btnModificarTPlatillo_Click(object sender, EventArgs e)
        {
            try {
                entTPlatillo tp = new entTPlatillo();
                tp.IdTipoPlatillo = int.Parse(txtIdTPlatillo.Text.Trim());
                tp.NombreTipo = txtNombreTPlatillo.Text.Trim();
                tp.EstadoTPlatillo = chbEstadoTPlatillo.Checked;
                logTPlatillo.Instancia.modificarTPLatillo(tp);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosTPlatillo.Enabled = false;
            listarTPlatillo();
        }

        private void btnInhabilitarTPlatillo_Click(object sender, EventArgs e)
        {
            try {
                entTPlatillo tp = new entTPlatillo();
                tp.IdTipoPlatillo = int.Parse(txtIdTPlatillo.Text.Trim());
                chbEstadoTPlatillo.Checked = false;
                logTPlatillo.Instancia.inhabilitarTPLatillo(tp);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosTPlatillo.Enabled = false;
            listarTPlatillo();
        }

        private void dgvTPlatillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTPlatillo.Rows[e.RowIndex];
            txtIdTPlatillo.Text = filaActual.Cells[0].Value.ToString();
            txtNombreTPlatillo.Text = filaActual.Cells[1].Value.ToString();
            chbEstadoTPlatillo.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnNuevoTipo_Click(object sender, EventArgs e)
        {
            gbDatosTPlatillo.Enabled = true;
            btnAgregarTPlatillo.Enabled = true;
            limpiarVariables();
            btnModificarTPlatillo.Enabled = false;
        }

        private void btnDatosTipo_Click(object sender, EventArgs e)
        {
            gbDatosTPlatillo.Enabled = true;
            btnModificarTPlatillo.Enabled = true;
            btnAgregarTPlatillo.Enabled = false;
        }
    }
}
