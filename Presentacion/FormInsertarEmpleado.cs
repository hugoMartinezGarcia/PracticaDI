using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInsertarEmpleado : Form
    {
        private bool valFirstName;
        private bool valLastName;
        private bool valTitle;
        private bool valTitleOfCourtesy;
        private bool valBirthDate;
        private bool valHireDate;
        private bool valAddress;
        private bool valCity;
        private bool valRegion;
        private bool valPostalCode;
        private bool valCountry;
        private bool valHomePhone;
        private bool valExtension;
        private bool valPhoto;
        private bool valNotes;
        private bool valReportsTo;
        private bool valPhotoPath;

        public FormInsertarEmpleado()
        {
            InitializeComponent();
            valFirstName = false;
            valLastName = false;
            valTitle = false;
            valTitleOfCourtesy = false;
            valBirthDate = false;
            valHireDate = false;
            valAddress = false;
            valCity = false;
            valRegion = false;
            valPostalCode = false;
            valCountry = false;
            valHomePhone = false;
            valExtension = false;
            valPhoto = false;
            valNotes = false;
            valReportsTo = false;
            valPhotoPath = false;
        }

        // Método que se ejecuta al abrir el formulario por primera vez.
        private void FormInsertarEmpleado_Load(object sender, EventArgs e)
        {
            cbTitleCourtesy.Items.AddRange(new string[] {"Seleccionar", "Ms.", "Dr.", "Mrs.", "Mr."});
            cbTitleCourtesy.SelectedIndex = 0;

            List<String> idEmpleados = new List<String>();
            idEmpleados.Add("Seleccionar");

            // Se carga la lista de id de empleados
            Gestion.ListarEmployee().ForEach(e => idEmpleados.Add(e.EmployeeId.ToString()));

            cbReportsTo.Items.AddRange(idEmpleados.ToArray());
            cbReportsTo.SelectedIndex = 0;
        }


        private void btInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.LastName = tbLastName.Text;
                emp.FirstName = tbFirstName.Text;
                emp.Title = tbTitle.Text;
                emp.TitleOfCourtesy = cbTitleCourtesy.SelectedItem.ToString();
                emp.BirthDate = dtpBirthDate.Value;
                emp.HireDate = dtpHireDate.Value;
                emp.Address = tbAddress.Text;
                emp.City = tbCity.Text;
                emp.Region = tbRegion.Text;
                emp.PostalCode = tbPostalcode.Text;
                emp.Country = tbCountry.Text;
                emp.HomePhone = mtbHomePhone.Text;
                emp.Extension = tbExtension.Text;
                emp.Photo = ImageToByteArray(pbPhoto.Image);
                emp.Notes = tbNotes.Text;
                emp.ReportsTo = Convert.ToInt32(cbReportsTo.SelectedItem);
                emp.PhotoPath = tbPhotoPath.Text;
            
                using (Gestion g = new Gestion())
                {
                    g.InsertarEmployee(emp);
                }

                MessageBox.Show("El empleado se ha insertado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido guardar el empleado: " + ex.Message);
            }
        }

        public int ValidarString(string texto, int longitudMax, bool nulo)
        {
            int codigoError = 0;

            if (texto.Length > longitudMax)
                codigoError = 1;
            if (texto.Length < 1 && !nulo)
                codigoError = 2;

            return codigoError;
        }

        private void IndicarError(Control control, String cadenaErrores)
        {
            control.BackColor = Color.LightCoral;
            errorProvider1.SetError(control, cadenaErrores);
        }

        private void IndicarOK(Control control)
        {
            control.BackColor = Color.LightGreen;
            errorProvider1.SetError(control, "");
        }


        // Método para recoger los string que admiten null
        public string? ComprobarTextBox(TextBox tb)
        {

            string? resultado = tb.Text != String.Empty ? tb.Text.Trim() : null;
            
            return resultado;
        }

        // Método para convertir imagen a array de bytes
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void btSeleccionarPhoto_Click(object sender, EventArgs e)
        {

            if (ofdPhoto.ShowDialog() == DialogResult.OK)
            {
                // Se obtiene la ruta del archivo seleccionado
                string rutaFoto = ofdPhoto.FileName;

                pbPhoto.Image = Image.FromFile(rutaFoto);
            }
        }

        private void tbFirstName_Leave(object sender, EventArgs e)
        {
            string cadenaErrores = "";
            int resultado = 0;

            resultado = ValidarString(tbFirstName.Text, 10, false);

            if (resultado > 0)
            {
                switch (resultado)
                {
                    case 1: cadenaErrores = "El campo First Name no permite más de 10 caracteres"; 
                        break;
                    case 2: cadenaErrores = "El campo First Name no puede estar vacío";
                        break;
                }
                IndicarError(tbFirstName, cadenaErrores);
                valFirstName = false;
            }
            else
            {
                IndicarOK(tbFirstName);
                valFirstName = true;
            }
        }
    }
}
