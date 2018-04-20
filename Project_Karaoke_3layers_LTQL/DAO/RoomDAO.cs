using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Karaoke_3layers_LTQL.DAO
{
    using System.Data;

    using Project_Karaoke_3layers_LTQL.DTO;

    public class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get
            {
                if (instance==null)
                {
                    instance=new RoomDAO();
                }

                return RoomDAO.instance;
            }
            private set => RoomDAO.instance = value;
        }

        public static int roomWidth = 275;

        public static int roomHeight = 150;

        private RoomDAO() { }

        public List<Room> loadRoomList() // lấy room từ DTO lên
        {
            List<Room> roomList =new List<Room>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomList"); // lấy room từ sql
            foreach (DataRow item in data.Rows) //cho mỗi datarow trong data.row, lấy ra từng dòng
            {
               Room room =new Room(item); 
               roomList.Add(room); // đã có danh sách bàn
            }

            return roomList;
        }

    }//
}//
