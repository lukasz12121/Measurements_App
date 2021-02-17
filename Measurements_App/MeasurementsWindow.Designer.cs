
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvMeasurement = new System.Windows.Forms.DataGridView();
            this.btnDropMeasure = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lDate = new System.Windows.Forms.Label();
            this.btnBMI = new System.Windows.Forms.Button();
            this.lCalf = new System.Windows.Forms.Label();
            this.lThigh = new System.Windows.Forms.Label();
            this.lStomach = new System.Windows.Forms.Label();
            this.lBiceps = new System.Windows.Forms.Label();
            this.lChest = new System.Windows.Forms.Label();
            this.lWeight = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurement)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(870, 575);
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
            this.btnAddMeasure.Location = new System.Drawing.Point(48, 575);
            this.btnAddMeasure.Name = "btnAddMeasure";
            this.btnAddMeasure.Size = new System.Drawing.Size(107, 23);
            this.btnAddMeasure.TabIndex = 1;
            this.btnAddMeasure.Text = "Dodaj nowy pomiar";
            this.btnAddMeasure.UseVisualStyleBackColor = true;
            this.btnAddMeasure.Click += new System.EventHandler(this.btnAddMeasure_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz zakres czasowy pomiarów";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(412, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Znajdź";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data końcowa: ";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(284, 25);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(97, 20);
            this.dtpEndDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data startowa:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(88, 25);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(97, 20);
            this.dtpStartDate.TabIndex = 5;
            // 
            // dgvMeasurement
            // 
            this.dgvMeasurement.AllowUserToAddRows = false;
            this.dgvMeasurement.AllowUserToOrderColumns = true;
            this.dgvMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurement.Location = new System.Drawing.Point(47, 91);
            this.dgvMeasurement.Name = "dgvMeasurement";
            this.dgvMeasurement.ReadOnly = true;
            this.dgvMeasurement.Size = new System.Drawing.Size(943, 354);
            this.dgvMeasurement.TabIndex = 11;
            // 
            // btnDropMeasure
            // 
            this.btnDropMeasure.Location = new System.Drawing.Point(161, 575);
            this.btnDropMeasure.Name = "btnDropMeasure";
            this.btnDropMeasure.Size = new System.Drawing.Size(75, 23);
            this.btnDropMeasure.TabIndex = 12;
            this.btnDropMeasure.Text = "Usuń pomiar";
            this.btnDropMeasure.UseVisualStyleBackColor = true;
            this.btnDropMeasure.Click += new System.EventHandler(this.btnDropMeasure_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(242, 575);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(95, 23);
            this.btnChart.TabIndex = 13;
            this.btnChart.Text = "Pokaż wykres";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lDate);
            this.groupBox2.Controls.Add(this.btnBMI);
            this.groupBox2.Controls.Add(this.lCalf);
            this.groupBox2.Controls.Add(this.lThigh);
            this.groupBox2.Controls.Add(this.lStomach);
            this.groupBox2.Controls.Add(this.lBiceps);
            this.groupBox2.Controls.Add(this.lChest);
            this.groupBox2.Controls.Add(this.lWeight);
            this.groupBox2.Controls.Add(this.lHeight);
            this.groupBox2.Location = new System.Drawing.Point(47, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 94);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktualne dane";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDate.Location = new System.Drawing.Point(522, 64);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(43, 16);
            this.lDate.TabIndex = 8;
            this.lDate.Text = "Data: ";
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(822, 40);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(75, 23);
            this.btnBMI.TabIndex = 7;
            this.btnBMI.Text = "Oblicz BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // lCalf
            // 
            this.lCalf.AutoSize = true;
            this.lCalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCalf.Location = new System.Drawing.Point(519, 30);
            this.lCalf.Name = "lCalf";
            this.lCalf.Size = new System.Drawing.Size(101, 16);
            this.lCalf.TabIndex = 6;
            this.lCalf.Text = "Wymiary łydki: ";
            // 
            // lThigh
            // 
            this.lThigh.AutoSize = true;
            this.lThigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lThigh.Location = new System.Drawing.Point(340, 64);
            this.lThigh.Name = "lThigh";
            this.lThigh.Size = new System.Drawing.Size(90, 16);
            this.lThigh.TabIndex = 5;
            this.lThigh.Text = "Wymiary uda:";
            // 
            // lStomach
            // 
            this.lStomach.AutoSize = true;
            this.lStomach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStomach.Location = new System.Drawing.Point(340, 30);
            this.lStomach.Name = "lStomach";
            this.lStomach.Size = new System.Drawing.Size(114, 16);
            this.lStomach.TabIndex = 4;
            this.lStomach.Text = "Wymiary brzucha:";
            // 
            // lBiceps
            // 
            this.lBiceps.AutoSize = true;
            this.lBiceps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBiceps.Location = new System.Drawing.Point(152, 64);
            this.lBiceps.Name = "lBiceps";
            this.lBiceps.Size = new System.Drawing.Size(115, 16);
            this.lBiceps.TabIndex = 3;
            this.lBiceps.Text = "Wymiary bicepsu:";
            // 
            // lChest
            // 
            this.lChest.AutoSize = true;
            this.lChest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lChest.Location = new System.Drawing.Point(152, 30);
            this.lChest.Name = "lChest";
            this.lChest.Size = new System.Drawing.Size(98, 16);
            this.lChest.TabIndex = 2;
            this.lChest.Text = "Wymiary klatki:";
            // 
            // lWeight
            // 
            this.lWeight.AutoSize = true;
            this.lWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lWeight.Location = new System.Drawing.Point(14, 64);
            this.lWeight.Name = "lWeight";
            this.lWeight.Size = new System.Drawing.Size(48, 16);
            this.lWeight.TabIndex = 1;
            this.lWeight.Text = "Waga:";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lHeight.Location = new System.Drawing.Point(14, 30);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(55, 16);
            this.lHeight.TabIndex = 0;
            this.lHeight.Text = "Wzrost: ";
            // 
            // MeasurementsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnDropMeasure);
            this.Controls.Add(this.dgvMeasurement);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddMeasure);
            this.Controls.Add(this.btnClose);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MeasurementsWindow";
            this.Text = "Pomiary ciała";
            this.Load += new System.EventHandler(this.MeasurementsWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurement)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddMeasure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DataGridView dgvMeasurement;
        private System.Windows.Forms.Button btnDropMeasure;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label lCalf;
        private System.Windows.Forms.Label lThigh;
        private System.Windows.Forms.Label lStomach;
        private System.Windows.Forms.Label lBiceps;
        private System.Windows.Forms.Label lChest;
        private System.Windows.Forms.Label lWeight;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.Label lDate;
    }
}