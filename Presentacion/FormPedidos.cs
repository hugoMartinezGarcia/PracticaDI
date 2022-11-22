using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPedidos : Form
    {
        private Customer? customer;
        private DataTable dtProducts;
        List<OrderDetail> orderDetails;

        public FormPedidos()
        {
            InitializeComponent();
            //tlpOrder.RowStyles[0].SizeType = 0;
            customer = null;
            dtProducts = new DataTable();
            orderDetails = new List<OrderDetail>();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            Utiles.BorrarFecha(dtpOrderDate);
            Utiles.BorrarFecha(dtpRequiredDate);
            Utiles.BorrarFecha(dtpShippedDate);

            using (Gestion g = new Gestion())
            {
                dtProducts = g.DataTableProductos(0);
                dgvProducts.DataSource = dtProducts;
            }
        }

        private void btEditarCustomer_Click(object sender, EventArgs e)
        {
            FormBuscarCustomer formBuscarCustomer = new FormBuscarCustomer(this);
            formBuscarCustomer.MdiParent = this.MdiParent;
            formBuscarCustomer.Show();
        }

        public void DefinirCustomer(Customer customer)
        {
            this.customer = customer;
            tbCustomer.Text = customer.ContactName;
        }

        private void btBorrarCustomer_Click(object sender, EventArgs e)
        {
            customer = null;
            tbCustomer.Clear();
        }

        private void lbProducts_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Active = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Nuevo DataView con los datos del DataTable dtEmployees
            DataView dv = new DataView(dtProducts);

            // Filtro para buscar en id, first name y last name
            // Se convierte el valor del id a String
            dv.RowFilter = String.Format(
                "[Product name] LIKE '%{0}%'",
                tbBuscarProducts.Text);

            // Se pasa el DataView filtrado al DataGridView
            dgvProducts.DataSource = dv;
        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            Product? product = null;

            using (Gestion g = new Gestion())
            { 
                // Se obtiene el producto de la bbdd a partir de la celda seleccionada en el dgv
                product = g.BuscarProduct((int)dgvProducts.CurrentRow.Cells["Product Id"].Value);
            }

            if (product != null) 
            { 
                OrderDetail od = new OrderDetail();
                od.Product = product;
                od.ProductId = product.ProductId;
                orderDetails.Add(od);
                dgvOrderDetails.DataSource = orderDetails.ToList();
                dgvOrderDetails.Columns["OrderId"].Visible = false;
                dgvOrderDetails.Columns["Order"].Visible = false;
            }
            
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.CustomerId = customer != null ? customer.CustomerId : null;
            // resto de campos del Order

            using (Gestion g = new Gestion())
            {
                g.InsertarOrder(order);
            }


            orderDetails.ForEach(od =>
            {
                od.OrderId = order.OrderId;
            });
        }
    }
}
