using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    internal class Utiles
    {
        // Método para recoger los string que admiten null
        public static string? FormatearTBNullString(TextBox tb)
        {

            string? resultado = tb.Text != String.Empty ? tb.Text.Trim() : null;

            return resultado;
        }

        // Método para recoger los int que admiten null
        public static int? FormatearTBNullInt(TextBox tb)
        {
            int? resultado = null;

            try 
            {
                if (tb.Text != String.Empty) 
                    resultado = Convert.ToInt32(tb.Text);
            }
            catch
            {
                MessageBox.Show("Introduce un valor entero válido");
            }

            return resultado;
        }

        public static decimal? FormatearTBNullDecimal(TextBox tb)
        {
            decimal? resultado = null;

            try
            {
                if (tb.Text != String.Empty)
                    resultado = Convert.ToDecimal(tb.Text);
            }
            catch
            {
                MessageBox.Show("Introduce un valor entero válido");
            }

            return resultado;
        }

        // Método genérico para validar TextBox de string
        public static bool ValidarTextBoxString(TextBox textBox, string nombreCampo, int longitudMax, bool nulo, ErrorProvider errorProvider)
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
                IndicarError(textBox, errorProvider, cadenaErrores);
                respuesta = false;
            }
            else
            {
                IndicarOK(textBox, errorProvider);
                respuesta = true;
            }

            return respuesta;
        }

        public static void IndicarError(Control control, ErrorProvider errorProvider, String cadenaErrores)
        {
            control.BackColor = Color.LightCoral;
            errorProvider.SetError(control, cadenaErrores);
        }

        public static void IndicarOK(Control control, ErrorProvider errorProvider)
        {
            control.BackColor = Color.LightGreen;
            errorProvider.SetError(control, "");
        }

        // Método para borrar las fechas y establecer los valores a MinDate
        public static void BorrarFecha(DateTimePicker dtp)
        {
            dtp.Value = dtp.MinDate;
            dtp.CustomFormat = " ";
            dtp.Format = DateTimePickerFormat.Custom;
        }

        // Método para validar que la fecha introducida no sea mayor a la fecha actual
        public static bool ValidarDatePicker(DateTimePicker dt, ErrorProvider errorProvider)
        {
            bool respuesta;

            if (dt.Value > DateTime.Today)
            {
                IndicarError(dt, errorProvider, "La fecha no puede ser mayor a la actual");
                respuesta = false;
            }
            else
            {
                IndicarOK(dt, errorProvider);
                respuesta = true;
            }

            return respuesta;
        }


    }
}
