using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Karaoke_3layers_LTQL
{
    public partial class Alert : Form
    {
        public Alert() => InitializeComponent();

        private void bunifuCustomLabel1_Click(object sender, EventArgs e) { }
        

        private void bunifuFlatButton1_Click(object sender, EventArgs e) => Application.Exit();


        private void buttonAlertCancel_Click(object sender, EventArgs e) => Close();


        private void pictureBox1_Click(object sender, EventArgs e) { }


        private void frmAlert_Load(object sender, EventArgs e) => Opacity = 0.92;


        private bool _mouseDown;

        public Point LastLocation { get => GetLastLocation1(); set => SetLastLocation1(value); }

        public Point GetLastLocation1() => GetLastLocation2();

        public void SetLastLocation1(Point value) => SetLastLocation2(value);

        public Point GetLastLocation2() => LastLocation3;

        public void SetLastLocation2(Point value) => LastLocation3 = value;

        public Point LastLocation3 { get; set; }

        public bool GetMouseDown1() => _mouseDown;

        public void SetMouseDown1(bool value)
        {
            _mouseDown = value;
        }

        private void FrmAlert_MouseDown(object sender, MouseEventArgs e)
        {
            SetMouseDown1(true);
            LastLocation = e.Location;
        }

        private void FrmAlert_MouseMove(object sender, MouseEventArgs e)
        {
            if (!GetMouseDown1()) return;
            Location = new Point(
                (Location.X - LastLocation.X) + e.X, (Location.Y - LastLocation.Y) + e.Y);

            Update();
        }

        private void frmAlert_MouseUp(object sender, MouseEventArgs e) => SetMouseDown1(false);
    }
}
