namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPedidosPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosPorCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInsertarEmpleado = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevoPedido = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimirFactura = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEmpleados,
            this.tsmProductos,
            this.tsmPedidos,
            this.tsmEstadisticas,
            this.tsmInformes,
            this.tsmAcercaDe,
            this.tsmSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmEmpleados
            // 
            this.tsmEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.tsmEmpleados.Name = "tsmEmpleados";
            this.tsmEmpleados.Size = new System.Drawing.Size(77, 20);
            this.tsmEmpleados.Text = "Empleados";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.insertarToolStripMenuItem.Text = "Insertar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // tsmProductos
            // 
            this.tsmProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarPrecioToolStripMenuItem});
            this.tsmProductos.Name = "tsmProductos";
            this.tsmProductos.Size = new System.Drawing.Size(73, 20);
            this.tsmProductos.Text = "Productos";
            // 
            // modificarPrecioToolStripMenuItem
            // 
            this.modificarPrecioToolStripMenuItem.Name = "modificarPrecioToolStripMenuItem";
            this.modificarPrecioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modificarPrecioToolStripMenuItem.Text = "Modificar precio";
            // 
            // tsmPedidos
            // 
            this.tsmPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem1});
            this.tsmPedidos.Name = "tsmPedidos";
            this.tsmPedidos.Size = new System.Drawing.Size(61, 20);
            this.tsmPedidos.Text = "Pedidos";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // tsmEstadisticas
            // 
            this.tsmEstadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalPedidosPorClienteToolStripMenuItem,
            this.productosPorCategoríaToolStripMenuItem});
            this.tsmEstadisticas.Name = "tsmEstadisticas";
            this.tsmEstadisticas.Size = new System.Drawing.Size(79, 20);
            this.tsmEstadisticas.Text = "Estadísticas";
            // 
            // totalPedidosPorClienteToolStripMenuItem
            // 
            this.totalPedidosPorClienteToolStripMenuItem.Name = "totalPedidosPorClienteToolStripMenuItem";
            this.totalPedidosPorClienteToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.totalPedidosPorClienteToolStripMenuItem.Text = "Total pedidos por cliente";
            // 
            // productosPorCategoríaToolStripMenuItem
            // 
            this.productosPorCategoríaToolStripMenuItem.Name = "productosPorCategoríaToolStripMenuItem";
            this.productosPorCategoríaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.productosPorCategoríaToolStripMenuItem.Text = "Productos por categoría";
            // 
            // tsmInformes
            // 
            this.tsmInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem});
            this.tsmInformes.Name = "tsmInformes";
            this.tsmInformes.Size = new System.Drawing.Size(66, 20);
            this.tsmInformes.Text = "Informes";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // tsmAcercaDe
            // 
            this.tsmAcercaDe.Name = "tsmAcercaDe";
            this.tsmAcercaDe.Size = new System.Drawing.Size(83, 20);
            this.tsmAcercaDe.Text = "Acerca de ...";
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(41, 20);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertarEmpleado,
            this.tsbNuevoPedido,
            this.tsbImprimirFactura,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1280, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbInsertarEmpleado
            // 
            this.tsbInsertarEmpleado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbInsertarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertarEmpleado.Image")));
            this.tsbInsertarEmpleado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertarEmpleado.Name = "tsbInsertarEmpleado";
            this.tsbInsertarEmpleado.Size = new System.Drawing.Size(106, 22);
            this.tsbInsertarEmpleado.Text = "Insertar empleado";
            // 
            // tsbNuevoPedido
            // 
            this.tsbNuevoPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNuevoPedido.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevoPedido.Image")));
            this.tsbNuevoPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoPedido.Name = "tsbNuevoPedido";
            this.tsbNuevoPedido.Size = new System.Drawing.Size(86, 22);
            this.tsbNuevoPedido.Text = "Nuevo pedido";
            // 
            // tsbImprimirFactura
            // 
            this.tsbImprimirFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbImprimirFactura.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimirFactura.Image")));
            this.tsbImprimirFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimirFactura.Name = "tsbImprimirFactura";
            this.tsbImprimirFactura.Size = new System.Drawing.Size(97, 22);
            this.tsbImprimirFactura.Text = "Imprimir factura";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(110, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 900);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmEmpleados;
        private ToolStripMenuItem insertarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem tsmProductos;
        private ToolStripMenuItem modificarPrecioToolStripMenuItem;
        private ToolStripMenuItem tsmPedidos;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private ToolStripMenuItem tsmEstadisticas;
        private ToolStripMenuItem totalPedidosPorClienteToolStripMenuItem;
        private ToolStripMenuItem productosPorCategoríaToolStripMenuItem;
        private ToolStripMenuItem tsmInformes;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem tsmAcercaDe;
        private ToolStripMenuItem tsmSalir;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbInsertarEmpleado;
        private ToolStripButton tsbNuevoPedido;
        private ToolStripButton tsbImprimirFactura;
        private ToolStripLabel toolStripButton1;
    }
}