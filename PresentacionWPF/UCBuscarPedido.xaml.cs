using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
    /// Lógica de interacción para UCBuscarPedido.xaml
    /// </summary>
    public partial class UCBuscarPedido : UserControl
    {
        private ObservableCollection<Customer> clientes;
        private CollectionViewSource MiVista;
        private Employee usuario;
        private MainWindow mainWindow;
        private bool modoFactura;

        public UCBuscarPedido(Employee usuario, MainWindow mainWindow, bool modoFactura)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.mainWindow = mainWindow;
            this.modoFactura = modoFactura;
            MiVista = (CollectionViewSource)FindResource("Clientes");
            this.DataContext = MiVista;
            

            if (modoFactura)
            {
                using (Gestion g = new Gestion())
                {
                    clientes = new ObservableCollection<Customer>(g.ListarClientesConOrders());
                }

                btModificarPedido.Visibility = Visibility.Hidden;
                btNuevo.Content = "Mostrar factura";
            }
            else
            {
                using (Gestion g = new Gestion())
                {
                    clientes = new ObservableCollection<Customer>(g.ListarClientesConOrdersPendientes());
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MiVista.Source = clientes;
        }

        private void Filtrar(object sender, FilterEventArgs e)
        {
            Customer cliente = (Customer)e.Item;

            if (cliente != null)
            {
                string textoABuscar = tbBuscarCliente.Text.ToLower().Trim();
                string customerId = cliente.CustomerId.ToLower();
                string companyName = cliente.CompanyName.ToLower();
                string? contactName = cliente.ContactName != null ? cliente.ContactName.ToLower() : null;

                if (customerId.Contains(textoABuscar)
                    || companyName.Contains(textoABuscar)
                    || (contactName != null && contactName.Contains(textoABuscar)))
                {
                    e.Accepted = true;
                }
                else
                    e.Accepted = false;
            }
        }

        private void btNuevo_Click(object sender, RoutedEventArgs e)
        {
            if (modoFactura)
            {

                if (dgPedidos.SelectedItem != null)
                {
                    Order pedido = new Order();
                    using (Gestion g = new Gestion())
                    {
                        pedido = g.DatosPedido(((Order)dgPedidos.SelectedItem).OrderId);
                    }
                    UCFactura factura = new UCFactura(mainWindow, usuario, pedido);
                    Grid gridContenedor = (Grid)Parent;
                    gridContenedor.Children.Clear();
                    gridContenedor.Children.Add(factura);
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un pedido de la lista!");
                }    
            }
            else
            {
                UCPedidos insertarPedido = new UCPedidos(mainWindow, usuario, false);
                Grid gridContenedor = (Grid)Parent;
                gridContenedor.Children.Clear();
                gridContenedor.Children.Add(insertarPedido);
            }
        }


        private void btModificarPedido_Click(object sender, RoutedEventArgs e)
        {         
            if (dgPedidos.SelectedItem != null)
            {
                UCPedidos editarPedido = new UCPedidos(mainWindow, usuario, true);

                using (Gestion g = new Gestion())
                {
                    editarPedido.DefinirPedido(g.DatosPedido(((Order)dgPedidos.SelectedItem).OrderId));
                }
                
                Grid gridContenedor = (Grid)Parent;
                gridContenedor.Children.Clear();
                gridContenedor.Children.Add(editarPedido);
            }
            else
            {
                MessageBox.Show("Debes seleccionar un pedido de la lista!");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MiVista.Filter += Filtrar;
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            Grid gridContenedor = (Grid)Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(new UCDashboard(usuario, mainWindow));
        }
    }
}
