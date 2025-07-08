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
    public partial class TipoBebida : Form
    {
        public TipoBebida()
        {
            InitializeComponent();
            gbDatosTBebida.Enabled = false;
            listarTBebida();
        }
        public void listarTBebida() { 
            dgvTipoBebidas.DataSource = logTipoBebida.Instancia.ListarTBebida();
        }
        public void limpiarVariables() {
            txtIdTipo.Text = "";
            txtNombreTBebida.Text = "";
        }
        private void btnAgregarTBebida_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoBebida tb = new entTipoBebida
                {
                    IdTipoBebida = int.Parse(txtIdTipo.Text.Trim()),
                    NombreTipo = txtNombreTBebida.Text.Trim(),
                    Estado = chbEstadoTBebida.Checked
                };
                logTipoBebida.Instancia.InsertarTBebida(tb);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosTBebida.Enabled = false;
            listarTBebida();
        }

        private void btnModificarTBebida_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoBebida tb = new entTipoBebida
                {
                    IdTipoBebida = int.Parse(txtIdTipo.Text.Trim()),
                    NombreTipo = txtNombreTBebida.Text.Trim(),
                    Estado = chbEstadoTBebida.Checked
                };
                logTipoBebida.Instancia.ModificarTBebida(tb);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosTBebida.Enabled = false;
            listarTBebida();
        }

        private void btnInhabilitarTBebida_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoBebida tb = new entTipoBebida
                {
                    IdTipoBebida = int.Parse(txtIdTipo.Text.Trim()),
                };
                chbEstadoTBebida.Checked = false;
                logTipoBebida.Instancia.InhabilitarTBebida(tb);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosTBebida.Enabled = false;
            listarTBebida();
        }

        private void dgvTipoBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvTipoBebidas.Rows[e.RowIndex];
            txtIdTipo.Text = fila.Cells[0].Value.ToString();
            txtNombreTBebida.Text = fila.Cells[1].Value.ToString();
            chbEstadoTBebida.Checked = Convert.ToBoolean(fila.Cells[2].Value);
        }

        private void btnNuevoTipo_Click(object sender, EventArgs e)
        {
            gbDatosTBebida.Enabled = true;
            btnAgregarTBebida.Enabled = true;
            limpiarVariables();
            btnModificarTBebida.Enabled = false;
        }

        private void btnDatosTipo_Click(object sender, EventArgs e)
        {
            gbDatosTBebida.Enabled = true;
            btnModificarTBebida.Enabled = true;
            btnAgregarTBebida.Enabled = false;
        }
    }
}
