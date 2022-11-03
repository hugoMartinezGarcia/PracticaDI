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
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.lbIdEmployee = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbEmployee
            // 
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmployee.Location = new System.Drawing.Point(47, 129);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(61, 15);
            this.lbEmployee.TabIndex = 2;
            this.lbEmployee.Text = "Empleado";
            // 
            // btAcceder
            // 
            this.btAcceder.Location = new System.Drawing.Point(47, 296);
            this.btAcceder.Name = "btAcceder";
            this.btAcceder.Size = new System.Drawing.Size(191, 28);
            this.btAcceder.TabIndex = 3;
            this.btAcceder.Text = "Acceder";
            this.btAcceder.UseVisualStyleBackColor = true;
            this.btAcceder.Click += new System.EventHandler(this.btAcceder_Click);
            // 
            // tbEmployee
            // 
            this.tbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmployee.Location = new System.Drawing.Point(47, 226);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Size = new System.Drawing.Size(191, 23);
            this.tbEmployee.TabIndex = 4;
            // 
            // lbIdEmployee
            // 
            this.lbIdEmployee.AutoSize = true;
            this.lbIdEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIdEmployee.Location = new System.Drawing.Point(47, 208);
            this.lbIdEmployee.Name = "lbIdEmployee";
            this.lbIdEmployee.Size = new System.Drawing.Size(98, 15);
            this.lbIdEmployee.TabIndex = 5;
            this.lbIdEmployee.Text = "ID del empleado";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(47, 147);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(191, 23);
            this.cbEmployee.TabIndex = 6;
            this.cbEmployee.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbEmployee_Format);
            // 
            // FormAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 371);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.lbIdEmployee);
            this.Controls.Add(this.tbEmployee);
            this.Controls.Add(this.btAcceder);
            this.Controls.Add(this.lbEmployee);
            this.Name = "FormAcceso";
            this.Text = "FormAcceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbEmployee;
        private Button btAcceder;
        private TextBox tbEmployee;
        private Label lbIdEmployee;
        private ComboBox cbEmployee;
    }
}