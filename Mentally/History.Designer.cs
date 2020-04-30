namespace Mentally
{
    partial class History
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
            this.btn_Back_History = new System.Windows.Forms.Button();
            this.btn_showHistory = new System.Windows.Forms.Button();
            this.dtgView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back_History
            // 
            this.btn_Back_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back_History.Location = new System.Drawing.Point(269, 286);
            this.btn_Back_History.Name = "btn_Back_History";
            this.btn_Back_History.Size = new System.Drawing.Size(85, 34);
            this.btn_Back_History.TabIndex = 8;
            this.btn_Back_History.Text = "Back";
            this.btn_Back_History.UseVisualStyleBackColor = true;
            this.btn_Back_History.Click += new System.EventHandler(this.btn_Back_History_Click);
            // 
            // btn_showHistory
            // 
            this.btn_showHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showHistory.Location = new System.Drawing.Point(269, 241);
            this.btn_showHistory.Name = "btn_showHistory";
            this.btn_showHistory.Size = new System.Drawing.Size(85, 34);
            this.btn_showHistory.TabIndex = 7;
            this.btn_showHistory.Text = "History";
            this.btn_showHistory.UseVisualStyleBackColor = true;
            this.btn_showHistory.Click += new System.EventHandler(this.btn_showHistory_Click);
            // 
            // dtgView
            // 
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Location = new System.Drawing.Point(0, -1);
            this.dtgView.Name = "dtgView";
            this.dtgView.Size = new System.Drawing.Size(624, 236);
            this.dtgView.TabIndex = 6;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 330);
            this.Controls.Add(this.btn_Back_History);
            this.Controls.Add(this.btn_showHistory);
            this.Controls.Add(this.dtgView);
            this.Name = "History";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back_History;
        private System.Windows.Forms.Button btn_showHistory;
        private System.Windows.Forms.DataGridView dtgView;
    }
}