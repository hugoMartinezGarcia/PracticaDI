using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace PresentacionWPF
{
    class UtilesWPF
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
    }
}
