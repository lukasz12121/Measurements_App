
namespace Measurements_App
{
    partial class SquatWindow
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
            this.btnDropRec = new System.Windows.Forms.Button();
            this.btnAddRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(337, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDropRec
            // 
            this.btnDropRec.AutoSize = true;
            this.btnDropRec.Location = new System.Drawing.Point(199, 370);
            this.btnDropRec.Name = "btnDropRec";
            this.btnDropRec.Size = new System.Drawing.Size(75, 23);
            this.btnDropRec.TabIndex = 6;
            this.btnDropRec.Text = "Usuń rekord";
            this.btnDropRec.UseVisualStyleBackColor = true;
            this.btnDropRec.Click += new System.EventHandler(this.btnDropRec_Click);
            // 
            // btnAddRec
            // 
            this.btnAddRec.AutoSize = true;
            this.btnAddRec.Location = new System.Drawing.Point(33, 370);
            this.btnAddRec.Name = "btnAddRec";
            this.btnAddRec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddRec.Size = new System.Drawing.Size(106, 23);
            this.btnAddRec.TabIndex = 5;
            this.btnAddRec.Text = "Dodaj nowy rekord";
            this.btnAddRec.UseVisualStyleBackColor = true;
            this.btnAddRec.Click += new System.EventHandler(this.btnAddRec_Click);
            // 
            // SquatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 439);
            this.Controls.Add(this.btnDropRec);
            this.Controls.Add(this.btnAddRec);
            this.Controls.Add(this.btnClose);
            this.Name = "SquatWindow";
            this.Text = "Przysiady";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDropRec;
        private System.Windows.Forms.Button btnAddRec;
    }
}