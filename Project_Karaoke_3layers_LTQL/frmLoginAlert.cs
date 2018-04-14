using System;
using System.Windows.Forms;

namespace Project_Karaoke_3layers_LTQL
{
    public partial class FrmLoginAlert : Form
    {
        public FrmLoginAlert() => InitializeComponent();


        private void frmLoginAlert_Load(object sender, EventArgs e)
        {
            // set vị trí góc trên bên phải
            Top = 35;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 25;
        }


        private void timeout_Tick(object sender, EventArgs e) => Close();
        

        private void labelMessage_Click(object sender, EventArgs e) { }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e) { }
        

        private int _thoigian;

        private void show_Tick(object sender, EventArgs e)
        {
            //show transition
            if (Top < 70)
            {
                Top += _thoigian; // ẩn thông báo
                _thoigian += 2;  //tăng tốc độ
            }
            else
                show.Stop();

        }

        private void Close_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
                Opacity -= 0.1;
            else
                Close();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            waifu2.Image = imageList1.Images[1];
            thongBaoTat.Start();
        }

        private void waifu1_Click(object sender, EventArgs e)
        {
            waifu1.Image = imageList1.Images[0];
            thongBaoTat.Start();
        }
    }
}
