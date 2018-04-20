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
    using Bunifu.Framework.UI;

    using Project_Karaoke_3layers_LTQL.DAO;
    using Project_Karaoke_3layers_LTQL.DTO;

    public partial class OfferDrink : UserControl
    {
        #region Method

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
        public OfferDrink()
        {
            InitializeComponent();
            this.LoadRoom();
            
        }

        void LoadRoom() // Load phòng, hiển thị ra từng button
        {
            List<Room> roomList = RoomDAO.Instance.loadRoomList(); // lấy được danh sách room
            foreach (Room item in roomList)
            {
                BunifuFlatButton bnt =new BunifuFlatButton();
                bnt.BackColor = Color.BlueViolet;
                bnt.IconVisible = false;
                bnt.TextFont = new Font("Noto Sans", 14, FontStyle.Regular); 
                bnt.Textcolor = Color.White;
                bnt.Height = RoomDAO.roomHeight;
                bnt.Width = RoomDAO.roomWidth;
                bnt.BorderRadius = 7;
                var margin = bnt.Margin;
                margin.Left = 15;
                margin.Top = 10;
                bnt.Margin = margin;
                this.flpRoom.Controls.Add(bnt);
                
            }

        }

        #endregion //---------------------------------------------------------------------------------------------------------------------------------------------------------


        #region Events

        private void OfferDrink_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDrinkEdit_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }//
}//
