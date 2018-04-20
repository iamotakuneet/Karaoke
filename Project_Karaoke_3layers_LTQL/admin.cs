using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_Karaoke_3layers_LTQL.DAO;

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
            LoadAccountList();
            LoadFoodList();
        }

        void LoadFoodList()
        {
            string query = "";// phải cách ra để k lỗi      
            this.dgvFoodAndDrink.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadAccountList()
        {
            string query = "EXEC dbo.USP_GetListAccountByUserName @userName";// phải cách ra để k lỗi        
            this.dgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query,new object[]{"neet"});
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDrinkEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDrinkView_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDrinkID_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDrinkAdd_Click(object sender, EventArgs e)
        {

        }

        private void tbDrink_Click(object sender, EventArgs e)
        {

        }

        private void tbRevenue_Click(object sender, EventArgs e)
        {

        }

        private void panelMainRevenue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDrink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void panelAccountHeaderMainLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
