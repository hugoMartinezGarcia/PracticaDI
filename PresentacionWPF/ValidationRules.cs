using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PresentacionWPF
{
    public class ValidationRules : ValidationRule
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                // Campo obligatorio
                if (((string)value).Length <= 0)
                    return new ValidationResult(false, "El campo es obligatorio");
            }
            catch (Exception e)
            {
                return new ValidationResult(false, e.Message);
            }

            if ((((string)value).Length < Min) || (((string)value).Length > Max))
            {
                return new ValidationResult(false,
                    "La longitud del campo debe de estar comprendida entre : " + Min + " y " + Max + ".");
            }

            return ValidationResult.ValidResult;
        }
    }
}
