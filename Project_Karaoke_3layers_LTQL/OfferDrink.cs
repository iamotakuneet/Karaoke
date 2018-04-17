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
    public partial class OfferDrink : UserControl
    {
        private static OfferDrink _instance;

        public static OfferDrink Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OfferDrink();
                return _instance;
            }
        }
        public OfferDrink() => InitializeComponent();

        private void OfferDrink_Load(object sender, EventArgs e)
        {

        }
    }
}
