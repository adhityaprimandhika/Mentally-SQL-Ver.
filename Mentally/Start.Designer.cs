namespace Mentally
{
    partial class Start
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
            this.btn_Start_Login = new System.Windows.Forms.Button();
            this.btn_Start_Register = new System.Windows.Forms.Button();
            this.Pilihan_Start = new System.Windows.Forms.Label();
            this.lb_Mentally = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start_Login
            // 
            this.btn_Start_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start_Login.Location = new System.Drawing.Point(139, 164);
            this.btn_Start_Login.Name = "btn_Start_Login";
            this.btn_Start_Login.Size = new System.Drawing.Size(95, 43);
            this.btn_Start_Login.TabIndex = 0;
            this.btn_Start_Login.Text = "Login";
            this.btn_Start_Login.UseVisualStyleBackColor = true;
            this.btn_Start_Login.Click += new System.EventHandler(this.btn_Start_Login_Click);
            // 
            // btn_Start_Register
            // 
            this.btn_Start_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start_Register.Location = new System.Drawing.Point(367, 164);
            this.btn_Start_Register.Name = "btn_Start_Register";
            this.btn_Start_Register.Size = new System.Drawing.Size(95, 43);
            this.btn_Start_Register.TabIndex = 1;
            this.btn_Start_Register.Text = "Register";
            this.btn_Start_Register.UseVisualStyleBackColor = true;
            this.btn_Start_Register.Click += new System.EventHandler(this.btn_Start_Register_Click);
            // 
            // Pilihan_Start
            // 
            this.Pilihan_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pilihan_Start.AutoSize = true;
            this.Pilihan_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pilihan_Start.Location = new System.Drawing.Point(225, 105);
            this.Pilihan_Start.Name = "Pilihan_Start";
            this.Pilihan_Start.Size = new System.Drawing.Size(148, 20);
            this.Pilihan_Start.TabIndex = 2;
            this.Pilihan_Start.Text = "Login atau Register";
            // 
            // lb_Mentally
            // 
            this.lb_Mentally.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Mentally.AutoSize = true;
            this.lb_Mentally.Font = new System.Drawing.Font("Playfair Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mentally.Location = new System.Drawing.Point(238, 32);
            this.lb_Mentally.Name = "lb_Mentally";
            this.lb_Mentally.Size = new System.Drawing.Size(124, 39);
            this.lb_Mentally.TabIndex = 3;
            this.lb_Mentally.Text = "Mentally";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(612, 294);
            this.Controls.Add(this.lb_Mentally);
            this.Controls.Add(this.Pilihan_Start);
            this.Controls.Add(this.btn_Start_Register);
            this.Controls.Add(this.btn_Start_Login);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start_Login;
        private System.Windows.Forms.Button btn_Start_Register;
        private System.Windows.Forms.Label Pilihan_Start;
        private System.Windows.Forms.Label lb_Mentally;
    }
}