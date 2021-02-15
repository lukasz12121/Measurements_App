
namespace Measurements_App
{
    partial class Main_window
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBenchPress = new System.Windows.Forms.Button();
            this.btnSquat = new System.Windows.Forms.Button();
            this.btnDeadLift = new System.Windows.Forms.Button();
            this.btnMeasurements = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBenchPress
            // 
            this.btnBenchPress.AutoSize = true;
            this.btnBenchPress.Location = new System.Drawing.Point(120, 76);
            this.btnBenchPress.Name = "btnBenchPress";
            this.btnBenchPress.Size = new System.Drawing.Size(119, 23);
            this.btnBenchPress.TabIndex = 0;
            this.btnBenchPress.Text = "Wyciskanie na klatke";
            this.btnBenchPress.UseVisualStyleBackColor = true;
            this.btnBenchPress.Click += new System.EventHandler(this.btnBenchPress_Click);
            // 
            // btnSquat
            // 
            this.btnSquat.AutoSize = true;
            this.btnSquat.Location = new System.Drawing.Point(139, 119);
            this.btnSquat.Name = "btnSquat";
            this.btnSquat.Size = new System.Drawing.Size(75, 23);
            this.btnSquat.TabIndex = 1;
            this.btnSquat.Text = "Przysiad";
            this.btnSquat.UseVisualStyleBackColor = true;
            this.btnSquat.Click += new System.EventHandler(this.btnSquat_Click);
            // 
            // btnDeadLift
            // 
            this.btnDeadLift.AutoSize = true;
            this.btnDeadLift.Location = new System.Drawing.Point(139, 166);
            this.btnDeadLift.Name = "btnDeadLift";
            this.btnDeadLift.Size = new System.Drawing.Size(75, 23);
            this.btnDeadLift.TabIndex = 2;
            this.btnDeadLift.Text = "Martwy ciąg";
            this.btnDeadLift.UseVisualStyleBackColor = true;
            this.btnDeadLift.Click += new System.EventHandler(this.btnDeadLift_Click);
            // 
            // btnMeasurements
            // 
            this.btnMeasurements.AutoSize = true;
            this.btnMeasurements.Location = new System.Drawing.Point(120, 210);
            this.btnMeasurements.Name = "btnMeasurements";
            this.btnMeasurements.Size = new System.Drawing.Size(118, 23);
            this.btnMeasurements.TabIndex = 3;
            this.btnMeasurements.Text = "Pomiary całego ciała";
            this.btnMeasurements.UseVisualStyleBackColor = true;
            this.btnMeasurements.Click += new System.EventHandler(this.btnMeasurements_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.AutoSize = true;
            this.btnCloseApp.Location = new System.Drawing.Point(139, 254);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(75, 23);
            this.btnCloseApp.TabIndex = 4;
            this.btnCloseApp.Text = "Zamknij";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 360);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnMeasurements);
            this.Controls.Add(this.btnDeadLift);
            this.Controls.Add(this.btnSquat);
            this.Controls.Add(this.btnBenchPress);
            this.Name = "Main_window";
            this.Text = "Aplikacja pomiarowa";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBenchPress;
        private System.Windows.Forms.Button btnSquat;
        private System.Windows.Forms.Button btnDeadLift;
        private System.Windows.Forms.Button btnMeasurements;
        private System.Windows.Forms.Button btnCloseApp;
    }
}

