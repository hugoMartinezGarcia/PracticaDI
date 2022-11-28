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
    public partial class FormBuscarOrder : Form
    {
        private DataTable dtCustomers;
        private DataTable dtOrders;
        private string customerId;
        private bool modoFactura;

        public FormBuscarOrder(bool modoFactura)
        {
            InitializeComponent();
            dtCustomers = new DataTable();
            dtOrders = new DataTable();
            customerId = string.Empty;
            this.modoFactura = modoFactura;
        }

        private void FormBuscarOrder_Load(object sender, EventArgs e)
        {
            using (Gestion g = new Gestion())
            {
                dtCustomers = g.DataTableCustomers();
                dtOrders = g.DataTableOrders();
            }

            dgvCustomers.DataSource = dtCustomers;
            Utiles.BorrarFecha(dtpOrderDate);
        }

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            DataView dv = new DataView(dtOrders);

            if (dtpOrderDate.Value > dtpOrderDate.MinDate)
            {
                dv.RowFilter = String.Format(
                    "[Customer id] LIKE '%{0}%' " +
                    "AND [Order date] = '{1}'",
                    customerId, dtpOrderDate.Value);
            }
            else
            {
                dv.RowFilter = String.Format(
                        "[Customer id] LIKE '%{0}%'",
                        customerId);
            }

            dgvOrders.DataSource = dv;
        }

        private void btBorrarOrderDate_Click(object sender, EventArgs e)
        {
            Utiles.BorrarFecha(dtpOrderDate);
        }

        private void dgvCustomers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                customerId = (string)dgvCustomers.CurrentRow.Cells["Customer Id"].Value;

                DataView dv = new DataView(dtOrders);
                
                if (dtpOrderDate.Value > dtpOrderDate.MinDate)
                {
                    dv.RowFilter = String.Format(
                        "[Customer id] LIKE '%{0}%' " +
                        "AND [Order date] = '{1}'",
                        customerId, dtpOrderDate.Value);
                }
                else
                {
                    dv.RowFilter = String.Format(
                        "[Customer id] LIKE '%{0}%'",
                        customerId);
                }

                dgvOrders.DataSource = dv;
        }
            catch (Exception)
            {
                // Ignorar la excepción
            }
        }

        private void tbBuscarCustomer_TextChanged(object sender, EventArgs e)
        {
            // Nuevo DataView con los datos del DataTable dtEmployees
            DataView dv = new DataView(dtCustomers);

            // Filtro para buscar en id, first name y last name
            // Se convierte el valor del id a String
            dv.RowFilter = String.Format(
                "[Customer Id] LIKE '%{0}%' " +
                "OR [Company name] LIKE '%{0}%' " +
                "OR [Contact name] LIKE '%{0}%'",
                tbBuscarCustomer.Text);

            // Se pasa el DataView filtrado al DataGridView
            dgvCustomers.DataSource = dv;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBorrarSeleccion_Click(object sender, EventArgs e)
        {
            BorrarSeleccionDGVCustomers();
        }

        private void BorrarSeleccionDGVCustomers()
        {
            dgvCustomers.ClearSelection();
            customerId = "";
            DataView dv = new DataView(dtOrders);

            if (dtpOrderDate.Value > dtpOrderDate.MinDate)
            {
                dv.RowFilter = String.Format(
                    "[Order date] = '{0}'",
                    dtpOrderDate.Value);
            }

            dgvOrders.DataSource = dv;
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dgvOrders.CurrentRow.Cells["Order Id"].Value;
                Order order = new Order();

                using (Gestion g = new Gestion())
                {
                    order = g.DatosPedido(id);
                }

                if (modoFactura)
                {
                    FormFactura formFactura = new FormFactura(order);
                    formFactura.MdiParent = this.MdiParent;
                    formFactura.Show();
                    this.Close();
                }
                else
                {
                    FormPedidos formActualizarPedido = new FormPedidos(true);
                    formActualizarPedido.DefinirOrder(order);
                    formActualizarPedido.MdiParent = this.MdiParent;
                    formActualizarPedido.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                // Ignorar la excepción
            }
        }
    }
}
