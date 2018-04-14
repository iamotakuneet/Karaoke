using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Project_Karaoke_3layers_LTQL.Properties;
using System.Data.SqlClient;

namespace Project_Karaoke_3layers_LTQL
{
    public partial class FrmMain : Form
    {
        public FrmMain() => InitializeComponent();

        DataSet ds;
        SqlDataAdapter daRoom;
        

        private void frmMain_Load(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Resources.nicoNicoNi);
            audio.Play();
            Form fLoginAlert = new FrmLoginAlert();
            fLoginAlert.ShowDialog();
            FLogin L=new FLogin();
            if (L.UserAdmin == false) hideAdmin();                
            buttonAdmin.selected = true;
            buttonShow.Visible = false;
            string sConnect = @"Data Source=()"; //chuỗi kết nối
            string sSelect = @""; //chuỗi truy vấn
            //daRoom = new SqlDataAdapter(sSelect,sConnect); //khợi tạo đối tượng sqlDA để truy vấn lấy dữ liệu tự database về
           // ds =new DataSet("");
            //daRoom.Fill(ds, "tblRoom"); // đổ dữ liệu vào  1 bảng trong dataset

        }

        private void hideAdmin()
        {
                buttonAdmin.Visible = false;
                buttonBookRoom.Location = new Point(0, 108);
                buttonChangeRoom.Location = new Point(0, 174);
                buttonOfferDrink.Location = new Point(0, 243);
                buttonPay.Location = new Point(0, 312);
                buttonLogOut.Location = new Point(0, 381);
                processBarRoom.Location = new Point(50, 479);
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
            FLogin L = new FLogin();
            if (L.UserAdmin == false)
                processBarRoom.Location = new Point(0, 518);
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
                FLogin L = new FLogin();
                if (L.UserAdmin == false)
                    processBarRoom.Location = new Point(50, 479);
                processBarRoom.LineThickness = 5;
                processBarRoom.LineProgressThickness = 7 ;
                hideSlide.ShowSync(slideMenu);
                processBarRoom.Visible = true;              
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e) { }

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

        private void buttonPay_Click(object sender, EventArgs e) { }

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

        
    }
}
