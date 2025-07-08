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
    public partial class Core : Form
    {
        public Core()
        {
            InitializeComponent();
        }

        private void btnFormOrdPedido_Click(object sender, EventArgs e)
        {
            OrdenPedido formOrdenPedido = new OrdenPedido();
            formOrdenPedido.Show();
        }
        private void btnCompVenta_Click(object sender, EventArgs e)
        {
            ComprobanteVenta formComprobanteVenta = new ComprobanteVenta();
            formComprobanteVenta.Show();
        }
        private void btnReqInsumos_Click(object sender, EventArgs e)
        {
            RequerimientoInsumos formReqInsumos = new RequerimientoInsumos();
            formReqInsumos.Show();
        }

        private void btnCompraReq_Click(object sender, EventArgs e)
        {
            CompraInsumos formCompraReq = new CompraInsumos();
            formCompraReq.Show();
        }
    }
}
