namespace Mentally
{
    partial class DatabaseCheck
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
            this.dtg_Database = new System.Windows.Forms.DataGridView();
            this.btn_Database1 = new System.Windows.Forms.Button();
            this.btn_Database2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Database)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Database
            // 
            this.dtg_Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Database.Location = new System.Drawing.Point(-1, 0);
            this.dtg_Database.Name = "dtg_Database";
            this.dtg_Database.Size = new System.Drawing.Size(800, 245);
            this.dtg_Database.TabIndex = 0;
            // 
            // btn_Database1
            // 
            this.btn_Database1.Location = new System.Drawing.Point(269, 279);
            this.btn_Database1.Name = "btn_Database1";
            this.btn_Database1.Size = new System.Drawing.Size(75, 23);
            this.btn_Database1.TabIndex = 1;
            this.btn_Database1.Text = "Database 1";
            this.btn_Database1.UseVisualStyleBackColor = true;
            this.btn_Database1.Click += new System.EventHandler(this.btn_Database1_Click);
            // 
            // btn_Database2
            // 
            this.btn_Database2.Location = new System.Drawing.Point(460, 279);
            this.btn_Database2.Name = "btn_Database2";
            this.btn_Database2.Size = new System.Drawing.Size(75, 23);
            this.btn_Database2.TabIndex = 2;
            this.btn_Database2.Text = "Database 2";
            this.btn_Database2.UseVisualStyleBackColor = true;
            this.btn_Database2.Click += new System.EventHandler(this.btn_Database2_Click);
            // 
            // DatabaseCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Database2);
            this.Controls.Add(this.btn_Database1);
            this.Controls.Add(this.dtg_Database);
            this.Name = "DatabaseCheck";
            this.Text = "DatabaseCheck";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Database)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Database;
        private System.Windows.Forms.Button btn_Database1;
        private System.Windows.Forms.Button btn_Database2;
    }
}