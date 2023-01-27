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
    /// Lógica de interacción para UCBuscarEmpleado.xaml
    /// </summary>
    public partial class UCBuscarEmpleado : UserControl
    {
        public UCBuscarEmpleado()
        {
            InitializeComponent();
            List<Employee> empleados = Gestion.ListarEmployee();
            listbEmpleados.ItemsSource = empleados;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grid gridContenedor = (Grid)Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(new UCEmpleado());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Employee empleado = (Employee)listbEmpleados.SelectedItem;

            if (empleado != null)
            {
                MessageBoxResult respuesta = MessageBox.Show(
                    String.Format("¿Confirma que desea eliminar el empleado {0}- {1} {2}?",
                        empleado.EmployeeId, empleado.FirstName, empleado.LastName),
                    "Eliminar empleado",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Exclamation);

                if (respuesta == MessageBoxResult.Yes)
                {
                    try
                    {
                        using (Gestion g = new Gestion())
                        {
                            g.BorrarEmployee(empleado);
                        }

                        MessageBox.Show(String.Format("El empleado {0}- {1} {2} se ha eliminado correctamente",
                            empleado.EmployeeId, empleado.FirstName, empleado.LastName));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se ha podido eliminar el empleado");
                    }
                }
            }
        }
    }
}
