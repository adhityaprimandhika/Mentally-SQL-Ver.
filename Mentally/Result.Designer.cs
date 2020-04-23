namespace Mentally
{
    partial class Result
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
            this.lb_Hasil = new System.Windows.Forms.Label();
            this.lb_HasilGangguan = new System.Windows.Forms.Label();
            this.btn_HasilSolusi = new System.Windows.Forms.Button();
            this.lb_HasilHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Hasil
            // 
            this.lb_Hasil.AutoSize = true;
            this.lb_Hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hasil.Location = new System.Drawing.Point(197, 137);
            this.lb_Hasil.Name = "lb_Hasil";
            this.lb_Hasil.Size = new System.Drawing.Size(268, 20);
            this.lb_Hasil.TabIndex = 0;
            this.lb_Hasil.Text = "Gangguan yang anda alami adalah : ";
            // 
            // lb_HasilGangguan
            // 
            this.lb_HasilGangguan.AutoSize = true;
            this.lb_HasilGangguan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HasilGangguan.Location = new System.Drawing.Point(461, 137);
            this.lb_HasilGangguan.Name = "lb_HasilGangguan";
            this.lb_HasilGangguan.Size = new System.Drawing.Size(14, 20);
            this.lb_HasilGangguan.TabIndex = 1;
            this.lb_HasilGangguan.Text = "-";
            // 
            // btn_HasilSolusi
            // 
            this.btn_HasilSolusi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HasilSolusi.Location = new System.Drawing.Point(335, 210);
            this.btn_HasilSolusi.Name = "btn_HasilSolusi";
            this.btn_HasilSolusi.Size = new System.Drawing.Size(80, 30);
            this.btn_HasilSolusi.TabIndex = 2;
            this.btn_HasilSolusi.Text = "Solusi";
            this.btn_HasilSolusi.UseVisualStyleBackColor = true;
            this.btn_HasilSolusi.Click += new System.EventHandler(this.btn_HasilSolusi_Click);
            // 
            // lb_HasilHeader
            // 
            this.lb_HasilHeader.AutoSize = true;
            this.lb_HasilHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HasilHeader.Location = new System.Drawing.Point(287, 32);
            this.lb_HasilHeader.Name = "lb_HasilHeader";
            this.lb_HasilHeader.Size = new System.Drawing.Size(178, 29);
            this.lb_HasilHeader.TabIndex = 6;
            this.lb_HasilHeader.Text = "Hasil Check Up";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.lb_HasilHeader);
            this.Controls.Add(this.btn_HasilSolusi);
            this.Controls.Add(this.lb_HasilGangguan);
            this.Controls.Add(this.lb_Hasil);
            this.Name = "Result";
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Hasil;
        private System.Windows.Forms.Label lb_HasilGangguan;
        private System.Windows.Forms.Button btn_HasilSolusi;
        private System.Windows.Forms.Label lb_HasilHeader;
    }
}