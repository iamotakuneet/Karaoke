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
    public partial class Admin : UserControl
    {
        private static Admin _instance;

        public static Admin Instance
        {
            get
            {
                if(_instance==null)
                    _instance=new Admin();
                return _instance;
            }
        }
        public Admin() => InitializeComponent();

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
