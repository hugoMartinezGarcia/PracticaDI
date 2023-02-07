using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Employee? usuario;

        public int TiempoActualizacion { get; set; } = 5;
        public MainWindow()
        {
            InitializeComponent();
 
            usuario = null;
            LoginWindow lw = new LoginWindow(this);
            lw.Show();
            this.Hide();
        }

        public void DefinirUsuarioYHora(Employee usuario)
        {
            this.usuario = usuario;
            gridPrincipal.DataContext = usuario;
            lbHoraAcceso.DataContext = DateTime.Now.ToShortTimeString();
            
            gridCentral.Children.Clear();
            gridCentral.Children.Add(new UCDashboard(usuario!, this));
        }

        private void btDashboard_Click(object sender, RoutedEventArgs e)
        {
            if (btDashboard.IsChecked == true)
            {
                gridCentral.Children.Clear();
                gridCentral.Children.Add(new UCDashboard(usuario!, this));
            }
        }

        private void btEmpleado_Click(object sender, RoutedEventArgs e)
        {
            gridCentral.Children.Clear();
            gridCentral.Children.Add(new UCBuscarEmpleado(usuario!, this));
        }

        private void btProductos_Click(object sender, RoutedEventArgs e)
        {
            gridCentral.Children.Clear();
            gridCentral.Children.Add(new UCProductos(usuario!, this));
        }

        private void btPedidos_Click(object sender, RoutedEventArgs e)
        {
            gridCentral.Children.Clear();
            gridCentral.Children.Add(new UCBuscarPedido(usuario!, this, false));
        }

        private void btInformes_Click(object sender, RoutedEventArgs e)
        {
            gridCentral.Children.Clear();
            gridCentral.Children.Add(new UCBuscarPedido(usuario!, this, true));
        }

        private void btTemporizador_Click(object sender, RoutedEventArgs e)
        {
            gridCentral.Children.Clear();
            gridCentral.Children.Add(new UCTemporizador(usuario!, this));
        }

        /*
        private void btEmpleado_Click(object sender, RoutedEventArgs e)
        {
            if (((ToggleButton)sender).IsChecked == false)
            {
                ((ToggleButton)sender).IsChecked = true;
            }
            else
            {
                foreach (Control control in stckPanelLateral.Children)
                {
                    if (control is ToggleButton)
                    {
                        ToggleButton tb = (ToggleButton)control;

                        if (tb.IsChecked == true && tb != sender)
                        {
                            tb.IsChecked = false;
                        }
                    }
                }

                gridCentral.Children.Clear();
                gridCentral.Children.Add(new UCBuscarEmpleado());
            }
        }
        */
    }
}
