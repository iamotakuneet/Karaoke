using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;

namespace Project_Karaoke_3layers_LTQL
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.buttonLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtLoginPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLoginUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonShowPassWord = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelUserPW = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShowPassWord)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(295, 223);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 1;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.BorderRadius = 0;
            this.buttonLogin.ButtonText = "Login";
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLogin.Iconimage = null;
            this.buttonLogin.Iconimage_right = null;
            this.buttonLogin.Iconimage_right_Selected = null;
            this.buttonLogin.Iconimage_Selected = null;
            this.buttonLogin.IconMarginLeft = 0;
            this.buttonLogin.IconMarginRight = 0;
            this.buttonLogin.IconRightVisible = true;
            this.buttonLogin.IconRightZoom = 0D;
            this.buttonLogin.IconVisible = true;
            this.buttonLogin.IconZoom = 90D;
            this.buttonLogin.IsTab = false;
            this.buttonLogin.Location = new System.Drawing.Point(36, 369);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.buttonLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.buttonLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLogin.selected = false;
            this.buttonLogin.Size = new System.Drawing.Size(334, 41);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLogin.Textcolor = System.Drawing.Color.White;
            this.buttonLogin.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoginPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtLoginPassword.HintText = "Enter password...";
            this.txtLoginPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLoginPassword.isPassword = true;
            this.txtLoginPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.txtLoginPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.txtLoginPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.txtLoginPassword.LineThickness = 4;
            this.txtLoginPassword.Location = new System.Drawing.Point(58, 283);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(288, 44);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginPassword.OnValueChanged += new System.EventHandler(this.txtLoginPassword_OnValueChanged);
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoginUser.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtLoginUser.HintText = "Enter user name...";
            this.txtLoginUser.isPassword = false;
            this.txtLoginUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.txtLoginUser.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.txtLoginUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.txtLoginUser.LineThickness = 4;
            this.txtLoginUser.Location = new System.Drawing.Point(58, 203);
            this.txtLoginUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(288, 44);
            this.txtLoginUser.TabIndex = 1;
            this.txtLoginUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buttonShowPassWord
            // 
            this.buttonShowPassWord.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowPassWord.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowPassWord.Image")));
            this.buttonShowPassWord.ImageActive = null;
            this.buttonShowPassWord.Location = new System.Drawing.Point(353, 293);
            this.buttonShowPassWord.Name = "buttonShowPassWord";
            this.buttonShowPassWord.Size = new System.Drawing.Size(34, 34);
            this.buttonShowPassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonShowPassWord.TabIndex = 7;
            this.buttonShowPassWord.TabStop = false;
            this.buttonShowPassWord.Zoom = 10;
            this.buttonShowPassWord.MouseLeave += new System.EventHandler(this.buttonShowPassWord_MouseLeave);
            this.buttonShowPassWord.MouseHover += new System.EventHandler(this.buttonShowPassWord_MouseHover);
            // 
            // labelUserPW
            // 
            this.labelUserPW.AutoSize = true;
            this.labelUserPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUserPW.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPW.ForeColor = System.Drawing.Color.Red;
            this.labelUserPW.Location = new System.Drawing.Point(97, 434);
            this.labelUserPW.Name = "labelUserPW";
            this.labelUserPW.Size = new System.Drawing.Size(218, 19);
            this.labelUserPW.TabIndex = 9;
            this.labelUserPW.Text = "user or password not correct!";
            this.labelUserPW.Visible = false;
            // 
            // FLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 504);
            this.Controls.Add(this.labelUserPW);
            this.Controls.Add(this.buttonShowPassWord);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLogin";
            this.Text = "LOG IN";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShowPassWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private DoubleBitmapControl doubleBitmapControl1;
        private BunifuFlatButton buttonLogin;
        private BunifuMaterialTextbox txtLoginPassword;
        private BunifuMaterialTextbox txtLoginUser;
        private BunifuImageButton buttonShowPassWord;
        private BunifuCustomLabel labelUserPW;
    }
}

