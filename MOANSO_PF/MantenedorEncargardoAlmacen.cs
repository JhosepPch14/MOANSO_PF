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
    public partial class MantenedorEncargardoAlmacen : Form
    {
        public MantenedorEncargardoAlmacen()
        {
            InitializeComponent();
            gbDatos.Enabled = false;    
            listarEnAlmacen();
        }
        public void listarEnAlmacen()
        {
            dgvEnAlmacen.DataSource = logEnAlmacen.Instancia.ListarEnAlmacen();
        }
        public void limpiarVariables()
        {
            txtIDEnAlmacen.Text = "";
            txtDNIEnAlmacen.Text = "";
            txtNombreEnAlmacen.Text = "";
            txtNumeroEnAlmacen.Text = "";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entEnAlmacen ea = new entEnAlmacen();
                ea.IDEnAlmacen = int.Parse(txtIDEnAlmacen.Text.Trim());
                ea.Nombre= txtNombreEnAlmacen.Text.Trim();
                ea.DNI = txtDNIEnAlmacen.Text.Trim();
                ea.Numero = txtNumeroEnAlmacen.Text.Trim();
                ea.FechaIngreso = dtpFechaRegistro.Value;
                ea.Estado = chbEstadoEnAlmacen.Checked;
                logEnAlmacen.Instancia.agregarEnAlmacen(ea);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarEnAlmacen();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEnAlmacen ea = new entEnAlmacen();
                ea.IDEnAlmacen = int.Parse(txtIDEnAlmacen.Text.Trim());
                ea.Nombre = txtNombreEnAlmacen.Text.Trim();
                ea.DNI = txtDNIEnAlmacen.Text.Trim();
                ea.Numero = txtNumeroEnAlmacen.Text.Trim();
                ea.FechaIngreso = dtpFechaRegistro.Value;
                ea.Estado = chbEstadoEnAlmacen.Checked;
                logEnAlmacen.Instancia.agregarEnAlmacen(ea);
                logEnAlmacen.Instancia.modificarEnAlmacen(ea);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarEnAlmacen();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entEnAlmacen ea = new entEnAlmacen();
                ea.IDEnAlmacen = int.Parse(txtIDEnAlmacen.Text.Trim());
                chbEstadoEnAlmacen.Checked = false;
                logEnAlmacen.Instancia.deshabilitarEnAlmacen(ea);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatos.Enabled = false;
            listarEnAlmacen();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregar.Enabled = true;
            limpiarVariables();
            btnModificar.Enabled = false;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void dgvEnAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEnAlmacen.Rows[e.RowIndex];
            txtIDEnAlmacen.Text = filaActual.Cells[0].Value.ToString();
            txtNombreEnAlmacen.Text = filaActual.Cells[1].Value.ToString();
            txtDNIEnAlmacen.Text = filaActual.Cells[2].Value.ToString();
            txtNumeroEnAlmacen.Text = filaActual.Cells[3].Value.ToString();
            dtpFechaRegistro.Text = filaActual.Cells[4].Value.ToString();
            chbEstadoEnAlmacen.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }
    }
}
