
namespace Measurements_App
{
    partial class BenchChartForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnClose = new System.Windows.Forms.Button();
            this.chartBench = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBench)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(717, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chartBench
            // 
            chartArea1.AxisX.LogarithmBase = 2D;
            chartArea1.AxisX.Title = "Czas";
            chartArea1.AxisY.Title = "Obciążenie[kg]";
            chartArea1.Name = "ChartArea1";
            this.chartBench.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBench.Legends.Add(legend1);
            this.chartBench.Location = new System.Drawing.Point(12, 12);
            this.chartBench.Name = "chartBench";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Obciążenie";
            this.chartBench.Series.Add(series1);
            this.chartBench.Size = new System.Drawing.Size(780, 380);
            this.chartBench.TabIndex = 2;
            this.chartBench.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Zmiany w obciążeniu - wyciskanie na klatkę";
            this.chartBench.Titles.Add(title1);
            // 
            // BenchChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.chartBench);
            this.Controls.Add(this.btnClose);
            this.Name = "BenchChartForm";
            this.Text = "Wykres";
            this.Load += new System.EventHandler(this.BenchChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBench)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBench;
    }
}