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
    public partial class FormProductos : Form
    {
        private Product? product;
        private List<Category> categories;

        public FormProductos()
        {
            InitializeComponent();
            product = null;
            categories = new List<Category>();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            categories = Gestion.ListarCategory();

            dgvCategories.DataSource = categories;
            dgvCategories.Columns["Products"].Visible = false;
        }

        private void dgvCategories_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int categorySeleccionada = (int)dgvCategories.CurrentRow.Cells["CategoryId"].Value;

            dgvProducts.DataSource = Gestion.ListarProduct().
                Where(p => p.CategoryId == categorySeleccionada).ToList();

            dgvProducts.Columns["Supplier"].Visible = false;
            dgvProducts.Columns["OrderDetails"].Visible = false;
            dgvProducts.Columns["Category"].Visible = false;
        }

        private void dgvProducts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            product = (Product)dgvProducts.CurrentRow.DataBoundItem;

            tbProductId.Text = Convert.ToString(product.ProductId);
            tbProductName.Text = product.ProductName;
            tbQuantityPerUnit.Text = Convert.ToString(product.QuantityPerUnit);
            tbUnitPrice.Text = Convert.ToString(product.UnitPrice);
            tbUnitsInStock.Text = Convert.ToString(product.UnitsInStock);
            tbUnitsOnOrder.Text = Convert.ToString(product.UnitsOnOrder);
            tbReorderLevel.Text = Convert.ToString(product.ReorderLevel);
            tbDiscontinued.Text = Convert.ToString(product.Discontinued);

            using (Gestion g = new Gestion())
            {
                tbSupplierId.Text = product.SupplierId != null ? 
                    g.BuscarSupplier((int)product.SupplierId).ContactName : null;
                tbCategoryId.Text = product.CategoryId != null ? 
                    g.BuscarCategory((int)product.CategoryId).CategoryName : null;
            }
        }

        private void btModificarPrecio_Click(object sender, EventArgs e)
        {
            if (product != null) 
            {
                try
                {
                    product.UnitPrice = Convert.ToInt32(tbUnitPrice.Text);

                    using (Gestion g = new Gestion())
                    {
                        g.ActualizarProduct(product);
                    }

                    MessageBox.Show("Se ha actualizado correctamente el Unit price del Product");
                    FormProductos_Load(sender, e);
                }
                catch (FormatException) 
                {
                    MessageBox.Show("El unit price introducido no es un valor numérico válido");
                }
                catch (Exception) 
                {
                    MessageBox.Show("No se ha podido actualizar el Product");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string categoryBuscada = tbBuscarCategory.Text;

            dgvCategories.DataSource = categories.
                Where(c => c.CategoryName.ToLower().Contains(categoryBuscada.ToLower())).ToList();
            dgvCategories.Columns["Products"].Visible = false;
        }
    }
}
