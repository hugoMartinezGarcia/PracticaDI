using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private Employee? employee;

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

            employee = null;
        }

        public FormInsertarEmpleado(Employee employee) : this()
        {
            this.employee = employee;
        }

        // Método que se ejecuta al abrir el formulario por primera vez.
        private void FormInsertarEmpleado_Load(object sender, EventArgs e)
        {
            cbTitleCourtesy.Items.AddRange(new string[] {"Seleccionar", "Ms.", "Dr.", "Mrs.", "Mr."});
            cbTitleCourtesy.SelectedIndex = 0;

            List<String> idEmpleados = new List<String>();
            idEmpleados.Add("Seleccionar");

            // Se carga la lista de id de empleados
            Gestion.ListarEmployee().ForEach(e => idEmpleados.Add(e.EmployeeId.ToString() + " - " + e.FirstName + " " + e.LastName));

            cbReportsTo.Items.AddRange(idEmpleados.ToArray());
            cbReportsTo.SelectedIndex = 0;

            if (employee != null)
            {
                ModoActualizar();
            }
        }

        private void ModoActualizar()
        {
            tbLastName.Text = employee.LastName;
            tbFirstName.Text = employee.FirstName;
            tbTitle.Text = employee.Title;
            cbTitleCourtesy.SelectedItem = employee.TitleOfCourtesy;
            dtpBirthDate.Value = (DateTime)employee.BirthDate!;
            dtpHireDate.Value = (DateTime)employee.HireDate!;
            tbAddress.Text = employee.Address;
            tbCity.Text = employee.City;
            tbRegion.Text = employee.Region;
            tbPostalcode.Text = employee.PostalCode;
            tbCountry.Text = employee.Country;
            mtbHomePhone.Text = employee.HomePhone;
            tbExtension.Text = employee.Extension;
            pbPhoto.Image = ByteArrayToImage(employee.Photo);
            tbNotes.Text = employee.Notes;
            cbReportsTo.SelectedItem = employee.ReportsTo;
            tbPhotoPath.Text = employee.PhotoPath;

            btInsertar.Text = "Actualizar";
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

        // Método para convertir Array de bytes en Imagen
        public Image? ByteArrayToImage(byte[]? byteArray)
        {
            ImageConverter converter = new ImageConverter();
            Image? imagen = (Image?)converter.ConvertFrom(byteArray);

            return imagen;
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
                try
                {
                    // Se obtiene la ruta del archivo seleccionado
                    string rutaFoto = ofdPhoto.FileName;

                    pbPhoto.Image = Image.FromFile(rutaFoto);
                }
                catch
                {
                    MessageBox.Show("No es un archivo válido");
                }
            }
        }

        // Método genérico para validar TextBox de string
        private bool ValidarTextBoxString(TextBox textBox, string nombreCampo, int longitudMax, bool nulo)
        {
            string cadenaErrores = "";
            bool respuesta;
            int codigoError = 0;

            if (textBox.Text.Length > longitudMax)
                codigoError = 1;
            if (textBox.Text.Length < 1 && !nulo)
                codigoError = 2;

            if (codigoError > 0)
            {
                switch (codigoError)
                {
                    case 1:
                        cadenaErrores = $"El campo {nombreCampo} no permite más de {longitudMax} caracteres";
                        break;
                    case 2:
                        cadenaErrores = $"El campo {nombreCampo} no puede estar vacío";
                        break;
                }
                IndicarError(textBox, cadenaErrores);
                respuesta = false;
            }
            else
            {
                IndicarOK(textBox);
                respuesta = true;
            }

            return respuesta;
        }

        private void tbFirstName_Leave(object sender, EventArgs e)
        {
           valFirstName = ValidarTextBoxString((TextBox)sender, "First name", 10, false);
        }

        private void tbLastName_Leave(object sender, EventArgs e)
        {
            valLastName = ValidarTextBoxString((TextBox)sender, "Last name", 20, false);
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            valTitle = ValidarTextBoxString((TextBox)sender, "Title", 30, true);
        }

        private void tbAddress_Leave(object sender, EventArgs e)
        {
            valAddress = ValidarTextBoxString((TextBox)sender, "Address", 60, true);
        }

        private void tbCity_Leave(object sender, EventArgs e)
        {
            valCity = ValidarTextBoxString((TextBox)sender, "City", 15, true);
        }

        private void tbRegion_Leave(object sender, EventArgs e)
        {
            valRegion = ValidarTextBoxString((TextBox)sender, "Region", 15, true);
        }

        private void tbPostalcode_Leave(object sender, EventArgs e)
        {
            valPostalCode = ValidarTextBoxString((TextBox)sender, "Postal code", 10, true);
        }

        private void tbCountry_Leave(object sender, EventArgs e)
        {
            valCountry = ValidarTextBoxString((TextBox)sender, "Country", 15, true);
        }

        private void tbExtension_Leave(object sender, EventArgs e)
        {
            valExtension = ValidarTextBoxString((TextBox)sender, "Extension", 4, true);
        }

        private void tbPhotoPath_Leave(object sender, EventArgs e)
        {
            string patron = "^(ht|f)tp(s?)\\:\\/\\/[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*(:(0-9)*)*(\\/?)([a-zA-Z0-9\\-\\.\\?\\,\\'\\/\\\\\\+&amp;%\\$#_]*)?$";

            if (Regex.IsMatch(tbPhotoPath.Text, patron) || String.IsNullOrEmpty(tbPhotoPath.Text.Trim()))
            {
                IndicarOK(tbPhotoPath);
            }
            else
            {
                string cadenaErrores = "No es una dirección válida";
                IndicarError(tbPhotoPath, cadenaErrores);
            }

        }

        /*
        public int ValidarString(string texto, int longitudMax, bool nulo)
        {
            int codigoError = 0;

            if (texto.Length > longitudMax)
                codigoError = 1;
            if (texto.Length < 1 && !nulo)
                codigoError = 2;

            return codigoError;
        }

        // Método para recoger los string que admiten null
        public string? ComprobarTextBox(TextBox tb)
        {

            string? resultado = tb.Text != String.Empty ? tb.Text.Trim() : null;
            
            return resultado;
        }
        */
    }
}
