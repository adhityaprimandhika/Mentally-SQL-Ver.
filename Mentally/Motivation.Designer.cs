namespace Mentally
{
    partial class Motivation
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
            this.lb_Motivasi_Header = new System.Windows.Forms.Label();
            this.lb_Motivasi = new System.Windows.Forms.Label();
            this.btn_Motivasi = new System.Windows.Forms.Button();
            this.btn_Motivasi_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Motivasi_Header
            // 
            this.lb_Motivasi_Header.AutoSize = true;
            this.lb_Motivasi_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Motivasi_Header.Location = new System.Drawing.Point(239, 41);
            this.lb_Motivasi_Header.Name = "lb_Motivasi_Header";
            this.lb_Motivasi_Header.Size = new System.Drawing.Size(101, 29);
            this.lb_Motivasi_Header.TabIndex = 0;
            this.lb_Motivasi_Header.Text = "Motivasi";
            // 
            // lb_Motivasi
            // 
            this.lb_Motivasi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Motivasi.AutoSize = true;
            this.lb_Motivasi.Font = new System.Drawing.Font("Playfair Display", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Motivasi.Location = new System.Drawing.Point(18, 13);
            this.lb_Motivasi.Name = "lb_Motivasi";
            this.lb_Motivasi.Size = new System.Drawing.Size(14, 17);
            this.lb_Motivasi.TabIndex = 1;
            this.lb_Motivasi.Text = "-";
            // 
            // btn_Motivasi
            // 
            this.btn_Motivasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Motivasi.Location = new System.Drawing.Point(244, 174);
            this.btn_Motivasi.Name = "btn_Motivasi";
            this.btn_Motivasi.Size = new System.Drawing.Size(95, 35);
            this.btn_Motivasi.TabIndex = 2;
            this.btn_Motivasi.Text = "Random";
            this.btn_Motivasi.UseVisualStyleBackColor = true;
            this.btn_Motivasi.Click += new System.EventHandler(this.btn_Motivasi_Click);
            // 
            // btn_Motivasi_Back
            // 
            this.btn_Motivasi_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Motivasi_Back.Location = new System.Drawing.Point(244, 233);
            this.btn_Motivasi_Back.Name = "btn_Motivasi_Back";
            this.btn_Motivasi_Back.Size = new System.Drawing.Size(95, 31);
            this.btn_Motivasi_Back.TabIndex = 3;
            this.btn_Motivasi_Back.Text = "Back";
            this.btn_Motivasi_Back.UseVisualStyleBackColor = true;
            this.btn_Motivasi_Back.Click += new System.EventHandler(this.btn_Motivasi_Back_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_Motivasi);
            this.panel1.Location = new System.Drawing.Point(115, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 41);
            this.panel1.TabIndex = 4;
            // 
            // Motivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Motivasi_Back);
            this.Controls.Add(this.btn_Motivasi);
            this.Controls.Add(this.lb_Motivasi_Header);
            this.Name = "Motivation";
            this.Text = "Motivation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Motivasi_Header;
        private System.Windows.Forms.Label lb_Motivasi;
        private System.Windows.Forms.Button btn_Motivasi;
        private System.Windows.Forms.Button btn_Motivasi_Back;
        private System.Windows.Forms.Panel panel1;
    }
}