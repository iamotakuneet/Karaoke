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

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchDrink_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
