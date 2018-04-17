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
    public partial class BookRoom : UserControl
    {
        private static BookRoom _instance;

        public static BookRoom Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BookRoom();
                return _instance;
            }
        }

        public BookRoom()
        {
            InitializeComponent();
        }

        private void BookRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
