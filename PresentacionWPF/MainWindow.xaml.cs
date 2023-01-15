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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee? empleado;
        public MainWindow()
        {
            InitializeComponent();
            empleado = null;
            LoginWindow lw = new LoginWindow(this);
            lw.Show();
            this.Hide();
        }

        public void DefinirEmpleado(Employee empleado)
        {
            this.empleado = empleado;
        }
    }
}
