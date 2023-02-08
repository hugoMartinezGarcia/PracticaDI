using Entidades;
using Microsoft.Win32;
using Negocio;
using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace PresentacionWPF
{
    /// <summary>
    /// Lógica de interacción para UCEmpleado.xaml
    /// </summary>
    public partial class UCEmpleado : UserControl
    {
        private Employee? usuario;
        private MainWindow mainWindow;
        private Employee? empleado;
        private bool modoEditar;

        public UCEmpleado()
        {
            InitializeComponent();
            string[] titCortesia = new string[] {"Ms.", "Dr.", "Mrs.", "Mr." };
            cbTitleOfCourtesy.ItemsSource = titCortesia;
            cbReportsTo.ItemsSource = Gestion.ListarEmployee();
        }

        public UCEmpleado(Employee usuario, MainWindow mainWindow, bool modoEditar) : this()
        {
            this.usuario = usuario;
            this.mainWindow = mainWindow;
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
                empleado = new Employee();
                this.DataContext = empleado;
            }

        }

        private void ModoEditar()
        {
            this.DataContext = empleado;
            btInsertar.Content = "Modificar";
            //cbTitleOfCourtesy.SelectedItem = empleado!.TitleOfCourtesy;
            //cbInformaA.SelectedValue = empleado!.ReportsTo;
        }

        public void DefinirUsuario(Employee usuario)
        {
            this.usuario = usuario;
        }

        public void DefinirEmpleado(Employee empleado)
        {
            this.empleado = empleado;
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            Grid gridContenedor = (Grid)Parent;
            gridContenedor.Children.Clear();
            gridContenedor.Children.Add(new UCDashboard(usuario!, mainWindow));
        }

        private void btInsertar_Click(object sender, RoutedEventArgs e)
        {
            if (modoEditar)
            {
                using (Gestion g = new Gestion())
                {
                    g.ActualizarEmployee(empleado!);
                }
            }
            else
            {
                using (Gestion g = new Gestion())
                {
                    g.InsertarEmployee(empleado!);
                }
            }
        }

        private void btBorrarBirthDate_Click(object sender, RoutedEventArgs e)
        {
            dtBirthDate.SelectedDate = null;
        }

        private void btSeleccionarFoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage imagen = new BitmapImage(new Uri(openFileDialog.FileName));

                // Se asigna la imagen al empleado. Se reflejará en la interfaz gracias al Binding.
                empleado!.Photo = ConvertBitmapImageToByteArray(imagen);
            }
        }

        // Método para convertir un BitmapImage a Array de bytes
        private byte[] ConvertBitmapImageToByteArray(BitmapImage image)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }

        private void btBorrarFoto_Click(object sender, RoutedEventArgs e)
        {
            empleado!.Photo = null;
        }

        private void btBorrarTitleOfCourtesy_Click(object sender, RoutedEventArgs e)
        {
            cbTitleOfCourtesy.SelectedItem = null;
        }

        private void btBorrarReportsTo_Click(object sender, RoutedEventArgs e)
        {
            cbReportsTo.SelectedItem = null;
        }
    }
}
