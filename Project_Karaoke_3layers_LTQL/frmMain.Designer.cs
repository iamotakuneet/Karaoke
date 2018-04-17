using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;

namespace Project_Karaoke_3layers_LTQL
{
    partial class FrmMain
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.buttonShow = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.Home = new System.Windows.Forms.PictureBox();
            this.slideMenu = new System.Windows.Forms.Panel();
            this.buttonAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.processBarRoom = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.buttonOfferDrink = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonChangeRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBookRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragcontrol2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl5 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.hideSlide = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.notifyInTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.dragControl7 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl6 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.hideProcessBarRoom = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.BorderRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.slideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.hideProcessBarRoom.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.hideSlide.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.panelLeft.Location = new System.Drawing.Point(236, 147);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 53);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Visible = false;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.panelHeader.Controls.Add(this.buttonMinimize);
            this.panelHeader.Controls.Add(this.bunifuCustomLabel1);
            this.panelHeader.Controls.Add(this.buttonShow);
            this.panelHeader.Controls.Add(this.buttonExit);
            this.hideProcessBarRoom.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.hideSlide.SetDecoration(this.panelHeader, BunifuAnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1330, 38);
            this.panelHeader.TabIndex = 1;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.hideProcessBarRoom.SetDecoration(this.buttonMinimize, BunifuAnimatorNS.DecorationType.None);
            this.hideSlide.SetDecoration(this.buttonMinimize, BunifuAnimatorNS.DecorationType.None);
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.ImageActive = null;
            this.buttonMinimize.Location = new System.Drawing.Point(1264, 9);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(24, 24);
            this.buttonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimize.TabIndex = 3;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Zoom = 10;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.hideSlide.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.hideProcessBarRoom.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(76, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(124, 22);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Sliding Menu";
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.Transparent;
            this.hideProcessBarRoom.SetDecoration(this.buttonShow, BunifuAnimatorNS.DecorationType.None);
            this.hideSlide.SetDecoration(this.buttonShow, BunifuAnimatorNS.DecorationType.None);
            this.buttonShow.Image = ((System.Drawing.Image)(resources.GetObject("buttonShow.Image")));
            this.buttonShow.ImageActive = null;
            this.buttonShow.Location = new System.Drawing.Point(22, 9);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(24, 24);
            this.buttonShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonShow.TabIndex = 0;
            this.buttonShow.TabStop = false;
            this.buttonShow.Zoom = 10;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.hideProcessBarRoom.SetDecoration(this.buttonExit, BunifuAnimatorNS.DecorationType.None);
            this.hideSlide.SetDecoration(this.buttonExit, BunifuAnimatorNS.DecorationType.None);
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageActive = null;
            this.buttonExit.Location = new System.Drawing.Point(1294, 9);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(24, 24);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonExit.TabIndex = 4;
            this.buttonExit.TabStop = false;
            this.buttonExit.Zoom = 10;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.hideSlide.SetDecoration(this.Home, BunifuAnimatorNS.DecorationType.None);
            this.hideProcessBarRoom.SetDecoration(this.Home, BunifuAnimatorNS.DecorationType.None);
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(3, 3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(70, 55);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home.TabIndex = 2;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // slideMenu
            // 
            this.slideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.slideMenu.Controls.Add(this.buttonAdmin);
            this.slideMenu.Controls.Add(this.processBarRoom);
            this.slideMenu.Controls.Add(this.buttonOfferDrink);
            this.slideMenu.Controls.Add(this.buttonChangeRoom);
            this.slideMenu.Controls.Add(this.buttonLogOut);
            this.slideMenu.Controls.Add(this.label1);
            this.slideMenu.Controls.Add(this.buttonBookRoom);
            this.slideMenu.Controls.Add(this.buttonPay);
            this.slideMenu.Controls.Add(this.buttonMenu);
            this.slideMenu.Controls.Add(this.Home);
            this.hideProcessBarRoom.SetDecoration(this.slideMenu, BunifuAnimatorNS.DecorationType.None);
            this.hideSlide.SetDecoration(this.slideMenu, BunifuAnimatorNS.DecorationType.None);
            this.slideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slideMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slideMenu.Location = new System.Drawing.Point(0, 38);
            this.slideMenu.Name = "slideMenu";
            this.slideMenu.Size = new System.Drawing.Size(255, 697);
            this.slideMenu.TabIndex = 0;
            this.slideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashBoard_Paint);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdmin.BorderRadius = 0;
            this.buttonAdmin.ButtonText = "Admin";
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideSlide.SetDecoration(this.buttonAdmin, BunifuAnimatorNS.DecorationType.None);
            this.hideProcessBarRoom.SetDecoration(this.buttonAdmin, BunifuAnimatorNS.DecorationType.None);
            this.buttonAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Iconimage")));
            this.buttonAdmin.Iconimage_right = null;
            this.buttonAdmin.Iconimage_right_Selected = null;
            this.buttonAdmin.Iconimage_Selected = null;
            this.buttonAdmin.IconMarginLeft = 18;
            this.buttonAdmin.IconMarginRight = 0;
            this.buttonAdmin.IconRightVisible = true;
            this.buttonAdmin.IconRightZoom = 0D;
            this.buttonAdmin.IconVisible = true;
            this.buttonAdmin.IconZoom = 70D;
            this.buttonAdmin.IsTab = true;
            this.buttonAdmin.Location = new System.Drawing.Point(0, 105);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(8);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.buttonAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAdmin.selected = false;
            this.buttonAdmin.Size = new System.Drawing.Size(255, 53);
            this.buttonAdmin.TabIndex = 2;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAdmin.Textcolor = System.Drawing.Color.White;
            this.buttonAdmin.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // processBarRoom
            // 
            this.processBarRoom.AllowDrop = true;
            this.processBarRoom.animated = true;
            this.processBarRoom.animationIterval = 1;
            this.processBarRoom.animationSpeed = 2;
            this.processBarRoom.AutoScroll = true;
            this.processBarRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.processBarRoom.BackColor = System.Drawing.Color.Transparent;
            this.processBarRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("processBarRoom.BackgroundImage")));
            this.hideProcessBarRoom.SetDecoration(this.processBarRoom, BunifuAnimatorNS.DecorationType.None);
            this.hideSlide.SetDecoration(this.processBarRoom, BunifuAnimatorNS.DecorationType.None);
            this.processBarRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.processBarRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.processBarRoom.LabelVisible = true;
            this.processBarRoom.LineProgressThickness = 8;
            this.processBarRoom.LineThickness = 5;
            this.processBarRoom.Location = new System.Drawing.Point(50, 529);
            this.processBarRoom.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.processBarRoom.MaxValue = 100;
            this.processBarRoom.Name = "processBarRoom";
            this.processBarRoom.ProgressBackColor = System.Drawing.Color.White;
            this.processBarRoom.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.processBarRoom.Size = new System.Drawing.Size(150, 150);
            this.processBarRoom.TabIndex = 0;
            this.processBarRoom.Value = 15;
            // 
            // buttonOfferDrink
            // 
            this.buttonOfferDrink.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.buttonOfferDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonOfferDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOfferDrink.BorderRadius = 0;
            this.buttonOfferDrink.ButtonText = "Offer Drink";
            this.buttonOfferDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideSlide.SetDecoration(this.buttonOfferDrink, BunifuAnimatorNS.DecorationType.None);
            this.hideProcessBarRoom.SetDecoration(this.buttonOfferDrink, BunifuAnimatorNS.DecorationType.None);
            this.buttonOfferDrink.DisabledColor = System.Drawing.Color.Gray;
            this.buttonOfferDrink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfferDrink.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonOfferDrink.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonOfferDrink.Iconimage")));
            this.buttonOfferDrink.Iconimage_right = null;
            this.buttonOfferDrink.Iconimage_right_Selected = null;
            this.buttonOfferDrink.Iconimage_Selected = null;
            this.buttonOfferDrink.IconMarginLeft = 15;
            this.buttonOfferDrink.IconMarginRight = 0;
            this.buttonOfferDrink.IconRightVisible = true;
            this.buttonOfferDrink.IconRightZoom = 0D;
            this.buttonOfferDrink.IconVisible = true;
            this.buttonOfferDrink.IconZoom = 66D;
            this.buttonOfferDrink.IsTab = true;
            this.buttonOfferDrink.Location = new System.Drawing.Point(0, 312);
            this.buttonOfferDrink.Margin = new System.Windows.Forms.Padding(8);
            this.buttonOfferDrink.Name = "buttonOfferDrink";
            this.buttonOfferDrink.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonOfferDrink.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.buttonOfferDrink.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonOfferDrink.selected = false;
            this.buttonOfferDrink.Size = new System.Drawing.Size(255, 53);
            this.buttonOfferDrink.TabIndex = 5;
            this.buttonOfferDrink.Text = "Offer Drink";
            this.buttonOfferDrink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOfferDrink.Textcolor = System.Drawing.Color.White;
            this.buttonOfferDrink.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfferDrink.Click += new System.EventHandler(this.buttonOfferDrink_Click);
            // 
            // buttonChangeRoom
            // 
            this.buttonChangeRoom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.buttonChangeRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonChangeRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChangeRoom.BorderRadius = 0;
            this.buttonChangeRoom.ButtonText = "   Change Room";
            this.buttonChangeRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideSlide.SetDecoration(this.buttonChangeRoom, BunifuAnimatorNS.DecorationType.None);
            this.hideProcessBarRoom.SetDecoration(this.buttonChangeRoom, BunifuAnimatorNS.DecorationType.None);
            this.buttonChangeRoom.DisabledColor = System.Drawing.Color.Gray;
            this.buttonChangeRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonChangeRoom.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonChangeRoom.Iconimage")));
            this.buttonChangeRoom.Iconimage_right = null;
            this.buttonChangeRoom.Iconimage_right_Selected = null;
            this.buttonChangeRoom.Iconimage_Selected = null;
            this.buttonChangeRoom.IconMarginLeft = 18;
            this.buttonChangeRoom.IconMarginRight = 0;
            this.buttonChangeRoom.IconRightVisible = true;
            this.buttonChangeRoom.IconRightZoom = 0D;
            this.buttonChangeRoom.IconVisible = true;
            this.buttonChangeRoom.IconZoom = 68D;
            this.buttonChangeRoom.IsTab = true;
            this.buttonChangeRoom.Location = new System.Drawing.Point(0, 174);
            this.buttonChangeRoom.Margin = new System.Windows.Forms.Padding(8);
            this.buttonChangeRoom.Name = "buttonChangeRoom";
            this.buttonChangeRoom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonChangeRoom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.buttonChangeRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonChangeRoom.selected = false;
            this.buttonChangeRoom.Size = new System.Drawing.Size(255, 53);
            this.buttonChangeRoom.TabIndex = 4;
            this.buttonChangeRoom.Text = "   Change Room";
            this.buttonChangeRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonChangeRoom.Textcolor = System.Drawing.Color.White;
            this.buttonChangeRoom.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeRoom.Click += new System.EventHandler(this.buttonChangeRoom_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogOut.BorderRadius = 0;
            this.buttonLogOut.ButtonText = "Log Out";
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideSlide.SetDecoration(this.buttonLogOut, BunifuAnimatorNS.DecorationType.None);
            this.hideProcessBarRoom.SetDecoration(this.buttonLogOut, BunifuAnimatorNS.DecorationType.None);
            this.buttonLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Iconimage")));
            this.buttonLogOut.Iconimage_right = null;
            this.buttonLogOut.Iconimage_right_Selected = null;
            this.buttonLogOut.Iconimage_Selected = null;
            this.buttonLogOut.IconMarginLeft = 18;
            this.buttonLogOut.IconMarginRight = 0;
            this.buttonLogOut.IconRightVisible = true;
            this.buttonLogOut.IconRightZoom = 0D;
            this.buttonLogOut.IconVisible = true;
            this.buttonLogOut.IconZoom = 70D;
            this.buttonLogOut.IsTab = true;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 450);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(8);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.buttonLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLogOut.selected = false;
            this.buttonLogOut.Size = new System.Drawing.Size(255, 53);
            this.buttonLogOut.TabIndex = 7;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLogOut.Textcolor = System.Drawing.Color.White;
            this.buttonLogOut.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.hideSlide.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.hideProcessBarRoom.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Karaoke";
            // 
            // buttonBookRoom
            // 
            this.buttonBookRoom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.buttonBookRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonBookRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBookRoom.BorderRadius = 0;
            this.buttonBookRoom.ButtonText = "    Book Room";
            this.buttonBookRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideSlide.SetDecoration(this.buttonBookRoom, BunifuAnimatorNS.DecorationType.None);
            this.hideProcessBarRoom.SetDecoration(this.buttonBookRoom, BunifuAnimatorNS.DecorationType.None);
            this.buttonBookRoom.DisabledColor = System.Drawing.Color.Gray;
            this.buttonBookRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonBookRoom.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonBookRoom.Iconimage")));
            this.buttonBookRoom.Iconimage_right = null;
            this.buttonBookRoom.Iconimage_right_Selected = null;
            this.buttonBookRoom.Iconimage_Selected = null;
            this.buttonBookRoom.IconMarginLeft = 18;
            this.buttonBookRoom.IconMarginRight = 0;
            this.buttonBookRoom.IconRightVisible = true;
            this.buttonBookRoom.IconRightZoom = 0D;
            this.buttonBookRoom.IconVisible = true;
            this.buttonBookRoom.IconZoom = 70D;
            this.buttonBookRoom.IsTab = true;
            this.buttonBookRoom.Location = new System.Drawing.Point(3, 243);
            this.buttonBookRoom.Margin = new System.Windows.Forms.Padding(8);
            this.buttonBookRoom.Name = "buttonBookRoom";
            this.buttonBookRoom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonBookRoom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.buttonBookRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonBookRoom.selected = false;
            this.buttonBookRoom.Size = new System.Drawing.Size(255, 53);
            this.buttonBookRoom.TabIndex = 3;
            this.buttonBookRoom.Text = "    Book Room";
            this.buttonBookRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonBookRoom.Textcolor = System.Drawing.Color.White;
            this.buttonBookRoom.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookRoom.Click += new System.EventHandler(this.buttonBookRoom_Click_1);
            // 
            // buttonPay
            // 
            this.buttonPay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.buttonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPay.BorderRadius = 0;
            this.buttonPay.ButtonText = "Pay";
            this.buttonPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideSlide.SetDecoration(this.buttonPay, BunifuAnimatorNS.DecorationType.None);
            this.hideProcessBarRoom.SetDecoration(this.buttonPay, BunifuAnimatorNS.DecorationType.None);
            this.buttonPay.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPay.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonPay.Iconimage")));
            this.buttonPay.Iconimage_right = null;
            this.buttonPay.Iconimage_right_Selected = null;
            this.buttonPay.Iconimage_Selected = null;
            this.buttonPay.IconMarginLeft = 18;
            this.buttonPay.IconMarginRight = 0;
            this.buttonPay.IconRightVisible = true;
            this.buttonPay.IconRightZoom = 0D;
            this.buttonPay.IconVisible = true;
            this.buttonPay.IconZoom = 70D;
            this.buttonPay.IsTab = true;
            this.buttonPay.Location = new System.Drawing.Point(0, 381);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(8);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonPay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.buttonPay.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPay.selected = false;
            this.buttonPay.Size = new System.Drawing.Size(255, 53);
            this.buttonPay.TabIndex = 6;
            this.buttonPay.Text = "Pay";
            this.buttonPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPay.Textcolor = System.Drawing.Color.White;
            this.buttonPay.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
            this.hideProcessBarRoom.SetDecoration(this.buttonMenu, BunifuAnimatorNS.DecorationType.None);
            this.hideSlide.SetDecoration(this.buttonMenu, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageActive = null;
            this.buttonMenu.Location = new System.Drawing.Point(220, 6);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(24, 24);
            this.buttonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.Zoom = 10;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // dragcontrol2
            // 
            this.dragcontrol2.Fixed = true;
            this.dragcontrol2.Horizontal = true;
            this.dragcontrol2.TargetControl = this.slideMenu;
            this.dragcontrol2.Vertical = true;
            // 
            // DragControl3
            // 
            this.DragControl3.Fixed = true;
            this.DragControl3.Horizontal = true;
            this.DragControl3.TargetControl = this.panelHeader;
            this.DragControl3.Vertical = true;
            // 
            // DragControl4
            // 
            this.DragControl4.Fixed = true;
            this.DragControl4.Horizontal = true;
            this.DragControl4.TargetControl = null;
            this.DragControl4.Vertical = true;
            // 
            // DragControl5
            // 
            this.DragControl5.Fixed = true;
            this.DragControl5.Horizontal = true;
            this.DragControl5.TargetControl = this.Home;
            this.DragControl5.Vertical = true;
            // 
            // hideSlide
            // 
            this.hideSlide.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.hideSlide.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.hideSlide.DefaultAnimation = animation2;
            this.hideSlide.Interval = 1;
            this.hideSlide.MaxAnimationTime = 800;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.hideProcessBarRoom.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.hideSlide.SetDecoration(this.panelMain, BunifuAnimatorNS.DecorationType.None);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(255, 38);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1075, 697);
            this.panelMain.TabIndex = 2;
            // 
            // notifyInTrayIcon
            // 
            this.notifyInTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyInTrayIcon.Icon")));
            this.notifyInTrayIcon.Text = "Quản lý karaoke";
            this.notifyInTrayIcon.Visible = true;
            this.notifyInTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // dragControl7
            // 
            this.dragControl7.Fixed = true;
            this.dragControl7.Horizontal = true;
            this.dragControl7.TargetControl = this.processBarRoom;
            this.dragControl7.Vertical = true;
            // 
            // DragControl6
            // 
            this.DragControl6.Fixed = true;
            this.DragControl6.Horizontal = true;
            this.DragControl6.TargetControl = null;
            this.DragControl6.Vertical = true;
            // 
            // hideProcessBarRoom
            // 
            this.hideProcessBarRoom.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.hideProcessBarRoom.Cursor = null;
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
            this.hideProcessBarRoom.DefaultAnimation = animation1;
            this.hideProcessBarRoom.Interval = 1;
            this.hideProcessBarRoom.MaxAnimationTime = 500;
            this.hideProcessBarRoom.TimeStep = 0.03F;
            // 
            // BorderRadius
            // 
            this.BorderRadius.ElipseRadius = 5;
            this.BorderRadius.TargetControl = this;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1330, 735);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.slideMenu);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.hideProcessBarRoom.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.hideSlide.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "Karaoke";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.slideMenu.ResumeLayout(false);
            this.slideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelLeft;
        private Panel panelHeader;
        private PictureBox Home;
        private Panel slideMenu;
        private BunifuImageButton buttonMenu;
        private BunifuFlatButton buttonAdmin;
        private BunifuDragControl DragControl;
        private BunifuDragControl dragcontrol2;
        private BunifuDragControl DragControl3;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BunifuFlatButton buttonPay;
        private BunifuDragControl DragControl4;
        private BunifuDragControl DragControl5;
        private BunifuTransition hideSlide;
        private BunifuImageButton buttonShow;
        private NotifyIcon notifyInTrayIcon;
        private BunifuFlatButton buttonBookRoom;
        private Label label1;
        private BunifuFlatButton buttonLogOut;
        private BunifuFlatButton buttonChangeRoom;
        private BunifuFlatButton buttonOfferDrink;
        private BunifuCircleProgressbar processBarRoom;
        private BunifuDragControl dragControl7;
        private BunifuDragControl DragControl6;
        private BunifuTransition hideProcessBarRoom;
        private BunifuImageButton buttonMinimize;
        private BunifuImageButton buttonExit;
        private BunifuElipse BorderRadius;
        private Panel panelMain;
    }
}