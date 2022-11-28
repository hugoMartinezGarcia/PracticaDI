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
        private bool valBirthDate;
        private bool valHireDate;
        private bool valAddress;
        private bool valCity;
        private bool valRegion;
        private bool valPostalCode;
        private bool valCountry;
        private bool valHomePhone;
        private bool valExtension;
        private bool valPhotoPath;
        private bool valPhoto;

        private bool modoActualizar;

        private Employee? empleado;
        // Sorted list para mostrar los datos de los empleados
        private SortedList<int, string> empleados;

        public FormInsertarEmpleado()
        {
            InitializeComponent();
            valFirstName = false;
            valLastName = false;
            valTitle = false;
            valBirthDate = false;
            valHireDate = false;
            valAddress = false;
            valCity = false;
            valRegion = false;
            valPostalCode = false;
            valCountry = false;
            valHomePhone = true;
            valExtension = false;
            valPhotoPath = false;
            valPhoto = false;

            modoActualizar = false;

            empleado = null;
            empleados = new SortedList<int, string>();
        }

        public FormInsertarEmpleado(bool modoActualizar) : this()
        {
            this.modoActualizar = modoActualizar;
        }

        // Método que se ejecuta al abrir el formulario por primera vez.
        private void FormInsertarEmpleado_Load(object sender, EventArgs e)
        {
            cbTitleCourtesy.Items.AddRange(new string[] {"Sin selección", "Ms.", "Dr.", "Mrs.", "Mr."});
            cbTitleCourtesy.SelectedIndex = 0;

            // Se añaden los datos a la sorted List
            empleados.Add(0, "Sin selección");
            Gestion.ListarEmployee().ForEach(e => empleados.Add(
                e.EmployeeId, 
                e.EmployeeId.ToString() + " - " + e.FirstName + " " + e.LastName));
            cbReportsTo.Items.AddRange(empleados.Values.ToArray());
            cbReportsTo.SelectedIndex = 0;

            BorrarFecha(dtpBirthDate);
            BorrarFecha(dtpHireDate);

            if (modoActualizar)
            {
                ModoActualizar();
            }
        }

        // Método para rellenar los campos con los datos del empleado cuando el Form está en modo actualizar
        private void ModoActualizar()
        {
            tbLastName.Text = empleado!.LastName;
            tbFirstName.Text = empleado!.FirstName;
            tbTitle.Text = empleado.Title;
            cbTitleCourtesy.SelectedItem = empleado.TitleOfCourtesy;
            if (empleado.BirthDate != null) 
            {
                dtpBirthDate.Format = DateTimePickerFormat.Short;
                dtpBirthDate.Value = (DateTime)empleado.BirthDate; 
            }

            if (empleado.HireDate != null)
            {
                dtpHireDate.Format = DateTimePickerFormat.Short;
                dtpHireDate.Value = (DateTime)empleado.HireDate;
            }

            if (empleado.ReportsTo != null)
            {
                if (empleados.ContainsKey((int)empleado.ReportsTo))
                    cbReportsTo.SelectedItem = empleados[(int)empleado.ReportsTo];
            }

            pbPhoto.Image = empleado.Photo != null ? ByteArrayToImage(empleado.Photo) : null;

            tbAddress.Text = empleado.Address;
            tbCity.Text = empleado.City;
            tbRegion.Text = empleado.Region;
            tbPostalcode.Text = empleado.PostalCode;
            tbCountry.Text = empleado.Country;
            mtbHomePhone.Text = empleado.HomePhone;
            tbExtension.Text = empleado.Extension;
            tbNotes.Text = empleado.Notes;
            tbPhotoPath.Text = empleado.PhotoPath;

            btInsertar.Text = "Actualizar";
        }

        private void tbFirstName_Leave(object sender, EventArgs e)
        {
            valFirstName = ValidarTextBoxString(tbFirstName, "First name", 10, false);
        }

        private void tbLastName_Leave(object sender, EventArgs e)
        {
            valLastName = ValidarTextBoxString(tbLastName, "Last name", 20, false);
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            valTitle = ValidarTextBoxString(tbTitle, "Title", 30, true);
        }

        private void tbAddress_Leave(object sender, EventArgs e)
        {
            valAddress = ValidarTextBoxString(tbAddress, "Address", 60, true);
        }

        private void tbCity_Leave(object sender, EventArgs e)
        {
            valCity = ValidarTextBoxString(tbCity, "City", 15, true);
        }

        private void tbRegion_Leave(object sender, EventArgs e)
        {
            valRegion = ValidarTextBoxString(tbRegion, "Region", 15, true);
        }

        private void tbPostalcode_Leave(object sender, EventArgs e)
        {
            valPostalCode = ValidarTextBoxString(tbPostalcode, "Postal code", 10, true);
        }

        private void tbCountry_Leave(object sender, EventArgs e)
        {
            valCountry = ValidarTextBoxString(tbCountry, "Country", 15, true);
        }

        private void tbExtension_Leave(object sender, EventArgs e)
        {
            valExtension = ValidarTextBoxString(tbExtension, "Extension", 4, true);
        }

        private void tbPhotoPath_Leave(object sender, EventArgs e)
        {
            valPhotoPath = ValidarPathUrl(tbPhotoPath, 255);
        }

        private void dtpBirthDate_Leave(object sender, EventArgs e)
        {
            valBirthDate = ValidarDatePicker(dtpBirthDate);
        }

        private void dtpHireDate_Leave(object sender, EventArgs e)
        {
            valHireDate = ValidarDatePicker(dtpHireDate);
        }

        // El evento ocurre cuando se sale del mtbHomePhone
        private void mtbHomePhone_Leave(object sender, EventArgs e)
        {
            valHomePhone = ValidarMaskedTextBox(mtbHomePhone);
        }

        // Método para validar un MaskedTextBox
        private bool ValidarMaskedTextBox(MaskedTextBox mtb)
        {
            bool resultado;

            if (mtb.MaskCompleted || String.IsNullOrEmpty(mtb.Text))
            {
                IndicarOK(mtb);
                resultado = true;
            }
            else
            {
                IndicarError(mtb, "No es un número válido");
                resultado = false;
            }

            return resultado;
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            dtpBirthDate.Format = DateTimePickerFormat.Short;
        }

        private void dtpHireDate_ValueChanged(object sender, EventArgs e)
        {
            dtpHireDate.Format = DateTimePickerFormat.Short;
        }

        // Método para validar una dirección URL introducida en un TextBox mediante una expresión regular 
        private bool ValidarPathUrl(TextBox textBox, int longitudMax)
        {
            string tbTexto = textBox.Text.Trim();
            bool respuesta;
            string patron = "^(ht|f)tp(s?)\\:\\/\\/[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*(:(0-9)*)*(\\/?)([a-zA-Z0-9\\-\\.\\?\\,\\'\\/\\\\\\+&amp;%\\$#_]*)?$";

            if ((Regex.IsMatch(tbTexto, patron)
                && tbTexto.Length <= longitudMax) 
                || String.IsNullOrEmpty(tbTexto))
            {
                IndicarOK(tbPhotoPath);
                respuesta = true;
            }
            else
            {
                IndicarError(textBox, "No es una dirección válida");
                respuesta = false;
            }

            return respuesta;
        }

        // Método para validar que la fecha introducida no sea mayor a la fecha actual
        private bool ValidarDatePicker(DateTimePicker dt)
        {
            bool respuesta;

            if (dt.Value > DateTime.Today)
            {
                IndicarError(dt, "La fecha no puede ser mayor a la actual");
                respuesta = false;
            }
            else
            {
                IndicarOK(dt);
                respuesta = true;
            }

            return respuesta;
        }

        // El evento ocurre cuando se introducen datos no numéricos
        private void mtbHomePhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            IndicarError(mtbHomePhone, "Solo se permiten datos numéricos");
        }

        private void btBorrarBirthDate_Click(object sender, EventArgs e)
        {
            BorrarFecha(dtpBirthDate);
        }

        private void btBorrarHireDate_Click(object sender, EventArgs e)
        {
            BorrarFecha(dtpHireDate);
        }

        private bool ComprobarCampos()
        {
            // Se comprueba si todos los campos tienen datos correctos
            valFirstName = ValidarTextBoxString(tbFirstName, "First name", 10, false);
            valLastName = ValidarTextBoxString(tbLastName, "Last name", 20, false);
            valTitle = ValidarTextBoxString(tbTitle, "Title", 30, true);
            valAddress = ValidarTextBoxString(tbAddress, "Address", 60, true);
            valCity = ValidarTextBoxString(tbCity, "City", 15, true);
            valRegion = ValidarTextBoxString(tbRegion, "Region", 15, true);
            valPostalCode = ValidarTextBoxString(tbPostalcode, "Postal code", 10, true);
            valCountry = ValidarTextBoxString(tbCountry, "Country", 15, true);
            valExtension = ValidarTextBoxString(tbExtension, "Extension", 4, true);
            valPhotoPath = ValidarPathUrl(tbPhotoPath, 255);
            valBirthDate = ValidarDatePicker(dtpBirthDate);
            valHireDate = ValidarDatePicker(dtpHireDate);
            valHomePhone = ValidarMaskedTextBox(mtbHomePhone);

            // Se devuelve true si todos los campos están correctos o false en caso contrario
            return valFirstName && valLastName && valTitle && valAddress && valCity && valRegion 
                && valPostalCode && valCountry && valExtension && valPhotoPath && valBirthDate 
                && valHireDate && valHomePhone;
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            // Se comprueban todos los campos antes de intentar guardar
            if (ComprobarCampos()) 
            {
                try
                {
                    // Se instancia un nuevo empleado utilizando los valores de los campos del formulario
                    Employee nuevoEmployee = new Employee();

                    nuevoEmployee.LastName = tbLastName.Text;
                    nuevoEmployee.FirstName = tbFirstName.Text;
                    nuevoEmployee.Title = FormatearTBNullString(tbTitle);
                    
                    if (cbTitleCourtesy.SelectedIndex > 0)
                        nuevoEmployee.TitleOfCourtesy = cbTitleCourtesy.SelectedItem.ToString();
                    else
                        nuevoEmployee.TitleOfCourtesy = null;

                    nuevoEmployee.BirthDate = dtpBirthDate.Value == dtpBirthDate.MinDate ? null : dtpBirthDate.Value;
                    nuevoEmployee.HireDate = dtpHireDate.Value == dtpHireDate.MinDate ? null : dtpHireDate.Value;
                    nuevoEmployee.Address = FormatearTBNullString(tbAddress);
                    nuevoEmployee.City = FormatearTBNullString(tbCity);
                    nuevoEmployee.Region = FormatearTBNullString(tbRegion);
                    nuevoEmployee.PostalCode = FormatearTBNullString(tbPostalcode);
                    nuevoEmployee.Country = FormatearTBNullString(tbCountry);
                    nuevoEmployee.HomePhone = mtbHomePhone.Text != String.Empty ? mtbHomePhone.Text.Trim() : null;
                    nuevoEmployee.Extension = FormatearTBNullString(tbExtension);
                    nuevoEmployee.Photo = valPhoto ? ImageToByteArray(pbPhoto.Image) : null;
                    nuevoEmployee.PhotoPath = FormatearTBNullString(tbPhotoPath);
                    nuevoEmployee.Notes = FormatearTBNullString(tbNotes);

                    if (cbReportsTo.SelectedIndex > 0)
                        // Si se ha seleccionado algún empleado de la lista se obtiene la key
                        // de la sortedList a partir del value. La key representa el EmployeeId
                        nuevoEmployee.ReportsTo = empleados.
                            FirstOrDefault(e => e.Value == (string)cbReportsTo.SelectedItem).Key;
                    else
                        nuevoEmployee.ReportsTo = null;

                    // Si está en modo actualizar
                    if (modoActualizar)
                    {
                        // Se copia el id del empleado recibido al nuevoEmployee
                        nuevoEmployee.EmployeeId = empleado!.EmployeeId;

                        using (Gestion g = new Gestion())
                        {
                            g.ActualizarEmployee(nuevoEmployee);
                        }

                        MessageBox.Show(String.Format("El empleado {0}- {1} {2} se ha modificado correctamente", 
                            nuevoEmployee.EmployeeId, nuevoEmployee.FirstName, nuevoEmployee.LastName));
                    }
                    // Si no está en modo actualizar se inserta el nuevoEmployee
                    else
                    {
                        using (Gestion g = new Gestion())
                        {
                            g.InsertarEmployee(nuevoEmployee);
                        }

                        MessageBox.Show(String.Format("El empleado {0}- {1} {2} se ha insertado correctamente",
                            nuevoEmployee.EmployeeId, nuevoEmployee.FirstName, nuevoEmployee.LastName));
                    }
                    this.Close();
                }
                catch (Exception)
                {
                    if (modoActualizar)
                        MessageBox.Show("No se ha podido actualizar el empleado");
                    else
                        MessageBox.Show("No se ha podido insertar el empleado");
                }
            }
            else
                MessageBox.Show("El formulario contiene errores");
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
        public Image ByteArrayToImage(byte[] byteArray)
        {
            ImageConverter converter = new ImageConverter();
            Image imagen = (Image)converter.ConvertFrom(byteArray)!;

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

        // Método para borrar las fechas y establecer los valores a MinDate
        private void BorrarFecha(DateTimePicker dtp)
        {
            dtp.Value = dtp.MinDate;
            dtp.CustomFormat = " ";
            dtp.Format = DateTimePickerFormat.Custom;
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
                    valPhoto = true;
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
            string tb = textBox.Text.Trim();
            string cadenaErrores = "";
            bool respuesta;
            int codigoError = 0;

            if (tb.Length > longitudMax)
                codigoError = 1;
            if (tb.Length < 1 && !nulo)
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "Si cierra se perderán los cambios.\n¿Confirma que desea salir?",
                "Cerrar ventana",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // A través de este método se recibe el empleado desde el Form Buscar
        public void DefinirEmpleado(Employee employee)
        {
            this.empleado = employee;
        }

        // Método para recoger los string que admiten null
        public string? FormatearTBNullString(TextBox tb)
        {

            string? resultado = tb.Text != String.Empty ? tb.Text.Trim() : null;
            
            return resultado;
        }

        private void btBorrarPhoto_Click(object sender, EventArgs e)
        {
            pbPhoto.Image = null;
        }
    }
}
