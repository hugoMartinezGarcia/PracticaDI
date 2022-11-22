namespace Presentacion
{
    partial class FormInsertarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsertarEmpleado));
            this.gbInformacionPersonal = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRegion = new System.Windows.Forms.TextBox();
            this.tbPostalcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTitleCourtesy = new System.Windows.Forms.ComboBox();
            this.mtbHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btBorrarBirthDate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbExtension = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbPhotoPath = new System.Windows.Forms.TextBox();
            this.cbReportsTo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btBorrarHireDate = new System.Windows.Forms.Button();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btBorrarPhoto = new System.Windows.Forms.Button();
            this.btSeleccionarPhoto = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btInsertar = new System.Windows.Forms.Button();
            this.ofdPhoto = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.gbInformacionPersonal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformacionPersonal
            // 
            this.gbInformacionPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformacionPersonal.Controls.Add(this.tableLayoutPanel2);
            this.gbInformacionPersonal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbInformacionPersonal.Location = new System.Drawing.Point(36, 28);
            this.gbInformacionPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInformacionPersonal.Name = "gbInformacionPersonal";
            this.gbInformacionPersonal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInformacionPersonal.Size = new System.Drawing.Size(1195, 250);
            this.gbInformacionPersonal.TabIndex = 2;
            this.gbInformacionPersonal.TabStop = false;
            this.gbInformacionPersonal.Text = "Información personal";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.48619F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbLastName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbTitle, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbFirstName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbAddress, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbCity, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbCountry, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbTitleCourtesy, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.mtbHomePhone, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1189, 232);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "*First name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title of courtesy";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(187, 58);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(327, 21);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.Leave += new System.EventHandler(this.tbLastName_Leave);
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(187, 104);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(327, 21);
            this.tbTitle.TabIndex = 3;
            this.tbTitle.Leave += new System.EventHandler(this.tbTitle_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "*Last name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 46);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 46);
            this.label8.TabIndex = 13;
            this.label8.Text = "City";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 46);
            this.label9.TabIndex = 14;
            this.label9.Text = "Region";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(656, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 46);
            this.label10.TabIndex = 15;
            this.label10.Text = "Country";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(656, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 48);
            this.label11.TabIndex = 16;
            this.label11.Text = "Home phone";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(187, 12);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(327, 21);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Leave += new System.EventHandler(this.tbFirstName_Leave);
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(846, 12);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(323, 21);
            this.tbAddress.TabIndex = 6;
            this.tbAddress.Leave += new System.EventHandler(this.tbAddress_Leave);
            // 
            // tbCity
            // 
            this.tbCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCity.Location = new System.Drawing.Point(846, 58);
            this.tbCity.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(323, 21);
            this.tbCity.TabIndex = 7;
            this.tbCity.Leave += new System.EventHandler(this.tbCity_Leave);
            // 
            // tbCountry
            // 
            this.tbCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCountry.Location = new System.Drawing.Point(846, 150);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(323, 21);
            this.tbCountry.TabIndex = 91;
            this.tbCountry.Leave += new System.EventHandler(this.tbCountry_Leave);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbRegion, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbPostalcode, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(846, 94);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(340, 42);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Postal code";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRegion
            // 
            this.tbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegion.Location = new System.Drawing.Point(3, 10);
            this.tbRegion.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbRegion.Name = "tbRegion";
            this.tbRegion.Size = new System.Drawing.Size(79, 21);
            this.tbRegion.TabIndex = 8;
            this.tbRegion.Leave += new System.EventHandler(this.tbRegion_Leave);
            // 
            // tbPostalcode
            // 
            this.tbPostalcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostalcode.Location = new System.Drawing.Point(241, 10);
            this.tbPostalcode.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbPostalcode.Name = "tbPostalcode";
            this.tbPostalcode.Size = new System.Drawing.Size(79, 21);
            this.tbPostalcode.TabIndex = 9;
            this.tbPostalcode.Leave += new System.EventHandler(this.tbPostalcode_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 48);
            this.label6.TabIndex = 10;
            this.label6.Text = "Birth date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTitleCourtesy
            // 
            this.cbTitleCourtesy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbTitleCourtesy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitleCourtesy.FormattingEnabled = true;
            this.cbTitleCourtesy.ItemHeight = 15;
            this.cbTitleCourtesy.Location = new System.Drawing.Point(187, 149);
            this.cbTitleCourtesy.Name = "cbTitleCourtesy";
            this.cbTitleCourtesy.Size = new System.Drawing.Size(173, 23);
            this.cbTitleCourtesy.TabIndex = 4;
            // 
            // mtbHomePhone
            // 
            this.mtbHomePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbHomePhone.Location = new System.Drawing.Point(846, 197);
            this.mtbHomePhone.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.mtbHomePhone.Mask = "000000000999";
            this.mtbHomePhone.Name = "mtbHomePhone";
            this.mtbHomePhone.Size = new System.Drawing.Size(323, 21);
            this.mtbHomePhone.TabIndex = 92;
            this.mtbHomePhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbHomePhone_MaskInputRejected);
            this.mtbHomePhone.Leave += new System.EventHandler(this.mtbHomePhone_Leave);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.75581F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.24419F));
            this.tableLayoutPanel6.Controls.Add(this.dtpBirthDate, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btBorrarBirthDate, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(187, 187);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(344, 42);
            this.tableLayoutPanel6.TabIndex = 24;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBirthDate.CustomFormat = "";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(3, 10);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.dtpBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(272, 21);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            this.dtpBirthDate.Leave += new System.EventHandler(this.dtpBirthDate_Leave);
            // 
            // btBorrarBirthDate
            // 
            this.btBorrarBirthDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btBorrarBirthDate.Image = global::Presentacion.Properties.Resources.iconoBorrar;
            this.btBorrarBirthDate.Location = new System.Drawing.Point(298, 5);
            this.btBorrarBirthDate.Name = "btBorrarBirthDate";
            this.btBorrarBirthDate.Size = new System.Drawing.Size(31, 31);
            this.btBorrarBirthDate.TabIndex = 6;
            this.btBorrarBirthDate.UseVisualStyleBackColor = true;
            this.btBorrarBirthDate.Click += new System.EventHandler(this.btBorrarBirthDate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(36, 305);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1195, 200);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información laboral";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 182);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.42391F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.57609F));
            this.tableLayoutPanel4.Controls.Add(this.tbExtension, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbPhotoPath, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.cbReportsTo, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(529, 178);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tbExtension
            // 
            this.tbExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExtension.Location = new System.Drawing.Point(179, 55);
            this.tbExtension.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbExtension.Name = "tbExtension";
            this.tbExtension.Size = new System.Drawing.Size(330, 21);
            this.tbExtension.TabIndex = 94;
            this.tbExtension.Leave += new System.EventHandler(this.tbExtension_Leave);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 46);
            this.label17.TabIndex = 5;
            this.label17.Text = "Photo path";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 44);
            this.label14.TabIndex = 2;
            this.label14.Text = "Hire date";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 44);
            this.label15.TabIndex = 3;
            this.label15.Text = "Extension";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 44);
            this.label16.TabIndex = 4;
            this.label16.Text = "Reports to";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPhotoPath
            // 
            this.tbPhotoPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhotoPath.Location = new System.Drawing.Point(179, 144);
            this.tbPhotoPath.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbPhotoPath.Name = "tbPhotoPath";
            this.tbPhotoPath.Size = new System.Drawing.Size(330, 21);
            this.tbPhotoPath.TabIndex = 96;
            this.tbPhotoPath.Leave += new System.EventHandler(this.tbPhotoPath_Leave);
            // 
            // cbReportsTo
            // 
            this.cbReportsTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbReportsTo.FormattingEnabled = true;
            this.cbReportsTo.Location = new System.Drawing.Point(179, 98);
            this.cbReportsTo.Name = "cbReportsTo";
            this.cbReportsTo.Size = new System.Drawing.Size(178, 23);
            this.cbReportsTo.TabIndex = 95;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.87896F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.12104F));
            this.tableLayoutPanel9.Controls.Add(this.btBorrarHireDate, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.dtpHireDate, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(179, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(347, 38);
            this.tableLayoutPanel9.TabIndex = 17;
            // 
            // btBorrarHireDate
            // 
            this.btBorrarHireDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btBorrarHireDate.Image = global::Presentacion.Properties.Resources.iconoBorrar;
            this.btBorrarHireDate.Location = new System.Drawing.Point(300, 3);
            this.btBorrarHireDate.Name = "btBorrarHireDate";
            this.btBorrarHireDate.Size = new System.Drawing.Size(31, 31);
            this.btBorrarHireDate.TabIndex = 9;
            this.btBorrarHireDate.UseVisualStyleBackColor = true;
            this.btBorrarHireDate.Click += new System.EventHandler(this.btBorrarHireDate_Click);
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHireDate.CustomFormat = "";
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(3, 8);
            this.dtpHireDate.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.dtpHireDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(274, 21);
            this.dtpHireDate.TabIndex = 93;
            this.dtpHireDate.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpHireDate.ValueChanged += new System.EventHandler(this.dtpHireDate_ValueChanged);
            this.dtpHireDate.Leave += new System.EventHandler(this.dtpHireDate_Leave);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.56F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.44F));
            this.tableLayoutPanel5.Controls.Add(this.label19, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbNotes, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.pbPhoto, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(656, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.7191F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.2809F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(530, 178);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(191, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(336, 44);
            this.label19.TabIndex = 11;
            this.label19.Text = "Notes";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNotes
            // 
            this.tbNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNotes.Location = new System.Drawing.Point(191, 46);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(319, 130);
            this.tbNotes.TabIndex = 97;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPhoto.Location = new System.Drawing.Point(15, 46);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(15, 2, 15, 2);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(158, 130);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 13;
            this.pbPhoto.TabStop = false;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.62637F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.37363F));
            this.tableLayoutPanel10.Controls.Add(this.btBorrarPhoto, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.btSeleccionarPhoto, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(182, 38);
            this.tableLayoutPanel10.TabIndex = 98;
            // 
            // btBorrarPhoto
            // 
            this.btBorrarPhoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btBorrarPhoto.Image = global::Presentacion.Properties.Resources.iconoBorrar;
            this.btBorrarPhoto.Location = new System.Drawing.Point(137, 3);
            this.btBorrarPhoto.Name = "btBorrarPhoto";
            this.btBorrarPhoto.Size = new System.Drawing.Size(31, 31);
            this.btBorrarPhoto.TabIndex = 19;
            this.btBorrarPhoto.UseVisualStyleBackColor = true;
            this.btBorrarPhoto.Click += new System.EventHandler(this.btBorrarPhoto_Click);
            // 
            // btSeleccionarPhoto
            // 
            this.btSeleccionarPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btSeleccionarPhoto.Location = new System.Drawing.Point(3, 7);
            this.btSeleccionarPhoto.Name = "btSeleccionarPhoto";
            this.btSeleccionarPhoto.Size = new System.Drawing.Size(128, 23);
            this.btSeleccionarPhoto.TabIndex = 18;
            this.btSeleccionarPhoto.Text = "Seleccionar photo";
            this.btSeleccionarPhoto.UseVisualStyleBackColor = true;
            this.btSeleccionarPhoto.Click += new System.EventHandler(this.btSeleccionarPhoto_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrar.Location = new System.Drawing.Point(1146, 595);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(82, 22);
            this.btCerrar.TabIndex = 20;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btInsertar
            // 
            this.btInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btInsertar.Location = new System.Drawing.Point(1038, 595);
            this.btInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(82, 22);
            this.btInsertar.TabIndex = 19;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // ofdPhoto
            // 
            this.ofdPhoto.FileName = "openFileDialog1";
            this.ofdPhoto.Title = "Photo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.62791F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.37209F));
            this.tableLayoutPanel7.Controls.Add(this.dateTimePicker1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 38);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 23);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(176, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 36);
            this.button1.TabIndex = 6;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.62791F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.37209F));
            this.tableLayoutPanel8.Controls.Add(this.dateTimePicker2, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 38);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 23);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(176, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 36);
            this.button2.TabIndex = 6;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormInsertarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCerrar;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.ControlBox = false;
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.gbInformacionPersonal);
            this.Location = new System.Drawing.Point(0, 70);
            this.MinimizeBox = false;
            this.Name = "FormInsertarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormInsertarEmpleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInsertarEmpleado_Load);
            this.gbInformacionPersonal.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbInformacionPersonal;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox tbLastName;
        private TextBox tbTitle;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbFirstName;
        private TextBox tbAddress;
        private TextBox tbCity;
        private TextBox tbCountry;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label12;
        private TextBox tbRegion;
        private TextBox tbPostalcode;
        private Label label6;
        private DateTimePicker dtpBirthDate;
        private ComboBox cbTitleCourtesy;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label17;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox tbExtension;
        private TextBox tbPhotoPath;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label19;
        private TextBox tbNotes;
        private PictureBox pbPhoto;
        private Button btCerrar;
        private Button btInsertar;
        private ComboBox cbReportsTo;
        private OpenFileDialog ofdPhoto;
        private MaskedTextBox mtbHomePhone;
        private ErrorProvider errorProvider1;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btBorrarBirthDate;
        private TableLayoutPanel tableLayoutPanel7;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel8;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel9;
        private DateTimePicker dtpHireDate;
        private Button btBorrarHireDate;
        private TableLayoutPanel tableLayoutPanel10;
        private Button btBorrarPhoto;
        private Button btSeleccionarPhoto;
    }
}