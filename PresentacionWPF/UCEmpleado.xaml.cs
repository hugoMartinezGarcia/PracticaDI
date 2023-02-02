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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentacionWPF
{
    /// <summary>
    /// Lógica de interacción para UCEmpleado.xaml
    /// </summary>
    public partial class UCEmpleado : UserControl
    {

        private Employee? empleado;
        private Employee? usuario;
        private Employee? nuevoEmpleado;
        private bool modoEditar;

        public UCEmpleado()
        {
            InitializeComponent();
            string[] titCortesia = new string[] { "Sin selección", "Ms.", "Dr.", "Mrs.", "Mr." };
            cbTitleOfCourtesy.DataContext = titCortesia;
            cbInformaA.DataContext = Gestion.ListarEmployee();
        }

        public UCEmpleado(bool modoEditar) : this()
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
                nuevoEmpleado = new Employee();
                this.DataContext = nuevoEmpleado;
            }
        }

        private void ModoEditar()
        {
            this.DataContext = empleado;
        }

        public void DefinirUsuario(Employee usuario)
        {
            this.usuario = usuario;
        }

        public void DefinirEmpleado(Employee empleado)
        {
            this.empleado = empleado;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid gridContenedor = (Grid) Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(new UCDashboard(usuario!));
        }
    }
}
