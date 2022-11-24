using System.Windows.Forms.DataVisualization.Charting;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tcEstadisticas = new System.Windows.Forms.TabControl();
            this.tpPedidosCliente = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tpProductosCategoria = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tcEstadisticas.SuspendLayout();
            this.tpPedidosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tpProductosCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcEstadisticas
            // 
            this.tcEstadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEstadisticas.Controls.Add(this.tpPedidosCliente);
            this.tcEstadisticas.Controls.Add(this.tpProductosCategoria);
            this.tcEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.tcEstadisticas.Name = "tcEstadisticas";
            this.tcEstadisticas.SelectedIndex = 0;
            this.tcEstadisticas.Size = new System.Drawing.Size(1264, 761);
            this.tcEstadisticas.TabIndex = 0;
            // 
            // tpPedidosCliente
            // 
            this.tpPedidosCliente.Controls.Add(this.chart1);
            this.tpPedidosCliente.Location = new System.Drawing.Point(4, 22);
            this.tpPedidosCliente.Name = "tpPedidosCliente";
            this.tpPedidosCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpPedidosCliente.Size = new System.Drawing.Size(1256, 735);
            this.tpPedidosCliente.TabIndex = 0;
            this.tpPedidosCliente.Text = "Total pedidos por cliente";
            this.tpPedidosCliente.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Title = "Clientes";
            chartArea1.AxisY.Title = "Pedidos";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Column;
            series1.Legend = "Legend1";
            series1.Name = "Nº pedidos";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1250, 729);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tpProductosCategoria
            // 
            this.tpProductosCategoria.Controls.Add(this.chart2);
            this.tpProductosCategoria.Location = new System.Drawing.Point(4, 22);
            this.tpProductosCategoria.Name = "tpProductosCategoria";
            this.tpProductosCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tpProductosCategoria.Size = new System.Drawing.Size(1256, 735);
            this.tpProductosCategoria.TabIndex = 1;
            this.tpProductosCategoria.Text = "Total productos por categoría";
            this.tpProductosCategoria.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            //legend2.Name = "Legend1";
            //this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            //series2.Legend = "Legend1";
            series2.Name = "Categorias";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1250, 729);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
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
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.tcEstadisticas.ResumeLayout(false);
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