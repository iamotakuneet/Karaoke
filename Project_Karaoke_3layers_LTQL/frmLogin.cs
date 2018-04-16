using System;
using System.Media;
using System.Windows.Forms;
using MetroFramework.Forms;
using Project_Karaoke_3layers_LTQL.Properties;

namespace Project_Karaoke_3layers_LTQL
{
    public partial class FLogin : MetroForm
    {
        public FLogin() => InitializeComponent();

        private void fLogin_Load(object sender, EventArgs e) { }

        public bool UserAdmin;

        private void errorLoginAudio() // function lấy âm thanh từ Resouces
        {
            SoundPlayer audio = new SoundPlayer(Resources.oniiChan);
            audio.Play();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginUser.Text == @"adminLoli" && txtLoginPassword.Text == @"iamgay")
            {
                Hide();
                FrmMain fm = new FrmMain();
                fm.FormClosed += fm_FormClosed;
                fm.Show();
                UserAdmin = true;
            }
            else if (txtLoginUser.Text == @"userLoli" && txtLoginPassword.Text == @"iamgay")
            {
                Hide();
                FrmMain fm = new FrmMain();
                fm.FormClosed += fm_FormClosed;
                fm.Show();
                
                UserAdmin = false;
            }

            else
            {
                errorLoginAudio();
                labelUserPW.Visible = true;              
            }
        }

        private void fm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void txtLoginPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (txtLoginPassword.Text!= txtLoginPassword.HintText)
                txtLoginPassword.isPassword = true;
        }

        private void buttonShowPassWord_MouseHover(object sender, EventArgs e) => txtLoginPassword.isPassword = false;

        private void buttonShowPassWord_MouseLeave(object sender, EventArgs e) => txtLoginPassword.isPassword = true;


    }//

}//
