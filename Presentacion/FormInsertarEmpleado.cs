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
        public FormInsertarEmpleado()
        {
            InitializeComponent();
        }

        private void FormInsertarEmpleado_Load(object sender, EventArgs e)
        {
            cbTitleCourtesy.Items.AddRange(new string[] {"Seleccionar", "Ms.", "Dr.", "Mrs.", "Mr."});
            cbTitleCourtesy.SelectedIndex = 0;
        }
    }
}
