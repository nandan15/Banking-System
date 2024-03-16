namespace Bank_account_Management_Sytem
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI.Animation.Animation animation3 = new Guna.UI.Animation.Animation();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AccNumtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PinTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.p1 = new Guna.UI.WinForms.GunaPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p2 = new Guna.UI.WinForms.GunaPanel();
            this.anima1 = new Guna.UI.WinForms.GunaTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.anima1.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AccNumtb
            // 
            this.AccNumtb.BackColor = System.Drawing.Color.Black;
            this.AccNumtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anima1.SetDecoration(this.AccNumtb, Guna.UI.Animation.DecorationType.None);
            this.AccNumtb.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumtb.ForeColor = System.Drawing.Color.Green;
            this.AccNumtb.HintForeColor = System.Drawing.Color.Green;
            this.AccNumtb.HintText = "ACC NUM";
            this.AccNumtb.isPassword = false;
            this.AccNumtb.LineFocusedColor = System.Drawing.Color.Blue;
            this.AccNumtb.LineIdleColor = System.Drawing.Color.Green;
            this.AccNumtb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AccNumtb.LineThickness = 4;
            this.AccNumtb.Location = new System.Drawing.Point(45, 242);
            this.AccNumtb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccNumtb.Name = "AccNumtb";
            this.AccNumtb.Size = new System.Drawing.Size(297, 56);
            this.AccNumtb.TabIndex = 4;
            this.AccNumtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AccNumtb.OnValueChanged += new System.EventHandler(this.AccNumtb_OnValueChanged);
            // 
            // PinTb
            // 
            this.PinTb.BackColor = System.Drawing.Color.Black;
            this.PinTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anima1.SetDecoration(this.PinTb, Guna.UI.Animation.DecorationType.None);
            this.PinTb.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinTb.ForeColor = System.Drawing.Color.Green;
            this.PinTb.HintForeColor = System.Drawing.Color.Green;
            this.PinTb.HintText = "PIN";
            this.PinTb.isPassword = true;
            this.PinTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.PinTb.LineIdleColor = System.Drawing.Color.Green;
            this.PinTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PinTb.LineThickness = 4;
            this.PinTb.Location = new System.Drawing.Point(45, 308);
            this.PinTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PinTb.Name = "PinTb";
            this.PinTb.Size = new System.Drawing.Size(297, 58);
            this.PinTb.TabIndex = 5;
            this.PinTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PinTb.OnValueChanged += new System.EventHandler(this.PinTb_OnValueChanged);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton21.ButtonText = "<< LOGIN >>";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anima1.SetDecoration(this.bunifuThinButton21, Guna.UI.Animation.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(61, 430);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(256, 60);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.anima1.SetDecoration(this.label2, Guna.UI.Animation.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(164, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "EXIT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.anima1.SetDecoration(this.label3, Guna.UI.Animation.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(143, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "SIGN UP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.BaseColor = System.Drawing.Color.Green;
            this.CheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.anima1.SetDecoration(this.CheckBox1, Guna.UI.Animation.DecorationType.None);
            this.CheckBox1.FillColor = System.Drawing.Color.White;
            this.CheckBox1.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.ForeColor = System.Drawing.Color.Green;
            this.CheckBox1.Location = new System.Drawing.Point(45, 374);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(151, 25);
            this.CheckBox1.TabIndex = 9;
            this.CheckBox1.Text = "Show Password";
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Gray;
            this.p1.Controls.Add(this.label5);
            this.p1.Controls.Add(this.label4);
            this.p1.Controls.Add(this.label1);
            this.anima1.SetDecoration(this.p1, Guna.UI.Animation.DecorationType.None);
            this.p1.Location = new System.Drawing.Point(-1, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(417, 636);
            this.p1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.anima1.SetDecoration(this.label5, Guna.UI.Animation.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "MANAGEMENT SYSTEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.anima1.SetDecoration(this.label4, Guna.UI.Animation.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "BANK ACCOUNT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.anima1.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAMS";
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Black;
            this.p2.Controls.Add(this.label3);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.pictureBox1);
            this.p2.Controls.Add(this.AccNumtb);
            this.p2.Controls.Add(this.bunifuThinButton21);
            this.p2.Controls.Add(this.PinTb);
            this.p2.Controls.Add(this.CheckBox1);
            this.anima1.SetDecoration(this.p2, Guna.UI.Animation.DecorationType.None);
            this.p2.Location = new System.Drawing.Point(418, 0);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(420, 636);
            this.p2.TabIndex = 11;
            // 
            // anima1
            // 
            this.anima1.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.anima1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.anima1.DefaultAnimation = animation3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(836, 635);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.anima1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AccNumtb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PinTb;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaCheckBox CheckBox1;
        private Guna.UI.WinForms.GunaPanel p1;
        private Guna.UI.WinForms.GunaPanel p2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTransition anima1;
    }
}