
namespace Measurements_App
{
    partial class SquatChartWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartSquat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSquat)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSquat
            // 
            chartArea2.AxisX.LogarithmBase = 2D;
            chartArea2.AxisX.Title = "Czas";
            chartArea2.AxisY.Title = "Obciążenie[kg]";
            chartArea2.Name = "ChartArea1";
            this.chartSquat.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSquat.Legends.Add(legend2);
            this.chartSquat.Location = new System.Drawing.Point(12, 12);
            this.chartSquat.Name = "chartSquat";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Obciążenie";
            this.chartSquat.Series.Add(series2);
            this.chartSquat.Size = new System.Drawing.Size(780, 380);
            this.chartSquat.TabIndex = 1;
            this.chartSquat.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Zmiany w obciążeniu - przysiady ze sztangą";
            this.chartSquat.Titles.Add(title2);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(717, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SquatChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chartSquat);
            this.Name = "SquatChartForm";
            this.Text = "Wykres";
            this.Load += new System.EventHandler(this.SquatChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSquat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSquat;
        private System.Windows.Forms.Button btnClose;
    }
}