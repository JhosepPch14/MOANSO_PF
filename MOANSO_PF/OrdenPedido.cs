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
    public partial class OrdenPedido : Form
    {
        public OrdenPedido()
        {
            InitializeComponent();
            listarOrdenPedido();
            llenarDatosCB();
        }
        private List<entDetallePedido> listaDetalles = new List<entDetallePedido>();

        public void listarOrdenPedido()
        {
            dgvOrden.DataSource = logOrdenPedido.Instancia.ListarOrdenes();
        }
        public void listarDetallePedido(int pedidoID)
        {
            dgvDetalles.DataSource = logDetallePedido.Instancia.ListarDetalles(pedidoID);
        }
        public void limpiarVariables()
        {
            txtNroMesa.Text = "";
        }
        public void llenarDatosCB()
        {
            cbTPlatillo.DataSource = logTPlatillo.Instancia.ListarTPlatillo();
            cbTPlatillo.DisplayMember = "NombreTipo";
            cbTPlatillo.ValueMember = "IdTipoPlatillo";

            cbPlatilloPedido.DataSource = logPlatillo.Instancia.ListarPlatillo();
            cbPlatilloPedido.DisplayMember = "NombrePlatillo";
            cbPlatilloPedido.ValueMember = "IdPlatillo";

            //cbBebidas.DataSource = logTipoBebida.Instancia.ListarTBebida();
            //cbBebidas.DisplayMember = "NombreTipo";
            //cbBebidas.ValueMember = "IdTipoBebida";

            cbMeseros.DataSource = logMesero.Instancia.ListarMesero();
            cbMeseros.DisplayMember = "NombreMesero";
            cbMeseros.ValueMember = "IdMesero";
        }
        private decimal obtenerPrecioPlatillo() {
            if (cbPlatilloPedido.SelectedItem is entPlatillo platillo)
            {
                return platillo.PrecioPlatillo;
            }
            return 0;
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            try { 
                entOrdenPedido op = new entOrdenPedido();
                op.PedidoID = int.Parse(txtIdPedido.Text.Trim());
                op.Fecha = dtpFechaOrden.Value;
                op.NroMesa = int.Parse(txtNroMesa.Text.Trim());
                op.Total = 0;
                op.EstadoPedido = chbEstadoOrden.Checked;
                op.MeseroID = Convert.ToInt32(cbMeseros.SelectedValue);
                logOrdenPedido.Instancia.agregarOrden(op);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            //gbDatosOrdenPedido.Enabled = false;
            listarOrdenPedido();
        }

        private void btnGuardarDetalles_Click(object sender, EventArgs e)
        {
            try {
                int platilloID = Convert.ToInt32(cbPlatilloPedido.SelectedValue);
                string nombre = cbPlatilloPedido.Text;
                int cantidad = int.Parse(nudCantidadPlatillo.Text);
                decimal precio = obtenerPrecioPlatillo();
                decimal subtotal = cantidad * precio;

                entDetallePedido dp = new entDetallePedido
                {
                    PlatilloID = platilloID,
                    NombrePlatillo = nombre,
                    Cantidad = cantidad,
                    Precio = precio,
                    Subtotal = subtotal
                };

                listaDetalles.Add(dp);

                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = listaDetalles;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            gbDatosOrdenPedido.Enabled = false;
            
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int pedidoID = int.Parse(txtIdPedido.Text);
            List<entDetallePedido> lista = new List<entDetallePedido>();

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["PlatilloID"].Value != null)
                {
                    entDetallePedido dp = new entDetallePedido
                    {
                        PedidoID = pedidoID,
                        PlatilloID = Convert.ToInt32(row.Cells["PlatilloID"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        Subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value)
                    };
                    lista.Add(dp);
                }
            }

            if (logDetallePedido.Instancia.registrarDetallePedido(lista, pedidoID))
            {
                MessageBox.Show("Venta registrada correctamente.");

                decimal total = logDetallePedido.Instancia.CalcularTotalPorPedido(pedidoID);
                logOrdenPedido.Instancia.actualizarTotal(pedidoID, total);

                listarDetallePedido(pedidoID);
                listarOrdenPedido();
            }
        }
        private int detalleSeleccionado = -1;
        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            try {
                var detalle = listaDetalles[detalleSeleccionado];

                detalle.PlatilloID = Convert.ToInt32(cbPlatilloPedido.SelectedValue);
                detalle.NombrePlatillo = cbPlatilloPedido.Text;
                detalle.Cantidad = Convert.ToInt32(nudCantidadPlatillo.Value);
                detalle.Precio = obtenerPrecioPlatillo();
                detalle.Subtotal = detalle.Cantidad * detalle.Precio;

                // Volver a mostrar la lista actualizada
                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = listaDetalles;
                //limpiar indice seleccionado
                detalleSeleccionado = -1;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
        }

        private void dgvOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvOrden.Rows[e.RowIndex];
            txtIdPedido.Text = filaActual.Cells[0].Value.ToString();
            dtpFechaOrden.Text = filaActual.Cells[1].Value.ToString();
            txtNroMesa.Text = filaActual.Cells[2].Value.ToString();
            chbEstadoOrden.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
            cbMeseros.Text = filaActual.Cells[5].Value.ToString();

            int pedidoID = Convert.ToInt32(filaActual.Cells[0].Value);
            dgvDetalles.DataSource = logDetallePedido.Instancia.ListarDetalles(pedidoID);
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDetalles.Rows[e.RowIndex];
            cbPlatilloPedido.Text = fila.Cells["NombrePlatillo"].Value.ToString();
            nudCantidadPlatillo.Value = Convert.ToInt32(fila.Cells["Cantidad"].Value);

            detalleSeleccionado = e.RowIndex;
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (detalleSeleccionado >= 0 && detalleSeleccionado < listaDetalles.Count)
            {
                var confirmar = MessageBox.Show("¿Desea eliminar este platillo del pedido?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    listaDetalles.RemoveAt(detalleSeleccionado);

                    // Actualizar el DataGridView
                    dgvDetalles.DataSource = null;
                    dgvDetalles.DataSource = listaDetalles;

                    // Limpiar selección
                    detalleSeleccionado = -1;
                    dgvDetalles.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un platillo del pedido antes de eliminar.");
            }
        }

        private void cbTPlatillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cbTPlatillo.SelectedValue is int tipoID)
            {
                // Obtener todos los platillos
                var platillos = logPlatillo.Instancia.ListarPlatillo();

                // Filtrar por tipo
                var platillosFiltrados = platillos
                    .Where(p => p.IdTipoPlatillo == tipoID)
                    .ToList();

                // Asignar al ComboBox
                cbPlatilloPedido.DataSource = platillosFiltrados;
                cbPlatilloPedido.DisplayMember = "NombrePlatillo";
                cbPlatilloPedido.ValueMember = "PlatilloID";
            }
            */
        }

        private void btnDeshOrden_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenPedido op = new entOrdenPedido();
                op.PedidoID = int.Parse(txtIdPedido.Text.Trim());
                chbEstadoOrden.Checked = false;
                logOrdenPedido.Instancia.inhabilitarOrden(op);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error..." + exc);
            }
            limpiarVariables();
            //gbDatosCliente.Enabled = false;
            listarOrdenPedido();

        }

        private void OrdenPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
