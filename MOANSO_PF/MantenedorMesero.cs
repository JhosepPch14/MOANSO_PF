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
    public partial class MantenedorMesero : Form
    {
        public MantenedorMesero()
        {
            InitializeComponent();
            //gbDatosMesero.Enabled = false;
            listarMesero();
        }
        public void listarMesero() { 
            dgvMesero.DataSource = logMesero.Instancia.ListarMesero();
        }
        public void limpiarVariables() {
            txtIdMesero.Text = "";
            txtNombreMesero.Text = "";
            txtDNIMesero.Text = "";
            txtTelefono.Text = "";
        }
        private void btnAgregarMesero_Click(object sender, EventArgs e)
        {
            try { 
                entMesero m = new entMesero();
                m.IdMesero = int.Parse(txtIdMesero.Text.Trim());
                m.NombreMesero = txtNombreMesero.Text.Trim();
                m.DNIMesero = int.Parse(txtDNIMesero.Text.Trim());
                m.Telefono = int.Parse(txtTelefono.Text.Trim());
                m.FechaIngreso = dtpFechaIngreso.Value;
                m.EstadoMesero = chbEstadoMesero.Checked;
                logMesero.Instancia.agregarMesero(m);
            }
            catch (Exception exc) { MessageBox.Show("Error..." + exc); }
            limpiarVariables();
            gbDatosMesero.Enabled = false;
            listarMesero();
        }

        private void btnModificarMesero_Click(object sender, EventArgs e)
        {
            try {
                entMesero m = new entMesero();
                m.IdMesero = int.Parse(txtIdMesero.Text.Trim());
                m.NombreMesero = txtNombreMesero.Text.Trim();
                m.DNIMesero = int.Parse(txtDNIMesero.Text.Trim());
                m.Telefono = int.Parse(txtTelefono.Text.Trim());
                m.FechaIngreso = dtpFechaIngreso.Value;
                m.EstadoMesero = chbEstadoMesero.Checked;
                logMesero.Instancia.modificarMesero(m);
            }
            catch (Exception exc) { MessageBox.Show("Error..." + exc); }
            limpiarVariables();
            //gbDatosMesero.Enabled = false;
            listarMesero();
        }

        private void btnInhabilitarMesero_Click(object sender, EventArgs e)
        {
            try {
                entMesero m = new entMesero();
                m.IdMesero = int.Parse(txtIdMesero.Text.Trim());
                chbEstadoMesero.Checked = false;
                logMesero.Instancia.inhabilitarMesero(m);
            }
            catch (Exception exc) { MessageBox.Show("Error..." + exc); }
            limpiarVariables();
            gbDatosMesero.Enabled = false;
            listarMesero();
        }

        private void dgvPlatillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
