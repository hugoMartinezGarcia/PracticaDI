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

        public UCBuscarPedido(Employee usuario, MainWindow mainWindow)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.mainWindow = mainWindow;
            MiVista = (CollectionViewSource)FindResource("Clientes");
            this.DataContext = MiVista;
            
            using (Gestion g = new Gestion())
            {
                clientes = new ObservableCollection<Customer>(g.ListarClientesConOrdersPendientes());
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

        private void btInsertarPedido_Click(object sender, RoutedEventArgs e)
        {
            /*
            UCEmpleado insertarEmpleado = new UCEmpleado(false);
            insertarEmpleado.DefinirUsuario(usuario);
            Grid gridContenedor = (Grid)Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(insertarEmpleado);
            */
        }


        private void btModificarPedido_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (listvClientes.SelectedItem != null)
            {
                UCEmpleado editarEmpleado = new UCEmpleado(true);
                editarEmpleado.DefinirUsuario(usuario);
                editarEmpleado.DefinirEmpleado((Employee)listvClientes.SelectedItem);
                Grid gridContenedor = (Grid)Parent;
                gridContenedor.Children.Clear();
                gridContenedor.Children.Add(editarEmpleado);
            }
            */

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
