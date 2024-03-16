namespace Bank_account_Management_Sytem
{
    partial class account
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
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.AccNumTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AccNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pintb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.FanameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.occupationtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AddressTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Phonetb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.educationtb = new Guna.UI.WinForms.GunaComboBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.dobdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anima2 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Panel2.Controls.Add(this.Label1);
            this.anima2.SetDecoration(this.Panel2, Guna.UI.Animation.DecorationType.None);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(899, 67);
            this.Panel2.TabIndex = 12;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.anima2.SetDecoration(this.Label1, Guna.UI.Animation.DecorationType.None);
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(184, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(554, 38);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "BANK ACCOUNT MANAGEMENT SYSTEM";
            // 
            // AccNumTb
            // 
            this.AccNumTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anima2.SetDecoration(this.AccNumTb, Guna.UI.Animation.DecorationType.None);
            this.AccNumTb.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccNumTb.HintForeColor = System.Drawing.Color.Empty;
            this.AccNumTb.HintText = "ACC NUM";
            this.AccNumTb.isPassword = false;
            this.AccNumTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.AccNumTb.LineIdleColor = System.Drawing.Color.Black;
            this.AccNumTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AccNumTb.LineThickness = 4;
            this.AccNumTb.Location = new System.Drawing.Point(42, 99);
            this.AccNumTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccNumTb.Name = "AccNumTb";
            this.AccNumTb.Size = new System.Drawing.Size(280, 54);
            this.AccNumTb.TabIndex = 13;
            this.AccNumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AccNameTb
            // 
            this.AccNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anima2.SetDecoration(this.AccNameTb, Guna.UI.Animation.DecorationType.None);
            this.AccNameTb.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccNameTb.HintForeColor = System.Drawing.Color.Black;
            this.AccNameTb.HintText = "NAME";
            this.AccNameTb.isPassword = false;
            this.AccNameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.AccNameTb.LineIdleColor = System.Drawing.Color.Black;
            this.AccNameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AccNameTb.LineThickness = 4;
            this.AccNameTb.Location = new System.Drawing.Point(42, 174);
            this.AccNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccNameTb.Name = "AccNameTb";
            this.AccNameTb.Size = new System.Drawing.Size(280, 54);
            this.AccNameTb.TabIndex = 14;
            this.AccNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pintb
            // 
            this.pintb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anima2.SetDecoration(this.pintb, Guna.UI.Animation.DecorationType.None);
            this.pintb.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pintb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pintb.HintForeColor = System.Drawing.Color.Empty;
            this.pintb.HintText = "PIN";
            this.pintb.isPassword = false;
            this.pintb.LineFocusedColor = System.Drawing.Color.Blue;
            this.pintb.LineIdleColor = System.Drawing.Color.Black;
            this.pintb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pintb.LineThickness = 4;
            this.pintb.Location = new System.Drawing.Point(532, 99);
            this.pintb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pintb.Name = "pintb";
            this.pintb.Size = new System.Drawing.Size(298, 54);
            this.pintb.TabIndex = 15;
            this.pintb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anima2.SetDecoration(this.bunifuMaterialTextbox4, Guna.UI.Animation.DecorationType.None);
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "EDUCATION";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox4.LineThickness = 4;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(532, 174);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(298, 54);
            this.bunifuMaterialTextbox4.TabIndex = 16;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FanameTb
            // 
            this.FanameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anima2.SetDecoration(this.FanameTb, Guna.UI.Animation.DecorationType.None);
            this.FanameTb.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FanameTb.HintForeColor = System.Drawing.Color.Empty;
            this.FanameTb.HintText = "FNAME";
            this.FanameTb.isPassword = false;
            this.FanameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.FanameTb.LineIdleColor = System.Drawing.Color.Black;
            this.FanameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.FanameTb.LineThickness = 4;
            this.FanameTb.Location = new System.Drawing.Point(42, 265);
            this.FanameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FanameTb.Name = "FanameTb";
            this.FanameTb.Size = new System.Drawing.Size(280, 54);
            this.FanameTb.TabIndex = 17;
            this.FanameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // occupationtb
            // 
            this.occupationtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anima2.SetDecoration(this.occupationtb, Guna.UI.Animation.DecorationType.None);
            this.occupationtb.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.occupationtb.HintForeColor = System.Drawing.Color.Empty;
            this.occupationtb.HintText = "OCCUPATION";
            this.occupationtb.isPassword = false;
            this.occupationtb.LineFocusedColor = System.Drawing.Color.Blue;
            this.occupationtb.LineIdleColor = System.Drawing.Color.Black;
            this.occupationtb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.occupationtb.LineThickness = 4;
            this.occupationtb.Location = new System.Drawing.Point(532, 265);
            this.occupationtb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.occupationtb.Name = "occupationtb";
            this.occupationtb.Size = new System.Drawing.Size(298, 54);
            this.occupationtb.TabIndex = 18;
            this.occupationtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddressTb
            // 
            this.AddressTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anima2.SetDecoration(this.AddressTb, Guna.UI.Animation.DecorationType.None);
            this.AddressTb.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddressTb.HintForeColor = System.Drawing.Color.Empty;
            this.AddressTb.HintText = "ADDRESS";
            this.AddressTb.isPassword = false;
            this.AddressTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.AddressTb.LineIdleColor = System.Drawing.Color.Black;
            this.AddressTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AddressTb.LineThickness = 4;
            this.AddressTb.Location = new System.Drawing.Point(42, 365);
            this.AddressTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(280, 54);
            this.AddressTb.TabIndex = 19;
            this.AddressTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Phonetb
            // 
            this.Phonetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anima2.SetDecoration(this.Phonetb, Guna.UI.Animation.DecorationType.None);
            this.Phonetb.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonetb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Phonetb.HintForeColor = System.Drawing.Color.Empty;
            this.Phonetb.HintText = "PHONE";
            this.Phonetb.isPassword = false;
            this.Phonetb.LineFocusedColor = System.Drawing.Color.Blue;
            this.Phonetb.LineIdleColor = System.Drawing.Color.Black;
            this.Phonetb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Phonetb.LineThickness = 4;
            this.Phonetb.Location = new System.Drawing.Point(532, 365);
            this.Phonetb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Phonetb.Name = "Phonetb";
            this.Phonetb.Size = new System.Drawing.Size(298, 54);
            this.Phonetb.TabIndex = 20;
            this.Phonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // educationtb
            // 
            this.educationtb.BackColor = System.Drawing.Color.Transparent;
            this.educationtb.BaseColor = System.Drawing.Color.White;
            this.educationtb.BorderColor = System.Drawing.Color.Silver;
            this.anima2.SetDecoration(this.educationtb, Guna.UI.Animation.DecorationType.None);
            this.educationtb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.educationtb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.educationtb.FocusedColor = System.Drawing.Color.Empty;
            this.educationtb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.educationtb.ForeColor = System.Drawing.Color.Black;
            this.educationtb.FormattingEnabled = true;
            this.educationtb.Items.AddRange(new object[] {
            "Post Graduate",
            "Under Graduate",
            "Other"});
            this.educationtb.Location = new System.Drawing.Point(663, 186);
            this.educationtb.Name = "educationtb";
            this.educationtb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.educationtb.OnHoverItemForeColor = System.Drawing.Color.White;
            this.educationtb.Size = new System.Drawing.Size(167, 35);
            this.educationtb.TabIndex = 21;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuThinButton21.ButtonText = "<< SUBMIT >>";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anima2.SetDecoration(this.bunifuThinButton21, Guna.UI.Animation.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(281, 489);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(256, 61);
            this.bunifuThinButton21.TabIndex = 22;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.anima2.SetDecoration(this.label4, Guna.UI.Animation.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "DOB";
            // 
            // dobdate
            // 
            this.dobdate.BaseColor = System.Drawing.Color.White;
            this.dobdate.BorderColor = System.Drawing.Color.Silver;
            this.dobdate.CustomFormat = null;
            this.anima2.SetDecoration(this.dobdate, Guna.UI.Animation.DecorationType.None);
            this.dobdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dobdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dobdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dobdate.ForeColor = System.Drawing.Color.Black;
            this.dobdate.Location = new System.Drawing.Point(602, 441);
            this.dobdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobdate.Name = "dobdate";
            this.dobdate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dobdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dobdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dobdate.OnPressedColor = System.Drawing.Color.Black;
            this.dobdate.Size = new System.Drawing.Size(228, 28);
            this.dobdate.TabIndex = 25;
            this.dobdate.Text = "16 January 2021";
            this.dobdate.Value = new System.DateTime(2021, 1, 16, 12, 48, 37, 955);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.anima2.SetDecoration(this.Panel1, Guna.UI.Animation.DecorationType.None);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 600);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(899, 28);
            this.Panel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.anima2.SetDecoration(this.label3, Guna.UI.Animation.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(833, 569);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "EXIT";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.anima2.SetDecoration(this.label2, Guna.UI.Animation.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "LOGOUT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // anima2
            // 
            this.anima2.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.anima2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.anima2.DefaultAnimation = animation1;
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(899, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dobdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.educationtb);
            this.Controls.Add(this.Phonetb);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.occupationtb);
            this.Controls.Add(this.FanameTb);
            this.Controls.Add(this.bunifuMaterialTextbox4);
            this.Controls.Add(this.pintb);
            this.Controls.Add(this.AccNameTb);
            this.Controls.Add(this.AccNumTb);
            this.Controls.Add(this.Panel2);
            this.anima2.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account";
            this.Load += new System.EventHandler(this.account_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AccNumTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AccNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pintb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FanameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox occupationtb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AddressTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Phonetb;
        private Guna.UI.WinForms.GunaComboBox educationtb;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDateTimePicker dobdate;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTransition anima2;
    }
}