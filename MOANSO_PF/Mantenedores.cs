using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOANSO_PF
{
    public partial class Mantenedores : Form
    {
        public Mantenedores()
        {
            InitializeComponent();
        }

        private void btnFormCliente_Click(object sender, EventArgs e)
        {
            MantenedorCliente formCliente = new MantenedorCliente();
            formCliente.Show();
        }

        private void btnFormPlatillo_Click(object sender, EventArgs e)
        {
            MantenedorPlatillo formPlatillo = new MantenedorPlatillo();
            formPlatillo.Show();
        }

        private void btnTPlatillo_Click(object sender, EventArgs e)
        {
            MantenedorTipoPlatillo formTipoPlatillo = new MantenedorTipoPlatillo();
            formTipoPlatillo.Show();
        }

        private void btnFormMesero_Click(object sender, EventArgs e)
        {
            MantenedorMesero formMesero = new MantenedorMesero();
            formMesero.Show();
        }

        private void btnTBebida_Click(object sender, EventArgs e)
        {
            TipoBebida formTBebida = new TipoBebida();
            formTBebida.Show();
        }

        private void btnFormBebidas_Click(object sender, EventArgs e)
        {
            MantenedorBebida formBebidas = new MantenedorBebida();
            formBebidas.Show();
        }

        private void btnFormInsumos_Click(object sender, EventArgs e)
        {
            MantenedorInsumos formInsumos = new MantenedorInsumos();
            formInsumos.Show();
        }

        private void btnFormProveedor_Click(object sender, EventArgs e)
        {
            MantenedorProveedor formProveedor = new MantenedorProveedor();
            formProveedor.Show();
        }

        private void btnEnAlmacen_Click(object sender, EventArgs e)
        {
            MantenedorEncargardoAlmacen formEnAlmacen = new MantenedorEncargardoAlmacen();
            formEnAlmacen.Show();
        }
    }
}
