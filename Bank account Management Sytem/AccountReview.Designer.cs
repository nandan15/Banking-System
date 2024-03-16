namespace Bank_account_Management_Sytem
{
    partial class AccountReview
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.GunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.MinistatementDGV = new System.Windows.Forms.DataGridView();
            this.GunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinistatementDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(183, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(554, 38);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "BANK ACCOUNT MANAGEMENT SYSTEM";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(859, 81);
            this.Panel2.TabIndex = 19;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(887, 4);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(24, 25);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "X";
            // 
            // GunaLabel5
            // 
            this.GunaLabel5.AutoSize = true;
            this.GunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaLabel5.Location = new System.Drawing.Point(385, 467);
            this.GunaLabel5.Name = "GunaLabel5";
            this.GunaLabel5.Size = new System.Drawing.Size(60, 25);
            this.GunaLabel5.TabIndex = 20;
            this.GunaLabel5.Text = "BACK";
            this.GunaLabel5.Click += new System.EventHandler(this.GunaLabel5_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 495);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(859, 29);
            this.Panel1.TabIndex = 22;
            // 
            // MinistatementDGV
            // 
            this.MinistatementDGV.AllowUserToOrderColumns = true;
            this.MinistatementDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinistatementDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinistatementDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MinistatementDGV.Location = new System.Drawing.Point(0, 125);
            this.MinistatementDGV.Name = "MinistatementDGV";
            this.MinistatementDGV.RowHeadersWidth = 62;
            this.MinistatementDGV.RowTemplate.Height = 28;
            this.MinistatementDGV.Size = new System.Drawing.Size(859, 339);
            this.MinistatementDGV.TabIndex = 21;
            // 
            // GunaLabel6
            // 
            this.GunaLabel6.AutoSize = true;
            this.GunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaLabel6.Location = new System.Drawing.Point(308, 84);
            this.GunaLabel6.Name = "GunaLabel6";
            this.GunaLabel6.Size = new System.Drawing.Size(226, 32);
            this.GunaLabel6.TabIndex = 18;
            this.GunaLabel6.Text = "ACCOUNT REVIEW";
            this.GunaLabel6.Click += new System.EventHandler(this.GunaLabel6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(832, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AccountReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(859, 524);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.GunaLabel5);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.MinistatementDGV);
            this.Controls.Add(this.GunaLabel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountReview";
            this.Load += new System.EventHandler(this.AccountReview_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinistatementDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label2;
        internal Guna.UI.WinForms.GunaLabel GunaLabel5;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView MinistatementDGV;
        internal Guna.UI.WinForms.GunaLabel GunaLabel6;
        internal System.Windows.Forms.Label label3;
    }
}