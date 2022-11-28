namespace Presentacion
{
    partial class FormPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlpOrder = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btShippedDate = new System.Windows.Forms.Button();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btRequiredDate = new System.Windows.Forms.Button();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btEditarCustomer = new System.Windows.Forms.Button();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.btBorrarCustomer = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tbShipCountry = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbShipPostalCode = new System.Windows.Forms.TextBox();
            this.tbShipRegion = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbShipCity = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbShipName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFreight = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbShipVia = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbEmployeeId = new System.Windows.Forms.Label();
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btBorrarOrderDate = new System.Windows.Forms.Button();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbIVA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbBuscarProducts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.tlpOrder.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tlpOrder);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1223, 257);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del pedido";
            // 
            // tlpOrder
            // 
            this.tlpOrder.ColumnCount = 5;
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.11586F));
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.32539F));
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36565F));
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tlpOrder.Controls.Add(this.tableLayoutPanel9, 1, 4);
            this.tlpOrder.Controls.Add(this.tableLayoutPanel8, 1, 3);
            this.tlpOrder.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tlpOrder.Controls.Add(this.label20, 3, 5);
            this.tlpOrder.Controls.Add(this.tbShipCountry, 4, 5);
            this.tlpOrder.Controls.Add(this.label19, 3, 4);
            this.tlpOrder.Controls.Add(this.tableLayoutPanel4, 4, 4);
            this.tlpOrder.Controls.Add(this.label17, 3, 3);
            this.tlpOrder.Controls.Add(this.tbShipCity, 4, 3);
            this.tlpOrder.Controls.Add(this.label25, 3, 2);
            this.tlpOrder.Controls.Add(this.tbShipAddress, 4, 2);
            this.tlpOrder.Controls.Add(this.label18, 3, 1);
            this.tlpOrder.Controls.Add(this.tbShipName, 4, 1);
            this.tlpOrder.Controls.Add(this.tableLayoutPanel5, 1, 5);
            this.tlpOrder.Controls.Add(this.label15, 0, 2);
            this.tlpOrder.Controls.Add(this.label14, 0, 3);
            this.tlpOrder.Controls.Add(this.label13, 0, 4);
            this.tlpOrder.Controls.Add(this.label22, 0, 5);
            this.tlpOrder.Controls.Add(this.lbEmployeeId, 3, 0);
            this.tlpOrder.Controls.Add(this.tbEmployee, 4, 0);
            this.tlpOrder.Controls.Add(this.label26, 0, 1);
            this.tlpOrder.Controls.Add(this.lbOrderId, 0, 0);
            this.tlpOrder.Controls.Add(this.tbOrderId, 1, 0);
            this.tlpOrder.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tlpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrder.Location = new System.Drawing.Point(3, 18);
            this.tlpOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpOrder.Name = "tlpOrder";
            this.tlpOrder.RowCount = 6;
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOrder.Size = new System.Drawing.Size(1217, 237);
            this.tlpOrder.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.5679F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4321F));
            this.tableLayoutPanel9.Controls.Add(this.btShippedDate, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.dtpShippedDate, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(198, 159);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(324, 33);
            this.tableLayoutPanel9.TabIndex = 36;
            // 
            // btShippedDate
            // 
            this.btShippedDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btShippedDate.Image = global::Presentacion.Properties.Resources.iconoBorrar;
            this.btShippedDate.Location = new System.Drawing.Point(294, 3);
            this.btShippedDate.Name = "btShippedDate";
            this.btShippedDate.Size = new System.Drawing.Size(27, 27);
            this.btShippedDate.TabIndex = 2;
            this.btShippedDate.UseVisualStyleBackColor = true;
            this.btShippedDate.Click += new System.EventHandler(this.btShippedDate_Click);
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShippedDate.Location = new System.Drawing.Point(3, 5);
            this.dtpShippedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpShippedDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(268, 23);
            this.dtpShippedDate.TabIndex = 23;
            this.dtpShippedDate.Value = new System.DateTime(1997, 9, 2, 0, 0, 0, 0);
            this.dtpShippedDate.ValueChanged += new System.EventHandler(this.dtpShippedDate_ValueChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.5679F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4321F));
            this.tableLayoutPanel8.Controls.Add(this.btRequiredDate, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.dtpRequiredDate, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(198, 120);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(324, 33);
            this.tableLayoutPanel8.TabIndex = 35;
            // 
            // btRequiredDate
            // 
            this.btRequiredDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btRequiredDate.Image = global::Presentacion.Properties.Resources.iconoBorrar;
            this.btRequiredDate.Location = new System.Drawing.Point(294, 3);
            this.btRequiredDate.Name = "btRequiredDate";
            this.btRequiredDate.Size = new System.Drawing.Size(27, 27);
            this.btRequiredDate.TabIndex = 2;
            this.btRequiredDate.UseVisualStyleBackColor = true;
            this.btRequiredDate.Click += new System.EventHandler(this.btRequiredDate_Click);
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(3, 5);
            this.dtpRequiredDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpRequiredDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(268, 23);
            this.dtpRequiredDate.TabIndex = 22;
            this.dtpRequiredDate.Value = new System.DateTime(1997, 9, 22, 0, 0, 0, 0);
            this.dtpRequiredDate.ValueChanged += new System.EventHandler(this.dtpRequiredDate_ValueChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.10853F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.89147F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel7.Controls.Add(this.btEditarCustomer, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.tbCustomer, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btBorrarCustomer, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(198, 42);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(324, 33);
            this.tableLayoutPanel7.TabIndex = 33;
            // 
            // btEditarCustomer
            // 
            this.btEditarCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btEditarCustomer.Image = global::Presentacion.Properties.Resources.iconoEditar;
            this.btEditarCustomer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btEditarCustomer.Location = new System.Drawing.Point(245, 3);
            this.btEditarCustomer.Name = "btEditarCustomer";
            this.btEditarCustomer.Size = new System.Drawing.Size(27, 27);
            this.btEditarCustomer.TabIndex = 0;
            this.btEditarCustomer.UseVisualStyleBackColor = true;
            this.btEditarCustomer.Click += new System.EventHandler(this.btEditarCustomer_Click);
            // 
            // tbCustomer
            // 
            this.tbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomer.Location = new System.Drawing.Point(3, 5);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(226, 23);
            this.tbCustomer.TabIndex = 2;
            // 
            // btBorrarCustomer
            // 
            this.btBorrarCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btBorrarCustomer.Image = global::Presentacion.Properties.Resources.iconoBorrar;
            this.btBorrarCustomer.Location = new System.Drawing.Point(294, 3);
            this.btBorrarCustomer.Name = "btBorrarCustomer";
            this.btBorrarCustomer.Size = new System.Drawing.Size(27, 27);
            this.btBorrarCustomer.TabIndex = 1;
            this.btBorrarCustomer.UseVisualStyleBackColor = true;
            this.btBorrarCustomer.Click += new System.EventHandler(this.btBorrarCustomer_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(678, 208);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(181, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "Ship country";
            // 
            // tbShipCountry
            // 
            this.tbShipCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipCountry.Location = new System.Drawing.Point(865, 204);
            this.tbShipCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbShipCountry.Name = "tbShipCountry";
            this.tbShipCountry.Size = new System.Drawing.Size(349, 23);
            this.tbShipCountry.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(678, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(181, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "Ship region";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.57143F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.28572F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.14286F));
            this.tableLayoutPanel4.Controls.Add(this.tbShipPostalCode, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbShipRegion, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label21, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(865, 158);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(349, 35);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // tbShipPostalCode
            // 
            this.tbShipPostalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipPostalCode.Location = new System.Drawing.Point(221, 6);
            this.tbShipPostalCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbShipPostalCode.Name = "tbShipPostalCode";
            this.tbShipPostalCode.Size = new System.Drawing.Size(125, 23);
            this.tbShipPostalCode.TabIndex = 21;
            // 
            // tbShipRegion
            // 
            this.tbShipRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipRegion.Location = new System.Drawing.Point(3, 6);
            this.tbShipRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbShipRegion.Name = "tbShipRegion";
            this.tbShipRegion.Size = new System.Drawing.Size(114, 23);
            this.tbShipRegion.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(123, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 15);
            this.label21.TabIndex = 9;
            this.label21.Text = "S. Postal code";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(678, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(181, 15);
            this.label17.TabIndex = 26;
            this.label17.Text = "Ship city";
            // 
            // tbShipCity
            // 
            this.tbShipCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipCity.Location = new System.Drawing.Point(865, 125);
            this.tbShipCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbShipCity.Name = "tbShipCity";
            this.tbShipCity.Size = new System.Drawing.Size(349, 23);
            this.tbShipCity.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(678, 90);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(181, 15);
            this.label25.TabIndex = 27;
            this.label25.Text = "Ship address";
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipAddress.Location = new System.Drawing.Point(865, 86);
            this.tbShipAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.Size = new System.Drawing.Size(349, 23);
            this.tbShipAddress.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(678, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 15);
            this.label18.TabIndex = 7;
            this.label18.Text = "Ship name";
            // 
            // tbShipName
            // 
            this.tbShipName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShipName.Location = new System.Drawing.Point(865, 47);
            this.tbShipName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbShipName.Name = "tbShipName";
            this.tbShipName.Size = new System.Drawing.Size(349, 23);
            this.tbShipName.TabIndex = 17;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.79012F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.28395F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.61728F));
            this.tableLayoutPanel5.Controls.Add(this.tbFreight, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbShipVia, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label24, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(198, 197);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(324, 38);
            this.tableLayoutPanel5.TabIndex = 24;
            // 
            // tbFreight
            // 
            this.tbFreight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFreight.Location = new System.Drawing.Point(243, 7);
            this.tbFreight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFreight.Name = "tbFreight";
            this.tbFreight.Size = new System.Drawing.Size(78, 23);
            this.tbFreight.TabIndex = 21;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(187, 11);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 15);
            this.label24.TabIndex = 9;
            this.label24.Text = "Freight";
            // 
            // cbShipVia
            // 
            this.cbShipVia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShipVia.FormattingEnabled = true;
            this.cbShipVia.Location = new System.Drawing.Point(3, 7);
            this.cbShipVia.Name = "cbShipVia";
            this.cbShipVia.Size = new System.Drawing.Size(178, 23);
            this.cbShipVia.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Order date";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Required date";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Shipped date";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 208);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(189, 15);
            this.label22.TabIndex = 25;
            this.label22.Text = "Ship via";
            // 
            // lbEmployeeId
            // 
            this.lbEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployeeId.AutoSize = true;
            this.lbEmployeeId.Location = new System.Drawing.Point(678, 12);
            this.lbEmployeeId.Name = "lbEmployeeId";
            this.lbEmployeeId.Size = new System.Drawing.Size(181, 15);
            this.lbEmployeeId.TabIndex = 5;
            this.lbEmployeeId.Text = "Employee ID";
            this.lbEmployeeId.Visible = false;
            // 
            // tbEmployee
            // 
            this.tbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmployee.Location = new System.Drawing.Point(865, 8);
            this.tbEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.ReadOnly = true;
            this.tbEmployee.Size = new System.Drawing.Size(349, 23);
            this.tbEmployee.TabIndex = 11;
            this.tbEmployee.Visible = false;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(189, 15);
            this.label26.TabIndex = 30;
            this.label26.Text = "Customer ID";
            // 
            // lbOrderId
            // 
            this.lbOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(3, 12);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(189, 15);
            this.lbOrderId.TabIndex = 0;
            this.lbOrderId.Text = "Order ID*";
            this.lbOrderId.Visible = false;
            // 
            // tbOrderId
            // 
            this.tbOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbOrderId.Location = new System.Drawing.Point(198, 8);
            this.tbOrderId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.ReadOnly = true;
            this.tbOrderId.Size = new System.Drawing.Size(72, 23);
            this.tbOrderId.TabIndex = 10;
            this.tbOrderId.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.5679F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.4321F));
            this.tableLayoutPanel3.Controls.Add(this.btBorrarOrderDate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpOrderDate, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(198, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(324, 33);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // btBorrarOrderDate
            // 
            this.btBorrarOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btBorrarOrderDate.Image = global::Presentacion.Properties.Resources.iconoBorrar;
            this.btBorrarOrderDate.Location = new System.Drawing.Point(294, 3);
            this.btBorrarOrderDate.Name = "btBorrarOrderDate";
            this.btBorrarOrderDate.Size = new System.Drawing.Size(27, 27);
            this.btBorrarOrderDate.TabIndex = 2;
            this.btBorrarOrderDate.UseVisualStyleBackColor = true;
            this.btBorrarOrderDate.Click += new System.EventHandler(this.btBorrarOrderDate_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(3, 5);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpOrderDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(268, 23);
            this.dtpOrderDate.TabIndex = 21;
            this.dtpOrderDate.Value = new System.DateTime(1997, 8, 25, 0, 0, 0, 0);
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 585);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1223, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen factura";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.tbTotal, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbIVA, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPrecio, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1217, 89);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbTotal.Location = new System.Drawing.Point(1013, 30);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(145, 29);
            this.tbTotal.TabIndex = 5;
            // 
            // tbIVA
            // 
            this.tbIVA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbIVA.Location = new System.Drawing.Point(609, 30);
            this.tbIVA.Name = "tbIVA";
            this.tbIVA.Size = new System.Drawing.Size(145, 29);
            this.tbIVA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio sin IVA";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(563, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "IVA";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(907, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPrecio.Location = new System.Drawing.Point(205, 30);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(145, 29);
            this.tbPrecio.TabIndex = 3;
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvOrderDetails.Location = new System.Drawing.Point(693, 321);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowTemplate.Height = 25;
            this.dgvOrderDetails.Size = new System.Drawing.Size(539, 229);
            this.dgvOrderDetails.TabIndex = 5;
            this.dgvOrderDetails.DataSourceChanged += new System.EventHandler(this.dgvOrderDetails_DataSourceChanged);
            this.dgvOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellClick);
            this.dgvOrderDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellEndEdit);
            this.dgvOrderDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvOrderDetails_DataError);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.iconoBorrar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel6.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(107, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 27);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.Location = new System.Drawing.Point(170, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 27);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(110, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 27);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbBuscarProducts
            // 
            this.tbBuscarProducts.Location = new System.Drawing.Point(15, 321);
            this.tbBuscarProducts.Name = "tbBuscarProducts";
            this.tbBuscarProducts.Size = new System.Drawing.Size(672, 23);
            this.tbBuscarProducts.TabIndex = 6;
            this.tbBuscarProducts.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Products";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Order details";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(18, 350);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(669, 200);
            this.dgvProducts.TabIndex = 9;
            this.dgvProducts.DoubleClick += new System.EventHandler(this.dgvProducts_DoubleClick);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(1045, 714);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(1157, 714);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 11;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBuscarProducts);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Location = new System.Drawing.Point(300, 600);
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.groupBox2.ResumeLayout(false);
            this.tlpOrder.ResumeLayout(false);
            this.tlpOrder.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private TableLayoutPanel tlpOrder;
        private TextBox tbOrderId;
        private Label label20;
        private TextBox tbShipCountry;
        private Label label19;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox tbShipPostalCode;
        private TextBox tbShipRegion;
        private Label label21;
        private Label label17;
        private TextBox tbShipCity;
        private Label label25;
        private TextBox tbShipAddress;
        private Label label18;
        private TextBox tbShipName;
        private Label label22;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox tbFreight;
        private Label label24;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private DateTimePicker dtpShippedDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpOrderDate;
        private TextBox tbEmployee;
        private Label label26;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbTotal;
        private TextBox tbIVA;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbPrecio;
        private DataGridView dgvOrderDetails;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btEditarCustomer;
        private TextBox tbCustomer;
        private Button btBorrarCustomer;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private TextBox tbBuscarProducts;
        private Label label4;
        private Label label5;
        private DataGridView dgvProducts;
        private Button btGuardar;
        private Button btCerrar;
        private DataGridViewImageColumn Eliminar;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btShippedDate;
        private TableLayoutPanel tableLayoutPanel8;
        private Button btRequiredDate;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btBorrarOrderDate;
        private ErrorProvider errorProvider1;
        private Label lbEmployeeId;
        private Label lbOrderId;
        private ComboBox cbShipVia;
    }
}