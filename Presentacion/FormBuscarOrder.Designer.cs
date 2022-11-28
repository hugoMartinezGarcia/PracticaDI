namespace Presentacion
{
    partial class FormBuscarOrder
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lbOrders = new System.Windows.Forms.Label();
            this.gbOrderDate = new System.Windows.Forms.GroupBox();
            this.btBorrarOrderDate = new System.Windows.Forms.Button();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lbDataGridView = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscarCustomer = new System.Windows.Forms.TextBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btBorrarSeleccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.gbOrderDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(647, 299);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 25;
            this.dgvOrders.Size = new System.Drawing.Size(561, 362);
            this.dgvOrders.TabIndex = 17;
            this.dgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick);
            // 
            // lbOrders
            // 
            this.lbOrders.AutoSize = true;
            this.lbOrders.Location = new System.Drawing.Point(647, 281);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(42, 15);
            this.lbOrders.TabIndex = 16;
            this.lbOrders.Text = "Orders";
            // 
            // gbOrderDate
            // 
            this.gbOrderDate.Controls.Add(this.btBorrarOrderDate);
            this.gbOrderDate.Controls.Add(this.dtpOrderDate);
            this.gbOrderDate.Controls.Add(this.label2);
            this.gbOrderDate.Location = new System.Drawing.Point(57, 148);
            this.gbOrderDate.Name = "gbOrderDate";
            this.gbOrderDate.Size = new System.Drawing.Size(559, 93);
            this.gbOrderDate.TabIndex = 15;
            this.gbOrderDate.TabStop = false;
            this.gbOrderDate.Text = "Buscar order date";
            // 
            // btBorrarOrderDate
            // 
            this.btBorrarOrderDate.Image = global::Presentacion.Properties.Resources.iconoBorrar;
            this.btBorrarOrderDate.Location = new System.Drawing.Point(195, 42);
            this.btBorrarOrderDate.Name = "btBorrarOrderDate";
            this.btBorrarOrderDate.Size = new System.Drawing.Size(31, 31);
            this.btBorrarOrderDate.TabIndex = 6;
            this.btBorrarOrderDate.UseVisualStyleBackColor = true;
            this.btBorrarOrderDate.Click += new System.EventHandler(this.btBorrarOrderDate_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(20, 47);
            this.dtpOrderDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(147, 23);
            this.dtpOrderDate.TabIndex = 5;
            this.dtpOrderDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introduzca un order date";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(57, 297);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.Size = new System.Drawing.Size(538, 364);
            this.dgvCustomers.TabIndex = 20;
            this.dgvCustomers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellEnter);
            // 
            // lbDataGridView
            // 
            this.lbDataGridView.AutoSize = true;
            this.lbDataGridView.Location = new System.Drawing.Point(57, 279);
            this.lbDataGridView.Name = "lbDataGridView";
            this.lbDataGridView.Size = new System.Drawing.Size(265, 15);
            this.lbDataGridView.TabIndex = 19;
            this.lbDataGridView.Text = "* Haga click sobre el customer para seleccionarlo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbBuscarCustomer);
            this.groupBox1.Location = new System.Drawing.Point(57, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 93);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Intoduzca un Customer Id, company name o contact name";
            // 
            // tbBuscarCustomer
            // 
            this.tbBuscarCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarCustomer.Location = new System.Drawing.Point(20, 47);
            this.tbBuscarCustomer.Name = "tbBuscarCustomer";
            this.tbBuscarCustomer.Size = new System.Drawing.Size(353, 23);
            this.tbBuscarCustomer.TabIndex = 5;
            this.tbBuscarCustomer.TextChanged += new System.EventHandler(this.tbBuscarCustomer_TextChanged);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(1133, 698);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 21;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btBorrarSeleccion
            // 
            this.btBorrarSeleccion.Image = global::Presentacion.Properties.Resources.iconoBorrar;
            this.btBorrarSeleccion.Location = new System.Drawing.Point(564, 265);
            this.btBorrarSeleccion.Name = "btBorrarSeleccion";
            this.btBorrarSeleccion.Size = new System.Drawing.Size(31, 31);
            this.btBorrarSeleccion.TabIndex = 7;
            this.btBorrarSeleccion.UseVisualStyleBackColor = true;
            this.btBorrarSeleccion.Click += new System.EventHandler(this.btBorrarSeleccion_Click);
            // 
            // FormBuscarOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.btBorrarSeleccion);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.lbDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.gbOrderDate);
            this.Name = "FormBuscarOrder";
            this.Text = "FormBuscarOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBuscarOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.gbOrderDate.ResumeLayout(false);
            this.gbOrderDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOrders;
        private Label lbOrders;
        private GroupBox gbOrderDate;
        private Button btBorrarOrderDate;
        private DateTimePicker dtpOrderDate;
        private Label label2;
        private DataGridView dgvCustomers;
        private Label lbDataGridView;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbBuscarCustomer;
        private Button btCerrar;
        private Button btBorrarSeleccion;
    }
}