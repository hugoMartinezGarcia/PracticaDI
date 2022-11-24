﻿using Entidades;
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
        private List<OrderDetail> orderDetails;
        private Employee? employee;
        private Order? order;
        private bool modoActualizar;

        public FormPedidos()
        {
            InitializeComponent();
            //int alturaFila = (int)tlpOrder.RowStyles[0].SizeType;
            //tlpOrder.RowStyles[0].SizeType = 0;
            customer = null;
            employee = null;
            order = null;
            dtProducts = new DataTable();
            orderDetails = new List<OrderDetail>();
            modoActualizar = false;
        }

        public FormPedidos(bool modoActualizar) : this()
        {
           this.modoActualizar = modoActualizar;
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

            if (modoActualizar)
                ModoActualizar();
        }

        private void ModoActualizar()
        {
            // Se copia la lista del order recibido
            orderDetails = order!.OrderDetails.ToList();
            employee = order!.Employee;
            customer = order!.Customer;

            lbOrderId.Visible = true;
            tbOrderId.Visible = true;
            tbOrderId.Text = order!.OrderId.ToString();
            lbEmployeeId.Visible = true;
            tbEmployee.Visible = true;
            if (order.Employee != null)
                tbEmployee.Text = order.Employee.FirstName + " " + order.Employee.LastName;
            if (order.Customer != null)
               tbCustomer.Text = order.Customer.ContactName;
            if (order.OrderDate != null)
            {
                dtpOrderDate.Format = DateTimePickerFormat.Short;
                dtpOrderDate.Value = (DateTime)order.OrderDate;
            }
            if (order.RequiredDate != null)
            {
                dtpRequiredDate.Format = DateTimePickerFormat.Short;
                dtpRequiredDate.Value = (DateTime)order.RequiredDate;
            }
            if (order.ShippedDate!= null)
            {
                dtpShippedDate.Format = DateTimePickerFormat.Short;
                dtpShippedDate.Value = (DateTime)order.ShippedDate;
            }

            tbShipVia.Text = order.ShipVia.ToString();
            tbFreight.Text =  order.Freight.ToString();
            tbShipName.Text = order.ShipName;
            tbShipAddress.Text = order.ShipAddress;
            tbShipCity.Text = order.ShipCity;
            tbShipRegion.Text = order.ShipRegion;
            tbShipPostalCode.Text = order.ShipPostalCode;
            tbShipCountry.Text = order.ShipCountry;

            ActualizarDGVOrderDetails();
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
                // Se asigna el product seleccionado, su productId y su unitPrice al OrderDetail
                od.Product = product;
                od.ProductId = product.ProductId;
                od.UnitPrice = product.UnitPrice != null ? (decimal)product.UnitPrice : 1;

                // Si el product no está ya en la lista, se añade
                if (!orderDetails.Any(oD => oD.ProductId == od.ProductId))
                    orderDetails.Add(od);
                else
                    MessageBox.Show("Este producto ya está añadido al pedido");
            }

            ActualizarDGVOrderDetails();

        }

        private void ActualizarResumenFactura(List<OrderDetail> orderDetails)
        {
            ResumenFactura resumenFactura = Gestion.ResumenFactura(orderDetails);
            tbPrecio.Text = resumenFactura.Precio.ToString("n2");
            tbIVA.Text = resumenFactura.IVA.ToString();
            tbTotal.Text = resumenFactura.Total.ToString("n2");
        }

        private void ActualizarDGVOrderDetails()
        {
            dgvOrderDetails.DataSource = orderDetails.ToList();
            dgvOrderDetails.Columns["OrderId"].Visible = false;
            dgvOrderDetails.Columns["Order"].Visible = false;
            dgvOrderDetails.Columns["Eliminar"].Visible = true;

            dgvOrderDetails.Columns["ProductId"].DisplayIndex = 0;
            dgvOrderDetails.Columns["Product"].DisplayIndex = 1;
            dgvOrderDetails.Columns["UnitPrice"].DisplayIndex = 2;
            dgvOrderDetails.Columns["Quantity"].DisplayIndex = 3;
            dgvOrderDetails.Columns["Discount"].DisplayIndex = 4;
            dgvOrderDetails.Columns["Eliminar"].DisplayIndex = 5;

            dgvOrderDetails.Columns["ProductId"].ReadOnly = true;
            dgvOrderDetails.Columns["Product"].ReadOnly = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Order nuevaOrder = new Order();
                nuevaOrder.CustomerId = customer != null ? customer.CustomerId : null;
                nuevaOrder.EmployeeId = employee != null ? employee.EmployeeId : null;
                nuevaOrder.OrderDate = dtpOrderDate.Value == dtpOrderDate.MinDate ? null : dtpOrderDate.Value;
                nuevaOrder.RequiredDate = dtpRequiredDate.Value == dtpRequiredDate.MinDate ? null : dtpRequiredDate.Value;
                nuevaOrder.ShippedDate = dtpShippedDate.Value == dtpShippedDate.MinDate ? null : dtpShippedDate.Value;
                nuevaOrder.ShipVia = Utiles.FormatearTBNullInt(tbShipVia);
                nuevaOrder.Freight = Utiles.FormatearTBNullDecimal(tbFreight);
                nuevaOrder.ShipName = Utiles.FormatearTBNullString(tbShipName);
                nuevaOrder.ShipAddress = Utiles.FormatearTBNullString(tbShipAddress);
                nuevaOrder.ShipCity = Utiles.FormatearTBNullString(tbShipCity);
                nuevaOrder.ShipRegion = Utiles.FormatearTBNullString(tbShipRegion);
                nuevaOrder.ShipPostalCode = Utiles.FormatearTBNullString(tbShipPostalCode);
                nuevaOrder.ShipCountry = Utiles.FormatearTBNullString(tbShipCountry);

                if (modoActualizar)
                {
                    // Se copia el id del order recibido en el form
                    nuevaOrder.OrderId = order!.OrderId;

                    using (Gestion g = new Gestion())
                    {
                        // Se actualiza el Order
                        g.ActualizarOrder(nuevaOrder);
                        // Se borran los orderDetails del antiguo order
                        order.OrderDetails.ToList().ForEach(oD => g.BorrarOrderDetail(oD));
                        // se guardan los nuevos orderDetails
                        orderDetails.ForEach(od =>
                        {
                            od.OrderId = nuevaOrder.OrderId;
                            g.InsertarOrderDetail(od);
                        });
                    }

                    MessageBox.Show("El order y sus order details se han actualizado correctamente");
                    this.Close();
                }
                // Si no está en modo actualizar se inserta el order y después sus order details
                else
                {
                    using (Gestion g = new Gestion())
                    {
                        g.InsertarOrder(nuevaOrder);

                        orderDetails.ForEach(od =>
                        {
                            od.OrderId = nuevaOrder.OrderId;
                            g.InsertarOrderDetail(od);
                        });
                    }

                    MessageBox.Show("El order y sus order details se han guardado correctamente");
                    this.Close();
                }
            }
            catch (Exception) 
            {
                if (modoActualizar)
                    MessageBox.Show("No se ha podido actualizar el order y sus order details");
                else
                    MessageBox.Show("No se ha podido insertar el order y sus order details");
            }
           
        }

        private void dgvOrderDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvOrderDetails.CurrentCell.RowIndex;
            string nombreColumna = dgvOrderDetails.Columns[e.ColumnIndex].Name;
            
            switch (nombreColumna)
            {
                case "UnitPrice":
                    if ((decimal)dgvOrderDetails.CurrentCell.Value > 0)
                        orderDetails[fila].UnitPrice = (decimal)dgvOrderDetails.CurrentCell.Value;
                    else
                        MessageBox.Show("El valor tiene que ser mayor que 0");
                    break;
                case "Quantity":
                    if ((short)dgvOrderDetails.CurrentCell.Value > 0)
                        orderDetails[fila].Quantity = (short)dgvOrderDetails.CurrentCell.Value;
                    else
                        MessageBox.Show("El valor tiene que ser mayor que 0");
                    break;
                case "Discount":
                    if ((float)dgvOrderDetails.CurrentCell.Value >= 0 && (float)dgvOrderDetails.CurrentCell.Value <= 1)
                        orderDetails[fila].Discount = (float)dgvOrderDetails.CurrentCell.Value;
                    else
                        MessageBox.Show("El valor debe estar comprendido entre 0 y 1");
                    break;
                default: break;
            }
            ActualizarDGVOrderDetails();
            ActualizarResumenFactura(orderDetails);
        }

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOrderDetails.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    orderDetails.RemoveAt(e.RowIndex);
                    ActualizarDGVOrderDetails();
                }
            }
            catch (Exception) 
            {
                // No hacer nada
            }
                
        }

        // Evento que se produce cuando se introduce un tipo incorrecto en una celda del dgvOrderDetails
        private void dgvOrderDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Introduce un valor válido");
        }

        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            dtpOrderDate.Format = DateTimePickerFormat.Short;
        }

        private void dtpRequiredDate_ValueChanged(object sender, EventArgs e)
        {
            dtpRequiredDate.Format = DateTimePickerFormat.Short;
        }

        private void dtpShippedDate_ValueChanged(object sender, EventArgs e)
        {
            dtpShippedDate.Format = DateTimePickerFormat.Short;
        }

        private void btBorrarOrderDate_Click(object sender, EventArgs e)
        {
            Utiles.BorrarFecha(dtpOrderDate);
        }

        private void btRequiredDate_Click(object sender, EventArgs e)
        {
            Utiles.BorrarFecha(dtpRequiredDate);
        }

        private void btShippedDate_Click(object sender, EventArgs e)
        {
            Utiles.BorrarFecha(dtpShippedDate);
        }

        internal void DefinirEmployee(Employee employee)
        {
            this.employee = employee;
        }

        public void DefinirOrder(Order order)
        {
            this.order = order;
        }

        private void dgvOrderDetails_DataSourceChanged(object sender, EventArgs e)
        {
            ActualizarResumenFactura(orderDetails);
        }

        private void btCerrar_Click(object sender, EventArgs e)
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
    }
}
