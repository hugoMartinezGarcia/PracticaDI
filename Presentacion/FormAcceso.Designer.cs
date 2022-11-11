namespace Presentacion
{
    partial class FormAcceso
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
            this.lbEmployee = new System.Windows.Forms.Label();
            this.btAcceder = new System.Windows.Forms.Button();
            this.tbIdEmployee = new System.Windows.Forms.TextBox();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEmployee
            // 
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmployee.Location = new System.Drawing.Point(30, 89);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(78, 18);
            this.lbEmployee.TabIndex = 2;
            this.lbEmployee.Text = "Empleado";
            // 
            // btAcceder
            // 
            this.btAcceder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAcceder.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btAcceder.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAcceder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btAcceder.Location = new System.Drawing.Point(30, 330);
            this.btAcceder.Name = "btAcceder";
            this.btAcceder.Size = new System.Drawing.Size(269, 32);
            this.btAcceder.TabIndex = 2;
            this.btAcceder.Text = "Acceder";
            this.btAcceder.UseVisualStyleBackColor = false;
            this.btAcceder.Click += new System.EventHandler(this.btAcceder_Click);
            // 
            // tbIdEmployee
            // 
            this.tbIdEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdEmployee.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbIdEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdEmployee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIdEmployee.Location = new System.Drawing.Point(30, 279);
            this.tbIdEmployee.Name = "tbIdEmployee";
            this.tbIdEmployee.PasswordChar = '*';
            this.tbIdEmployee.Size = new System.Drawing.Size(269, 19);
            this.tbIdEmployee.TabIndex = 1;
            // 
            // lbEmployees
            // 
            this.lbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployees.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 17;
            this.lbEmployees.Location = new System.Drawing.Point(30, 110);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(269, 119);
            this.lbEmployees.TabIndex = 6;
            this.lbEmployees.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBox1_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID del Empleado";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bienvenido";
            // 
            // FormAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(330, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEmployees);
            this.Controls.Add(this.tbIdEmployee);
            this.Controls.Add(this.btAcceder);
            this.Controls.Add(this.lbEmployee);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAcceso";
            this.Text = "FormAcceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbEmployee;
        private Button btAcceder;
        private TextBox tbIdEmployee;
        private ListBox lbEmployees;
        private Label label1;
        private Label label2;
    }
}