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
      
        private  static AccountDAO instance;

        public static AccountDAO Instance //SingleTon
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set => AccountDAO.instance = value;
        }
        private AccountDAO() { }

        public int checkType(string userName, string passWord)
        {
            string queryUserType = "USP_Login @userName , @passWord"; //dùng Proc để tránh lỗi SQL injection
            int userType = int.Parse(DataProvider.Instance.ExecuteQuery(queryUserType, new object[] { userName, passWord }).ToString()); //ép về kiểu int
            return userType;
        }

        public bool Login(string userName, string passWord) // Xữ lý ở tầng DAO rồi đem lên form chạy
        {
            string queryLogin = "USP_Login @userName , @passWord"; //dùng Proc để tránh lỗi SQL injection
            DataTable result = DataProvider.Instance.ExecuteQuery(queryLogin, new object[]{userName,passWord}); //cho result = số dòng thành công trả về
            return result.Rows.Count>0; //nếu số dòng trả ra > 0 thì true
        }


    }//
}//
