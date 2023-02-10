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
using System.Windows.Markup;
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
        private MainWindow mainWindow;
        private Employee usuario;
        private Order? pedido;
        private bool modoEditar;
        private List<OrderDetail> detallesPedido;
        private ResumenFactura resumenFactura;

        private Employee? empleado;
        private Customer? cliente;
        private List<Shipper> shippers;

        public UCPedidos()
        {
            InitializeComponent();

            cliente = null;
            empleado = null;
            pedido = null;
            resumenFactura = new ResumenFactura();
            detallesPedido = new List<OrderDetail>();
            shippers = new List<Shipper>();
        }

        public UCPedidos(MainWindow mainWindow, Employee usuario, bool modoEditar) : this()
        {
            this.mainWindow = mainWindow;
            this.usuario = usuario;
            this.modoEditar = modoEditar;

            lbProductos.DataContext = Gestion.ListarProductosConDatos();
            gridResumenFactura.DataContext = resumenFactura;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            tbOrderId.IsReadOnly = true;
            tbEmployee.IsReadOnly = true;
            lbOrderId.Visibility = Visibility.Hidden; 
            tbOrderId.Visibility = Visibility.Hidden;
            cbShipVia.ItemsSource = Gestion.ListarShipper();
            cbShipVia.DisplayMemberPath = "CompanyName";
            cbShipVia.SelectedValuePath = "ShipperId";
            empleado = usuario;

            
            ActualizarDataGridDetalles();

            if (modoEditar)
            {
                ModoEditar();
            }
        }

        private void ActualizarDataGridDetalles()
        {
            dgDetallesPedido.ItemsSource = detallesPedido;
            dgDetallesPedido.Columns.RemoveAt(0);
            dgDetallesPedido.Columns.RemoveAt(4);
            dgDetallesPedido.Columns[4].DisplayIndex = 1;
            // Las columnas de ProductId y ProductName se dejan en solo lectura
            dgDetallesPedido.Columns[0].IsReadOnly = true;
            dgDetallesPedido.Columns[4].IsReadOnly = true;
        }

        private void ModoEditar()
        {
            btGuardar.Content = "Modificar";

            // Se copia la lista del pedido recibido
            detallesPedido = pedido!.OrderDetails.ToList();

            ActualizarDataGridDetalles();
            ActualizarResumenFactura(detallesPedido);

            empleado = pedido!.Employee;
            cliente = pedido!.Customer;

            lbOrderId.Visibility = Visibility.Visible;
            tbOrderId.Visibility = Visibility.Visible;
            tbOrderId.Text = pedido!.OrderId.ToString();

            if (pedido.Employee != null)
                tbEmployee.Text = pedido.Employee.FirstName + " " + pedido.Employee.LastName;
            if (pedido.Customer != null)
                tbCustomer.Text = pedido.Customer.ContactName;

            dtpOrderDate.SelectedDate = pedido.OrderDate;
            dtpRequiredDate.SelectedDate = pedido.RequiredDate;
            dtpShippedDate.SelectedDate = pedido.ShippedDate;
           
            cbShipVia.SelectedValue = pedido.ShipVia;

            tbFreight.Text = pedido.Freight.ToString();
            tbShipName.Text = pedido.ShipName;
            tbShipAddress.Text = pedido.ShipAddress;
            tbShipCity.Text = pedido.ShipCity;
            tbShipRegion.Text = pedido.ShipRegion;
            tbShipPostalCode.Text = pedido.ShipPostalCode;
            tbShipCountry.Text = pedido.ShipCountry;
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
                {
                    detallesPedido.Add(od);

                    dgDetallesPedido.Items.Refresh();
                    ActualizarResumenFactura(detallesPedido);
                }
                    
                else
                    MessageBox.Show("Este producto ya está añadido al pedido");
            }
        }

        private void ActualizarResumenFactura(List<OrderDetail> orderDetails)
        {
            resumenFactura = Gestion.ResumenFactura(detallesPedido);
            gridResumenFactura.DataContext = resumenFactura;
        }

        private void dgDetallesPedido_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            string valor = ((TextBox)e.EditingElement).Text;

            // Comprueba si el valor es un número válido
            bool esNumero = int.TryParse(valor, out int resultado);
            if (!esNumero || resultado <= 0)
            {
                // Muestra un mensaje de error
                MessageBox.Show("El valor introducido no es un número válido.");

                // Cancela la edición de la celda
                e.Cancel = true;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Order nuevoPedido = new Order();

                nuevoPedido.CustomerId = cliente != null ? cliente.CustomerId : null;
                nuevoPedido.EmployeeId = empleado != null ? empleado.EmployeeId : null;
                nuevoPedido.OrderDate = dtpOrderDate.SelectedDate;
                nuevoPedido.RequiredDate = dtpRequiredDate.SelectedDate;
                nuevoPedido.ShippedDate = dtpShippedDate.SelectedDate;
                if (cbShipVia.SelectedIndex >= 0)
                {
                    nuevoPedido.ShipVia = ((Shipper)cbShipVia.SelectedItem).ShipperId;
                }
                    
                else
                    nuevoPedido.ShipVia = null;

                nuevoPedido.Freight = UtilesWPF.FormatearTBNullDecimal(tbFreight);
                nuevoPedido.ShipName = UtilesWPF.FormatearTBNullString(tbShipName);
                nuevoPedido.ShipAddress = UtilesWPF.FormatearTBNullString(tbShipAddress);
                nuevoPedido.ShipCity = UtilesWPF.FormatearTBNullString(tbShipCity);
                nuevoPedido.ShipRegion = UtilesWPF.FormatearTBNullString(tbShipRegion);
                nuevoPedido.ShipPostalCode = UtilesWPF.FormatearTBNullString(tbShipPostalCode);
                nuevoPedido.ShipCountry = UtilesWPF.FormatearTBNullString(tbShipCountry);

                if (modoEditar)
                {
                    // Se copia el id del order recibido en el form
                    nuevoPedido.OrderId = pedido!.OrderId;

                    using (Gestion g = new Gestion())
                    {
                        // Se actualiza el Order
                        g.ActualizarOrder(nuevoPedido);
                        // Se borran los orderDetails del antiguo order
                        pedido.OrderDetails.ToList().ForEach(oD => g.BorrarOrderDetail(oD));
                        // se guardan los nuevos orderDetails
                        detallesPedido.ForEach(od =>
                        {
                            od.OrderId = nuevoPedido.OrderId;
                            g.InsertarOrderDetail(od);
                        });
                    }

                    MessageBox.Show("El order y sus order details se han actualizado correctamente");

                    Retroceder();
                }
                // Si no está en modo actualizar se inserta el order y después sus order details
                else
                {
                    using (Gestion g = new Gestion())
                    {
                        g.InsertarOrder(nuevoPedido);

                        detallesPedido.ForEach(od =>
                        {
                            od.OrderId = nuevoPedido.OrderId;
                            g.InsertarOrderDetail(od);
                        });
                    }

                    MessageBox.Show("El order y sus order details se han guardado correctamente");

                    Retroceder();
                }
            }
            catch (Exception)
            {
                if (modoEditar)
                    MessageBox.Show("No se ha podido actualizar el order y sus order details");
                else
                    MessageBox.Show("No se ha podido insertar el order y sus order details");
            }
        }
        private void Retroceder()
        {
            Grid gridContenedor = (Grid)Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(new UCDashboard(usuario!, mainWindow));
        }

        private void btBorrarOrderDate_Click(object sender, RoutedEventArgs e)
        {
            dtpOrderDate.SelectedDate = null;
        }

        private void btBorrarRequiredDate_Click(object sender, RoutedEventArgs e)
        {
            dtpRequiredDate.SelectedDate = null;
        }

        private void btBorrarShippedDate_Click(object sender, RoutedEventArgs e)
        {
            dtpShippedDate.SelectedDate = null;
        }

        private void btBorrarShipVia_Click(object sender, RoutedEventArgs e)
        {
            cbShipVia.SelectedItem = null;
        }

        private void dgDetallesPedido_CurrentCellChanged(object sender, EventArgs e)
        {
            ActualizarResumenFactura(detallesPedido);
        }

        private void btBorrarDetalle_Click(object sender, RoutedEventArgs e)
        {
            OrderDetail? od = (OrderDetail)dgDetallesPedido.SelectedItem;

            if (od != null) 
            {
                detallesPedido.Remove(od);
                ActualizarResumenFactura(detallesPedido);
                dgDetallesPedido.Items.Refresh();
            }
        }

        private void btBorrarCustomer_Click(object sender, RoutedEventArgs e)
        {
            cliente = null;
            tbCustomer.Clear();
        }

        private void btSeleccionarCustomer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
