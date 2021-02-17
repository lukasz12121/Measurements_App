
namespace Measurements_App
{
    partial class BenchPressWindow
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
            this.btnAddRec = new System.Windows.Forms.Button();
            this.btnDropRec = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBench = new System.Windows.Forms.DataGridView();
            this.btnChart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lDate = new System.Windows.Forms.Label();
            this.lRepCount = new System.Windows.Forms.Label();
            this.lWeight = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBench)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(442, 570);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddRec
            // 
            this.btnAddRec.AutoSize = true;
            this.btnAddRec.Location = new System.Drawing.Point(47, 570);
            this.btnAddRec.Name = "btnAddRec";
            this.btnAddRec.Size = new System.Drawing.Size(106, 23);
            this.btnAddRec.TabIndex = 3;
            this.btnAddRec.Text = "Dodaj nowy rekord";
            this.btnAddRec.UseVisualStyleBackColor = true;
            this.btnAddRec.Click += new System.EventHandler(this.btnAddRec_Click);
            // 
            // btnDropRec
            // 
            this.btnDropRec.AutoSize = true;
            this.btnDropRec.Location = new System.Drawing.Point(159, 570);
            this.btnDropRec.Name = "btnDropRec";
            this.btnDropRec.Size = new System.Drawing.Size(75, 23);
            this.btnDropRec.TabIndex = 4;
            this.btnDropRec.Text = "Usuń rekord";
            this.btnDropRec.UseVisualStyleBackColor = true;
            this.btnDropRec.Click += new System.EventHandler(this.btnDropRec_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(88, 25);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(97, 20);
            this.dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(284, 25);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(97, 20);
            this.dtpEndDate.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 55);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz zakres czasowy treningów";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data startowa:";
            // 
            // dgvBench
            // 
            this.dgvBench.AllowUserToAddRows = false;
            this.dgvBench.AllowUserToOrderColumns = true;
            this.dgvBench.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBench.Location = new System.Drawing.Point(47, 94);
            this.dgvBench.Name = "dgvBench";
            this.dgvBench.ReadOnly = true;
            this.dgvBench.Size = new System.Drawing.Size(460, 370);
            this.dgvBench.TabIndex = 8;
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(240, 570);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(95, 23);
            this.btnChart.TabIndex = 14;
            this.btnChart.Text = "Pokaż wykres";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lDate);
            this.groupBox2.Controls.Add(this.lRepCount);
            this.groupBox2.Controls.Add(this.lWeight);
            this.groupBox2.Location = new System.Drawing.Point(47, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 61);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dotychczasowy rekord";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDate.Location = new System.Drawing.Point(285, 20);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(40, 16);
            this.lDate.TabIndex = 2;
            this.lDate.Text = "Data:";
            // 
            // lRepCount
            // 
            this.lRepCount.AutoSize = true;
            this.lRepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRepCount.Location = new System.Drawing.Point(122, 20);
            this.lRepCount.Name = "lRepCount";
            this.lRepCount.Size = new System.Drawing.Size(106, 16);
            this.lRepCount.TabIndex = 1;
            this.lRepCount.Text = "Ilość powtórzeń: ";
            // 
            // lWeight
            // 
            this.lWeight.AutoSize = true;
            this.lWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lWeight.Location = new System.Drawing.Point(17, 20);
            this.lWeight.Name = "lWeight";
            this.lWeight.Size = new System.Drawing.Size(49, 16);
            this.lWeight.TabIndex = 0;
            this.lWeight.Text = "Ciężar:";
            // 
            // BenchPressWindow
            // 
            this.ClientSize = new System.Drawing.Size(564, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.dgvBench);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDropRec);
            this.Controls.Add(this.btnAddRec);
            this.Controls.Add(this.btnClose);
            this.Name = "BenchPressWindow";
            this.Text = "Wyciskanie";
            this.Load += new System.EventHandler(this.BenchPressWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBench)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button AddNewRecordButton;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddRec;
        private System.Windows.Forms.Button btnDropRec;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBench;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lRepCount;
        private System.Windows.Forms.Label lWeight;
    }
}