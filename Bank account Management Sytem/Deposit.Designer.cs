namespace Bank_account_Management_Sytem
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DepositAmtTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.GunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.GunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(800, 67);
            this.Panel2.TabIndex = 14;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(776, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(24, 25);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "X";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(146, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(554, 38);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "BANK ACCOUNT MANAGEMENT SYSTEM";
            // 
            // BunifuThinButton21
            // 
            this.BunifuThinButton21.ActiveBorderThickness = 1;
            this.BunifuThinButton21.ActiveCornerRadius = 20;
            this.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuThinButton21.BackgroundImage")));
            this.BunifuThinButton21.ButtonText = "DEPOSIT";
            this.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunifuThinButton21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BunifuThinButton21.IdleBorderThickness = 1;
            this.BunifuThinButton21.IdleCornerRadius = 20;
            this.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Black;
            this.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BunifuThinButton21.Location = new System.Drawing.Point(232, 264);
            this.BunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.BunifuThinButton21.Name = "BunifuThinButton21";
            this.BunifuThinButton21.Size = new System.Drawing.Size(318, 65);
            this.BunifuThinButton21.TabIndex = 19;
            this.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // DepositAmtTb
            // 
            this.DepositAmtTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepositAmtTb.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositAmtTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DepositAmtTb.HintForeColor = System.Drawing.Color.Black;
            this.DepositAmtTb.HintText = "AMOUNT:";
            this.DepositAmtTb.isPassword = false;
            this.DepositAmtTb.LineFocusedColor = System.Drawing.Color.LimeGreen;
            this.DepositAmtTb.LineIdleColor = System.Drawing.Color.Black;
            this.DepositAmtTb.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.DepositAmtTb.LineThickness = 4;
            this.DepositAmtTb.Location = new System.Drawing.Point(155, 184);
            this.DepositAmtTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepositAmtTb.Name = "DepositAmtTb";
            this.DepositAmtTb.Size = new System.Drawing.Size(441, 57);
            this.DepositAmtTb.TabIndex = 18;
            this.DepositAmtTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // GunaLabel5
            // 
            this.GunaLabel5.AutoSize = true;
            this.GunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaLabel5.Location = new System.Drawing.Point(380, 381);
            this.GunaLabel5.Name = "GunaLabel5";
            this.GunaLabel5.Size = new System.Drawing.Size(60, 25);
            this.GunaLabel5.TabIndex = 17;
            this.GunaLabel5.Text = "BACK";
            this.GunaLabel5.Click += new System.EventHandler(this.GunaLabel5_Click);
            // 
            // GunaLabel6
            // 
            this.GunaLabel6.AutoSize = true;
            this.GunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaLabel6.Location = new System.Drawing.Point(331, 70);
            this.GunaLabel6.Name = "GunaLabel6";
            this.GunaLabel6.Size = new System.Drawing.Size(114, 32);
            this.GunaLabel6.TabIndex = 16;
            this.GunaLabel6.Text = "DEPOSIT";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 407);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(800, 43);
            this.Panel1.TabIndex = 15;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.BunifuThinButton21);
            this.Controls.Add(this.DepositAmtTb);
            this.Controls.Add(this.GunaLabel5);
            this.Controls.Add(this.GunaLabel6);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal Bunifu.Framework.UI.BunifuThinButton2 BunifuThinButton21;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox DepositAmtTb;
        internal Guna.UI.WinForms.GunaLabel GunaLabel5;
        internal Guna.UI.WinForms.GunaLabel GunaLabel6;
        internal System.Windows.Forms.Panel Panel1;
    }
}