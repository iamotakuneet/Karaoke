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

    using MetroFramework.Properties;

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

        //Pha mau`
        Color color = System.Drawing.ColorTranslator.FromHtml("#37474F"); // darkGray
        Color colorHoverEmpty = System.Drawing.ColorTranslator.FromHtml("#40C4FF"); // blue
        Color colorHoverFull = System.Drawing.ColorTranslator.FromHtml("#FF8A65");  // Orange


        void LoadRoom() // Load phòng, hiển thị ra từng button
        {
            List<Room> roomList = RoomDAO.Instance.loadRoomList(); // lấy được danh sách room
            foreach (Room item in roomList)
            {
                BunifuFlatButton bnt =new BunifuFlatButton();
                bnt.Text = item.Name + Environment.NewLine + item.Status;
                
                bnt.TextFont = new Font("Arial", 16, FontStyle.Regular); 
                bnt.Textcolor = Color.White;
                bnt.Height = RoomDAO.roomHeight;
                bnt.Width = RoomDAO.roomWidth;
                bnt.BorderRadius = 7;
                var margin = bnt.Margin;
                margin.Left = 15;
                margin.Top = 10;
                bnt.Margin = margin;
                switch (item.Status)
                {
                    case "Trống":
                        bnt.BackColor = this.color;
                        bnt.Normalcolor = this.color;
                        bnt.OnHovercolor = this.colorHoverEmpty;
                        bnt.Activecolor = this.colorHoverEmpty;
                        bnt.Iconimage = Image.FromFile(@"C:\Users\jeann\OneDrive\Desktop\GitHub\Karaoke\Project_Karaoke_3layers_LTQL\Resources\\Empty.png").GetThumbnailImage(100, 100, null, IntPtr.Zero);
                        bnt.IconZoom = 24;
                        break;
                    default:
                        bnt.BackColor = this.color;
                        bnt.Normalcolor = this.color;
                        bnt.OnHovercolor = this.colorHoverFull;
                        bnt.Activecolor = this.colorHoverFull;
                        bnt.Iconimage = Image.FromFile(@"C:\Users\jeann\OneDrive\Desktop\GitHub\Karaoke\Project_Karaoke_3layers_LTQL\Resources\\Full.png").GetThumbnailImage(100, 100, null, IntPtr.Zero);
                        bnt.IconZoom = 28;
                        break;
                       
                }
                
                
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
