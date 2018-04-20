using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Project_Karaoke_3layers_LTQL
{
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonAlertAccept = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonAlertCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imageLoli = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // buttonAlertAccept
            // 
            this.buttonAlertAccept.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonAlertAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.buttonAlertAccept, "buttonAlertAccept");
            this.buttonAlertAccept.BorderRadius = 0;
            this.buttonAlertAccept.ButtonText = "Đồng ý";
            this.buttonAlertAccept.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAlertAccept.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAlertAccept.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAlertAccept.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonAlertAccept.Iconimage")));
            this.buttonAlertAccept.Iconimage_right = null;
            this.buttonAlertAccept.Iconimage_right_Selected = null;
            this.buttonAlertAccept.Iconimage_Selected = null;
            this.buttonAlertAccept.IconMarginLeft = 0;
            this.buttonAlertAccept.IconMarginRight = 0;
            this.buttonAlertAccept.IconRightVisible = true;
            this.buttonAlertAccept.IconRightZoom = 0D;
            this.buttonAlertAccept.IconVisible = true;
            this.buttonAlertAccept.IconZoom = 50D;
            this.buttonAlertAccept.IsTab = false;
            this.buttonAlertAccept.Name = "buttonAlertAccept";
            this.buttonAlertAccept.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.buttonAlertAccept.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.buttonAlertAccept.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAlertAccept.selected = false;
            this.buttonAlertAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAlertAccept.Textcolor = System.Drawing.Color.White;
            this.buttonAlertAccept.TextFont = new System.Drawing.Font("Noto Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlertAccept.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // buttonAlertCancel
            // 
            this.buttonAlertCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonAlertCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.buttonAlertCancel, "buttonAlertCancel");
            this.buttonAlertCancel.BorderRadius = 0;
            this.buttonAlertCancel.ButtonText = "Hủy";
            this.buttonAlertCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlertCancel.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAlertCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAlertCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonAlertCancel.Iconimage")));
            this.buttonAlertCancel.Iconimage_right = null;
            this.buttonAlertCancel.Iconimage_right_Selected = null;
            this.buttonAlertCancel.Iconimage_Selected = null;
            this.buttonAlertCancel.IconMarginLeft = 0;
            this.buttonAlertCancel.IconMarginRight = 0;
            this.buttonAlertCancel.IconRightVisible = true;
            this.buttonAlertCancel.IconRightZoom = 0D;
            this.buttonAlertCancel.IconVisible = true;
            this.buttonAlertCancel.IconZoom = 50D;
            this.buttonAlertCancel.IsTab = false;
            this.buttonAlertCancel.Name = "buttonAlertCancel";
            this.buttonAlertCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.buttonAlertCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.buttonAlertCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAlertCancel.selected = false;
            this.buttonAlertCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAlertCancel.Textcolor = System.Drawing.Color.White;
            this.buttonAlertCancel.TextFont = new System.Drawing.Font("Noto Sans", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlertCancel.Click += new System.EventHandler(this.buttonAlertCancel_Click);
            // 
            // imageLoli
            // 
            this.imageLoli.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLoli.ImageStream")));
            this.imageLoli.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLoli.Images.SetKeyName(0, "loli 2.png");
            // 
            // Alert
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.buttonAlertCancel);
            this.Controls.Add(this.buttonAlertAccept);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmAlert_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAlert_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAlert_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAlert_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuElipse bunifuElipse1;
        private PictureBox pictureBox1;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BunifuFlatButton buttonAlertAccept;
        private BunifuFlatButton buttonAlertCancel;
        private ImageList imageLoli;
    }
}