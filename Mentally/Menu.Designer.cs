namespace Mentally
{
    partial class Menu
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
            this.lb_Mentally = new System.Windows.Forms.Label();
            this.btn_CheckUp = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_Motivasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Mentally
            // 
            this.lb_Mentally.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Mentally.AutoSize = true;
            this.lb_Mentally.Font = new System.Drawing.Font("Playfair Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mentally.Location = new System.Drawing.Point(325, 37);
            this.lb_Mentally.Name = "lb_Mentally";
            this.lb_Mentally.Size = new System.Drawing.Size(124, 39);
            this.lb_Mentally.TabIndex = 4;
            this.lb_Mentally.Text = "Mentally";
            // 
            // btn_CheckUp
            // 
            this.btn_CheckUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CheckUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckUp.Location = new System.Drawing.Point(332, 134);
            this.btn_CheckUp.Name = "btn_CheckUp";
            this.btn_CheckUp.Size = new System.Drawing.Size(105, 35);
            this.btn_CheckUp.TabIndex = 5;
            this.btn_CheckUp.Text = "Check Up";
            this.btn_CheckUp.UseVisualStyleBackColor = true;
            this.btn_CheckUp.Click += new System.EventHandler(this.btn_CheckUp_Click);
            // 
            // btn_History
            // 
            this.btn_History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.Location = new System.Drawing.Point(332, 190);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(105, 34);
            this.btn_History.TabIndex = 6;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Motivasi
            // 
            this.btn_Motivasi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Motivasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Motivasi.Location = new System.Drawing.Point(331, 249);
            this.btn_Motivasi.Name = "btn_Motivasi";
            this.btn_Motivasi.Size = new System.Drawing.Size(105, 33);
            this.btn_Motivasi.TabIndex = 7;
            this.btn_Motivasi.Text = "Motivation";
            this.btn_Motivasi.UseVisualStyleBackColor = true;
            this.btn_Motivasi.Click += new System.EventHandler(this.btn_Motivasi_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.btn_Motivasi);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.btn_CheckUp);
            this.Controls.Add(this.lb_Mentally);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Mentally;
        private System.Windows.Forms.Button btn_CheckUp;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_Motivasi;
    }
}