using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Project_Karaoke_3layers_LTQL.Properties;

namespace Project_Karaoke_3layers_LTQL
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }
        Admin ucAdmin = new Admin();
        BookRoom ucBookRoom = new BookRoom();
        ChangeRoom uChangeRoom = new ChangeRoom();
        OfferDrink ucOfferDrink = new OfferDrink();
        Pay ucPay = new Pay();
        private void frmMain_Load(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Resources.nicoNicoNi);
            audio.Play();
            Form fLoginAlert = new FrmLoginAlert();
            fLoginAlert.ShowDialog();        
            buttonAdmin.selected = true;
            buttonShow.Visible = false;
        }

        public FrmMain(IContainer components, Panel panelLeft, Panel panelTop, PictureBox pictureBox1, Panel panelDashBoard, BunifuImageButton bunifuImageButton1)
        {
            this.components = components;
            this.panelLeft = panelLeft;
            panelHeader = panelTop;
            Logo = pictureBox1;
            slideMenu = panelDashBoard;
            buttonMenu = bunifuImageButton1;
        }

        private void panelDashBoard_Paint(object sender, PaintEventArgs e) { }

        private void panelLeft_Paint(object sender, PaintEventArgs e) { }

        private void playAudio() // function lấy âm thanh từ Resouces
        {
            SoundPlayer audio = new SoundPlayer(Resources.customSound);
            audio.Play();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            //Ẩn Slide;
            slideMenu.Width = 73;
            playAudio();
            buttonShow.Visible = true;
            processBarRoom.Font = new Font("Noto Sans", 12, FontStyle.Regular);
            processBarRoom.Size = new Size(75, 75);
            processBarRoom.Location = new Point(0, 560);
            processBarRoom.LineThickness = 3;
            processBarRoom.LineProgressThickness = 4;
            slideMenu.Visible = false;
            hideSlide.ShowSync(slideMenu);        
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (slideMenu.Width == 73)
            {
                //Hiện Side
                slideMenu.Width = 255;
                playAudio();
                buttonShow.Visible = false;
                slideMenu.Visible = false;
                processBarRoom.Font = new Font("Noto Sans", 26, FontStyle.Regular);
                processBarRoom.Size = new Size(150, 150);
                processBarRoom.Location = new Point(50, 520);
                processBarRoom.LineThickness = 5;
                processBarRoom.LineProgressThickness = 7 ;
                hideSlide.ShowSync(slideMenu);
                processBarRoom.Visible = true;              
            }
        }

       

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Resources.Minimize);
            audio.Play();
            WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Resources.oniiChan2);
            audio.Play();
            Alert frmAlert = new Alert();
            frmAlert.ShowDialog();
        }

     

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            // Ẩn form xuống tray icon
            if (FormWindowState.Minimized == WindowState)
            {
                notifyInTrayIcon.Visible = true;
                ShowInTaskbar = false;
                notifyInTrayIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyInTrayIcon.BalloonTipText = @"Weaboo";
                notifyInTrayIcon.BalloonTipTitle = @"Notifition!";
            }
            else if (FormWindowState.Normal == WindowState)
                notifyInTrayIcon.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Nhấn vào icon sẽ hiện form
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            FLogin frmLogin =new FLogin();
            frmLogin.FormClosed += frmLogin_FormClosed;
            frmLogin.Show();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e) => Close();

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(Admin.Instance))
            {
                panelMain.Controls.Add(Admin.Instance);
                Admin.Instance.Dock = DockStyle.Fill;
                Admin.Instance.BringToFront();
            }
            else
            {
                Admin.Instance.BringToFront();
            }
        }

        private void buttonBookRoom_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonChangeRoom_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(ChangeRoom.Instance))
            {
                panelMain.Controls.Add(ChangeRoom.Instance);
                ChangeRoom.Instance.Dock = DockStyle.Fill;
                ChangeRoom.Instance.BringToFront();
            }
            else
            {
                ChangeRoom.Instance.BringToFront();
            }
        }

        private void buttonBookRoom_Click_1(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(BookRoom.Instance))
            {
                panelMain.Controls.Add(BookRoom.Instance);
                BookRoom.Instance.Dock = DockStyle.Fill;
                BookRoom.Instance.BringToFront();
            }
            else
            {
                BookRoom.Instance.BringToFront();
            }
        }

        private void buttonOfferDrink_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(OfferDrink.Instance))
            {
                panelMain.Controls.Add(OfferDrink.Instance);
                Admin.Instance.Dock = DockStyle.Fill;
                Admin.Instance.BringToFront();
            }
            else
            {
                OfferDrink.Instance.BringToFront();
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(Pay.Instance))
            {
                panelMain.Controls.Add(Pay.Instance);
                Pay.Instance.Dock = DockStyle.Fill;
                Pay.Instance.BringToFront();
            }
            else
            {
                Pay.Instance.BringToFront();
            }
        }


    }//
}//
