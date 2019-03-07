namespace Soundcloud_Downloader
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTieude = new System.Windows.Forms.Panel();
            this.labelTieude = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txbLink = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbAmbao = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnWeb = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEmail = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnYoutbe = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGo = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPaste = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBoxSoundCloud = new System.Windows.Forms.PictureBox();
            this.progress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelTieude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYoutbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoundCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelTieude
            // 
            this.panelTieude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panelTieude.Controls.Add(this.pictureBox1);
            this.panelTieude.Controls.Add(this.labelTieude);
            this.panelTieude.Controls.Add(this.btnClose);
            this.panelTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieude.Location = new System.Drawing.Point(0, 0);
            this.panelTieude.Name = "panelTieude";
            this.panelTieude.Size = new System.Drawing.Size(497, 35);
            this.panelTieude.TabIndex = 0;
            // 
            // labelTieude
            // 
            this.labelTieude.AutoSize = true;
            this.labelTieude.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieude.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTieude.Location = new System.Drawing.Point(39, 9);
            this.labelTieude.Name = "labelTieude";
            this.labelTieude.Size = new System.Drawing.Size(199, 20);
            this.labelTieude.TabIndex = 2;
            this.labelTieude.Text = "SoundCloud Downloader 1.0";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTieude;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txbLink
            // 
            this.txbLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLink.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLink.ForeColor = System.Drawing.Color.Gainsboro;
            this.txbLink.HintForeColor = System.Drawing.Color.Empty;
            this.txbLink.HintText = "";
            this.txbLink.isPassword = false;
            this.txbLink.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txbLink.LineIdleColor = System.Drawing.Color.Gray;
            this.txbLink.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txbLink.LineThickness = 4;
            this.txbLink.Location = new System.Drawing.Point(4, 56);
            this.txbLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbLink.Name = "txbLink";
            this.txbLink.Size = new System.Drawing.Size(416, 36);
            this.txbLink.TabIndex = 3;
            this.txbLink.Text = "Link track,  playlist hoặc album";
            this.txbLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(4, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Âm báo khi hoàn tất:";
            // 
            // ckbAmbao
            // 
            this.ckbAmbao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.ckbAmbao.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckbAmbao.Checked = true;
            this.ckbAmbao.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.ckbAmbao.ForeColor = System.Drawing.Color.White;
            this.ckbAmbao.Location = new System.Drawing.Point(161, 97);
            this.ckbAmbao.Name = "ckbAmbao";
            this.ckbAmbao.Size = new System.Drawing.Size(20, 20);
            this.ckbAmbao.TabIndex = 6;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.labelTieude;
            this.bunifuDragControl2.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(333, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code by Le Minh Thanh";
            // 
            // btnWeb
            // 
            this.btnWeb.BackColor = System.Drawing.Color.Transparent;
            this.btnWeb.Image = ((System.Drawing.Image)(resources.GetObject("btnWeb.Image")));
            this.btnWeb.ImageActive = null;
            this.btnWeb.Location = new System.Drawing.Point(73, 350);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(35, 35);
            this.btnWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnWeb.TabIndex = 8;
            this.btnWeb.TabStop = false;
            this.btnWeb.Zoom = 10;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.ImageActive = null;
            this.btnEmail.Location = new System.Drawing.Point(37, 350);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(35, 35);
            this.btnEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmail.TabIndex = 7;
            this.btnEmail.TabStop = false;
            this.btnEmail.Zoom = 10;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnYoutbe
            // 
            this.btnYoutbe.BackColor = System.Drawing.Color.Transparent;
            this.btnYoutbe.Image = ((System.Drawing.Image)(resources.GetObject("btnYoutbe.Image")));
            this.btnYoutbe.ImageActive = null;
            this.btnYoutbe.Location = new System.Drawing.Point(1, 350);
            this.btnYoutbe.Name = "btnYoutbe";
            this.btnYoutbe.Size = new System.Drawing.Size(35, 35);
            this.btnYoutbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnYoutbe.TabIndex = 3;
            this.btnYoutbe.TabStop = false;
            this.btnYoutbe.Zoom = 10;
            this.btnYoutbe.Click += new System.EventHandler(this.btnYoutbe_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageActive = null;
            this.btnGo.Location = new System.Drawing.Point(220, 127);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(50, 50);
            this.btnGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGo.TabIndex = 5;
            this.btnGo.TabStop = false;
            this.btnGo.Zoom = 10;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.Transparent;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageActive = null;
            this.btnPaste.Location = new System.Drawing.Point(435, 56);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(50, 50);
            this.btnPaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPaste.TabIndex = 4;
            this.btnPaste.TabStop = false;
            this.btnPaste.Zoom = 10;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // pictureBoxSoundCloud
            // 
            this.pictureBoxSoundCloud.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSoundCloud.Image")));
            this.pictureBoxSoundCloud.Location = new System.Drawing.Point(181, 241);
            this.pictureBoxSoundCloud.Name = "pictureBoxSoundCloud";
            this.pictureBoxSoundCloud.Size = new System.Drawing.Size(126, 88);
            this.pictureBoxSoundCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSoundCloud.TabIndex = 2;
            this.pictureBoxSoundCloud.TabStop = false;
            this.pictureBoxSoundCloud.Visible = false;
            // 
            // progress
            // 
            this.progress.animated = false;
            this.progress.animationIterval = 5;
            this.progress.animationSpeed = 20;
            this.progress.BackColor = System.Drawing.Color.Transparent;
            this.progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress.BackgroundImage")));
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progress.ForeColor = System.Drawing.Color.SeaGreen;
            this.progress.LabelVisible = false;
            this.progress.LineProgressThickness = 8;
            this.progress.LineThickness = 5;
            this.progress.Location = new System.Drawing.Point(145, 184);
            this.progress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progress.MaxValue = 100;
            this.progress.Name = "progress";
            this.progress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.progress.Size = new System.Drawing.Size(201, 201);
            this.progress.TabIndex = 1;
            this.progress.Value = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(460, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(497, 388);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnYoutbe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbAmbao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.txbLink);
            this.Controls.Add(this.pictureBoxSoundCloud);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.panelTieude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundCloud Downloader 1.0";
            this.panelTieude.ResumeLayout(false);
            this.panelTieude.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYoutbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoundCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelTieude;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTieude;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.PictureBox pictureBoxSoundCloud;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbLink;
        private Bunifu.Framework.UI.BunifuImageButton btnGo;
        private Bunifu.Framework.UI.BunifuImageButton btnPaste;
        private Bunifu.Framework.UI.BunifuCheckbox ckbAmbao;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnYoutbe;
        private Bunifu.Framework.UI.BunifuImageButton btnEmail;
        private Bunifu.Framework.UI.BunifuImageButton btnWeb;
    }
}

