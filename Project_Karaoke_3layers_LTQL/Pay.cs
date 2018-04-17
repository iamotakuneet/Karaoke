using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Karaoke_3layers_LTQL
{
    public partial class Pay : UserControl
    {
        private static Pay _instance;

        public static Pay Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Pay();
                return _instance;
            }
        }

        public Pay() => InitializeComponent();

        private void Pay_Load(object sender, EventArgs e)
        {

        }
    }
}
