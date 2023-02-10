using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PresentacionWPF
{
    /// <summary>
    /// Lógica de interacción para WSelClientes.xaml
    /// </summary>
    public partial class WSelClientes : Window
    {
        UCPedidos uCPedidos;
        public WSelClientes(UCPedidos uCPedidos)
        {
            this.uCPedidos = uCPedidos;
            InitializeComponent();
            dgClientes.DataContext = Gestion.ListarCustomer();
        }

        private void btAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (dgClientes.SelectedItem != null)
            {
                uCPedidos.DefinirCliente((Customer)dgClientes.SelectedItem);
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
            }
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
