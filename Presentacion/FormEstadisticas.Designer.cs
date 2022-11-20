namespace Presentacion
{
    partial class FormEstadisticas
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
            this.tcEstadisticas = new System.Windows.Forms.TabControl();
            this.tpPedidosCliente = new System.Windows.Forms.TabPage();
            this.tpProductosCategoria = new System.Windows.Forms.TabPage();
            this.tcEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcEstadisticas
            // 
            this.tcEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcEstadisticas.Controls.Add(this.tpPedidosCliente);
            this.tcEstadisticas.Controls.Add(this.tpProductosCategoria);
            this.tcEstadisticas.Location = new System.Drawing.Point(12, 12);
            this.tcEstadisticas.Name = "tcEstadisticas";
            this.tcEstadisticas.SelectedIndex = 0;
            this.tcEstadisticas.Size = new System.Drawing.Size(1240, 737);
            this.tcEstadisticas.TabIndex = 0;
            // 
            // tpPedidosCliente
            // 
            this.tpPedidosCliente.Location = new System.Drawing.Point(4, 24);
            this.tpPedidosCliente.Name = "tpPedidosCliente";
            this.tpPedidosCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpPedidosCliente.Size = new System.Drawing.Size(1232, 709);
            this.tpPedidosCliente.TabIndex = 0;
            this.tpPedidosCliente.Text = "Total pedidos por cliente";
            this.tpPedidosCliente.UseVisualStyleBackColor = true;

            // 
            // tpProductosCategoria
            // 
            this.tpProductosCategoria.Location = new System.Drawing.Point(4, 24);
            this.tpProductosCategoria.Name = "tpProductosCategoria";
            this.tpProductosCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tpProductosCategoria.Size = new System.Drawing.Size(1232, 709);
            this.tpProductosCategoria.TabIndex = 1;
            this.tpProductosCategoria.Text = "Total productos por categoría";
            this.tpProductosCategoria.UseVisualStyleBackColor = true;
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.tcEstadisticas);
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tcEstadisticas.ResumeLayout(false);
            this.ResumeLayout(false);

            // Gráfico 1
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(167, 56);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(339, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            this.tpPedidosCliente.Controls.Add(this.chart1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

            // Gráfico 2
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea2";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend2";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(167, 56);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend2";
            series2.Name = "Series2";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(339, 300);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            this.tpProductosCategoria.Controls.Add(this.chart2);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcEstadisticas;
        private TabPage tpPedidosCliente;
        private TabPage tpProductosCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;

    }
}