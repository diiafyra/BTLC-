﻿namespace baitaplon
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.AnimatorNS.Animation animation7 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.spBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.nccBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.transition.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation7;
            this.transition.Interval = 1000;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.transition.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 442);
            this.panel2.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.Controls.Add(this.spBtn);
            this.guna2Panel1.Controls.Add(this.nccBtn);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.transition.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(180, 499);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.MouseEnter += new System.EventHandler(this.spBtn_MouseEnter);
            this.guna2Panel1.MouseLeave += new System.EventHandler(this.spBtn_MouseLeave);
            // 
            // spBtn
            // 
            this.spBtn.Animated = true;
            this.spBtn.BackColor = System.Drawing.Color.Transparent;
            this.spBtn.BorderColor = System.Drawing.Color.DimGray;
            this.transition.SetDecoration(this.spBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.spBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.spBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.spBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.spBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.spBtn.FillColor2 = System.Drawing.Color.DimGray;
            this.spBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.spBtn.ForeColor = System.Drawing.Color.White;
            this.spBtn.Location = new System.Drawing.Point(0, 216);
            this.spBtn.Name = "spBtn";
            this.spBtn.Size = new System.Drawing.Size(178, 55);
            this.spBtn.TabIndex = 2;
            this.spBtn.Text = "SẢN PHẨM";
            this.spBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.spBtn.UseTransparentBackground = true;
            this.spBtn.Click += new System.EventHandler(this.spBtn_Click_1);
            this.spBtn.MouseEnter += new System.EventHandler(this.spBtn_MouseEnter);
            this.spBtn.MouseLeave += new System.EventHandler(this.spBtn_MouseLeave);
            // 
            // nccBtn
            // 
            this.nccBtn.Animated = true;
            this.nccBtn.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.nccBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nccBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nccBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nccBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nccBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nccBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nccBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nccBtn.FillColor2 = System.Drawing.Color.DimGray;
            this.nccBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nccBtn.ForeColor = System.Drawing.Color.White;
            this.nccBtn.Location = new System.Drawing.Point(0, 159);
            this.nccBtn.Name = "nccBtn";
            this.nccBtn.Size = new System.Drawing.Size(178, 52);
            this.nccBtn.TabIndex = 1;
            this.nccBtn.Text = "NHÀ CUNG CẤP";
            this.nccBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nccBtn.UseTransparentBackground = true;
            this.nccBtn.Click += new System.EventHandler(this.nccBtn_Click);
            this.nccBtn.MouseEnter += new System.EventHandler(this.spBtn_MouseEnter);
            this.nccBtn.MouseLeave += new System.EventHandler(this.spBtn_MouseLeave);
            // 
            // guna2CirclePictureBox1
            // 
            this.transition.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(36, 25);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(111, 109);
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.MouseEnter += new System.EventHandler(this.spBtn_MouseEnter);
            this.guna2CirclePictureBox1.MouseLeave += new System.EventHandler(this.spBtn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÀ CUNG CẤP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.transition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(180, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 57);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(929, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton spBtn;
        private Guna.UI2.WinForms.Guna2GradientButton nccBtn;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
