using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentacionWPF
{
    /// <summary>
    /// Lógica de interacción para UCBuscarEmpleado.xaml
    /// </summary>
    public partial class UCBuscarEmpleado : UserControl
    {
        private ObservableCollection<Employee> empleados;
        private CollectionViewSource MiVista;
        private Employee usuario;
        private MainWindow mainWindow;

        public UCBuscarEmpleado(Employee usuario, MainWindow mainWindow)
        {
            this.usuario = usuario;
            this.mainWindow = mainWindow;
            InitializeComponent();
            // Se le asigna el DataContext al UserControl para que no haga Binding
            // hacia el empleado cargado en el gridPrincipal
            this.DataContext = empleados;
            MiVista = (CollectionViewSource)FindResource("Empleados");
            empleados = new ObservableCollection<Employee>(Gestion.ListarEmployee());
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MiVista.Source = empleados;
        }
        
        private void Filtrar(object sender, FilterEventArgs e)
        {
            Employee empleado = (Employee)e.Item;

            if (empleado != null)
            {
                string textoABuscar = tbBuscarEmpleado.Text.ToLower().Trim();
                string firstName = empleado.FirstName.ToLower();
                string lastName = empleado.LastName.ToLower();
                string? city = empleado.City != null ? empleado.City.ToLower() : null;

                if (firstName.Contains(textoABuscar) 
                    || lastName.Contains(textoABuscar) 
                    || (city != null && city.Contains(textoABuscar)))
                {
                    e.Accepted = true;
                }
                else
                    e.Accepted = false;
            }
        }
        
        private void btInsertarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            UCEmpleado insertarEmpleado = new UCEmpleado(false);
            insertarEmpleado.DefinirUsuario(usuario);
            Grid gridContenedor = (Grid)Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(insertarEmpleado);
        }


        private void btModificarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            if (listvEmpleados.SelectedItem != null) 
            {
                UCEmpleado editarEmpleado = new UCEmpleado(true);
                editarEmpleado.DefinirUsuario(usuario);
                editarEmpleado.DefinirEmpleado((Employee)listvEmpleados.SelectedItem);
                Grid gridContenedor = (Grid)Parent;
                gridContenedor.Children.Clear();
                gridContenedor.Children.Add(editarEmpleado);
            }
            
        }

        private void btBorrarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            Employee empleado = (Employee)listvEmpleados.SelectedItem;

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
                            empleados.Remove(empleado);
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
            else
            {
                MessageBox.Show("Debe seleccionar un empleado de la lista para eliminar");
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
