using Entidades;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentacionWPF
{
    /// <summary>
    /// Lógica de interacción para UCTemporizador.xaml
    /// </summary>
    public partial class UCTemporizador : UserControl
    {
        private Employee usuario;
        private MainWindow mainWindow;
        public UCTemporizador(Employee usuario, MainWindow mainWindow)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.mainWindow = mainWindow;
            slTiempo.Value = mainWindow.TiempoActualizacion;
        }

        private void btAceptar_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.TiempoActualizacion = (int)slTiempo.Value;
            UCDashboard dashboard = new UCDashboard(usuario, mainWindow);

            Grid gridContenedor = (Grid)Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(dashboard);
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            Grid gridContenedor = (Grid)Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(new UCDashboard(usuario, mainWindow));
        }

       
    }
}
