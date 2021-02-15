
namespace Measurements_App
{
    partial class MeasurementsWindow
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddMeasure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(361, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddMeasure
            // 
            this.btnAddMeasure.AutoSize = true;
            this.btnAddMeasure.Location = new System.Drawing.Point(48, 434);
            this.btnAddMeasure.Name = "btnAddMeasure";
            this.btnAddMeasure.Size = new System.Drawing.Size(107, 23);
            this.btnAddMeasure.TabIndex = 1;
            this.btnAddMeasure.Text = "Dodaj nowy pomiar";
            this.btnAddMeasure.UseVisualStyleBackColor = true;
            this.btnAddMeasure.Click += new System.EventHandler(this.btnAddMeasure_Click);
            // 
            // MeasurementsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 492);
            this.Controls.Add(this.btnAddMeasure);
            this.Controls.Add(this.btnClose);
            this.Name = "MeasurementsWindow";
            this.Text = "Pomiary ciała";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddMeasure;
    }
}