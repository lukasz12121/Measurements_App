
namespace Measurements_App
{
    partial class DeadLiftChartWindow
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
            this.chartDeadLift = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeadLift)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDeadLift
            // 
            chartArea1.AxisX.LogarithmBase = 2D;
            chartArea1.AxisX.Title = "Czas";
            chartArea1.AxisY.Title = "Obciążenie[kg]";
            chartArea1.Name = "ChartArea1";
            this.chartDeadLift.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDeadLift.Legends.Add(legend1);
            this.chartDeadLift.Location = new System.Drawing.Point(12, 12);
            this.chartDeadLift.Name = "chartDeadLift";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Obciążenie";
            this.chartDeadLift.Series.Add(series1);
            this.chartDeadLift.Size = new System.Drawing.Size(780, 380);
            this.chartDeadLift.TabIndex = 1;
            this.chartDeadLift.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Zmiany w obciążeniu - martwy ciąg";
            this.chartDeadLift.Titles.Add(title1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DeadLiftChartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chartDeadLift);
            this.Name = "DeadLiftChartWindow";
            this.Text = "Wykres";
            this.Load += new System.EventHandler(this.DeadLiftChartWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDeadLift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDeadLift;
        private System.Windows.Forms.Button btnClose;
    }
}