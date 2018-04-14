using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Project_Karaoke_3layers_LTQL
{
    partial class FrmLoginAlert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginAlert));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.waifu1 = new System.Windows.Forms.PictureBox();
            this.labelMessage = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.KiemSoatKeo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.thoiGianHienForm = new System.Windows.Forms.Timer(this.components);
            this.waifu2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.show = new System.Windows.Forms.Timer(this.components);
            this.thongBaoTat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.waifu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waifu2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "loli 3.png");
            this.imageList1.Images.SetKeyName(1, "loli 7.png");
            // 
            // waifu1
            // 
            this.waifu1.BackColor = System.Drawing.Color.Transparent;
            this.waifu1.Image = ((System.Drawing.Image)(resources.GetObject("waifu1.Image")));
            this.waifu1.Location = new System.Drawing.Point(0, 0);
            this.waifu1.Name = "waifu1";
            this.waifu1.Size = new System.Drawing.Size(137, 138);
            this.waifu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.waifu1.TabIndex = 0;
            this.waifu1.TabStop = false;
            this.waifu1.Click += new System.EventHandler(this.waifu1_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.labelMessage.Location = new System.Drawing.Point(143, 30);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(194, 44);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "welcome back";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMessage.UseCompatibleTextRendering = true;
            this.labelMessage.Click += new System.EventHandler(this.labelMessage_Click);
            // 
            // KiemSoatKeo
            // 
            this.KiemSoatKeo.Fixed = true;
            this.KiemSoatKeo.Horizontal = true;
            this.KiemSoatKeo.TargetControl = this;
            this.KiemSoatKeo.Vertical = true;
            // 
            // thoiGianHienForm
            // 
            this.thoiGianHienForm.Enabled = true;
            this.thoiGianHienForm.Interval = 1800;
            this.thoiGianHienForm.Tick += new System.EventHandler(this.timeout_Tick);
            // 
            // waifu2
            // 
            this.waifu2.Image = ((System.Drawing.Image)(resources.GetObject("waifu2.Image")));
            this.waifu2.Location = new System.Drawing.Point(343, 0);
            this.waifu2.Name = "waifu2";
            this.waifu2.Size = new System.Drawing.Size(138, 138);
            this.waifu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.waifu2.TabIndex = 2;
            this.waifu2.TabStop = false;
            this.waifu2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("The Girl Next Door", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(150, 67);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(179, 76);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Onii Chan";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel1.UseCompatibleTextRendering = true;
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // show
            // 
            this.show.Tick += new System.EventHandler(this.show_Tick);
            // 
            // thongBaoTat
            // 
            this.thongBaoTat.Interval = 125;
            this.thongBaoTat.Tick += new System.EventHandler(this.Close_Tick);
            // 
            // FrmLoginAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 138);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.waifu2);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.waifu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoginAlert";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login Alert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLoginAlert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waifu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waifu2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuElipse bunifuElipse1;
        private BunifuCustomLabel labelMessage;
        private PictureBox waifu1;
        private ImageList imageList1;
        private BunifuDragControl KiemSoatKeo;
        private PictureBox waifu2;
        private BunifuCustomLabel bunifuCustomLabel1;
        private Timer show;
        private Timer thongBaoTat;
        private Timer thoiGianHienForm;
    }
}