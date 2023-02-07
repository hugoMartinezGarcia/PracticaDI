using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentacionWPF
{
    /// <summary>
    /// Lógica de interacción para UCPedidos.xaml
    /// </summary>
    public partial class UCPedidos : UserControl
    {
        private Employee? usuario;
        private Order? pedido;
        private Order? nuevoPedido;
        private bool modoEditar;
        private List<OrderDetail> detallesPedido;
        private ResumenFactura resumenFactura;

        public UCPedidos()
        {
            InitializeComponent();

            resumenFactura = new ResumenFactura();
            detallesPedido = new List<OrderDetail>();

            lbProductos.DataContext = Gestion.ListarProductosConDatos();
            gridResumenFactura.DataContext = resumenFactura;
            //dgDetallesPedido.DataContext = detallesPedido;
        }

        public UCPedidos(bool modoEditar) : this()
        {
            this.modoEditar = modoEditar;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (modoEditar)
            {
                ModoEditar();
            }
            else
            {
                nuevoPedido = new Order();
                this.DataContext = nuevoPedido;
            }
        }

        private void ModoEditar()
        {
            this.DataContext = pedido;
        }

        public void DefinirUsuario(Employee usuario)
        {
            this.usuario = usuario;
        }

        public void DefinirPedido(Order pedido)
        {
            this.pedido = pedido;
        }

        // Método para manejar cuando se hace doble click en la lista de productos
        protected void HandleDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Product producto = (Product)((ListViewItem)sender).Content;

            if (producto != null)
            {
                OrderDetail od = new OrderDetail();
                // Se asigna el product seleccionado, su productId y su unitPrice al OrderDetail
                od.Product = producto;
                od.ProductId = producto.ProductId;
                od.UnitPrice = producto.UnitPrice != null ? (decimal)producto.UnitPrice : 1;

                // Si el product no está ya en la lista, se añade
                if (!detallesPedido.Any(oD => oD.ProductId == od.ProductId))
                    detallesPedido.Add(od);
                else
                    MessageBox.Show("Este producto ya está añadido al pedido");
            }

            dgDetallesPedido.ItemsSource = detallesPedido;
            ActualizarResumenFactura(detallesPedido);

        }

        private void ActualizarResumenFactura(List<OrderDetail> orderDetails)
        {
            resumenFactura = Gestion.ResumenFactura(detallesPedido);
            gridResumenFactura.DataContext = resumenFactura;
        }

        private void dgDetallesPedido_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            dgDetallesPedido.DataContext = detallesPedido;
            ActualizarResumenFactura(detallesPedido);
        }
    }
}
