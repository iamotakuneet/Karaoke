using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project_Karaoke_3layers_LTQL.DAO
{
  

    public class AccountDAO
    {
        public string userType;
        private  static AccountDAO instance;

        public static AccountDAO Instance //SingleTon
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.Instance; }
            private set => AccountDAO.Instance = value;
        }
        private AccountDAO() { }

        public bool Login(string userName, string passWord) // Xữ lý ở tầng DAO rồi đem lên form chạy
        {
            string queryLogin = "SELECT * FROM dbo.Account WHERE userName=N'" + userName + "' AND passWord =N'" + passWord + "'"; // Kiểm tra tk và mk    
            DataTable result = DataProvider.Instance.ExecuteQuery(queryLogin); //cho result = số dòng thành công trả về
            return result.Rows.Count>0; //nếu số dòng trả ra > 0 thì true
        }

        private string checkType(string userName, string passWord)
        {
            string queryUserType = "SELECT type FROM dbo.Account WHERE userName=N'" + userName + "' AND passWord =N'" + passWord + "'"; // lấy loại user
            this.userType = DataProvider.Instance.ExecuteQuery(queryUserType).ToString();
            return this.userType;
        }
    }//
}//
