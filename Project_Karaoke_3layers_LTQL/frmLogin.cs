using System;

using System.Media;
using System.Windows.Forms;
using MetroFramework.Forms;
using Project_Karaoke_3layers_LTQL.Properties;

namespace Project_Karaoke_3layers_LTQL
{
    using Project_Karaoke_3layers_LTQL.DAO;

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

        bool Login(string userName, string passWord)
        {

            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = this.txtLoginUser.Text;
            string passWord = this.txtLoginPassword.Text;
            if (this.Login(userName,passWord))
            {
                Hide();
                FrmMain fm = new FrmMain();
                fm.FormClosed += fm_FormClosed;
                fm.Show();
                UserAdmin = true;   
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
