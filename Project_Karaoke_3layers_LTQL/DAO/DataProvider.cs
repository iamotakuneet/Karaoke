using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Project_Karaoke_3layers_LTQL.DAO
{
    class DataProvider
    {
        private string connectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=Karaoke;Integrated Security=True"; //chuỗi xác định kết nối đến thằng nào

        public DataTable ExecuteQuery(string query, object[] parameter =null ) //null chỉ có thể đưa vào những parameter ở sau cùng( có thể nhiều paramter, nhưng là 1 list parameter null)
        {
            DataTable dataTable = new DataTable(); //tạo ra table để chứa table lấy ở trong sql

            //sử dụng using thì kết thúc khối lệnh bên trong thì dữ liệu tự khai báo sẽ được giải phóng (SqlConnection connection = new SqlConnection(connectionSTR))
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // Là kết nối từ Client này xuống Server
            {
                connection.Open(); // Mở kết nối

                SqlCommand command = new SqlCommand(query, connection); // dùng để thực thi câu query trên connection đã tạo ở trên

                if (parameter != null) //parameter có thể null
                {
                    string[] listPara = query.Split(' '); // cắt theo khoảng trắng
                    int i = 0;
                    foreach (string item in listPara) // cho mỗi item trong list para
                    {
                        if (item.Contains('@')) // nếu có dấu @ thì thằng này có chứa parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]); 
                            i++;
                        }// có thể add n parameter
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command); //thằng trung gian thực hiện câu truy vấn để giúp lấy dữ liệu

                adapter.Fill(dataTable); //Đổ dữ liệu lấy ra vào dataTable. Lưu ý cần phải mở connection ra trước

                connection.Close();//Mở ra thì phải đóng, tránh tình trạng nhiều thằng cùng đổ về thì sẽ lỗi
            } 
            
            return dataTable;
        }//ExcuteQuery


        public int ExecuteNonQuery(string query, object[] parameter) //trả về sống dòng thành công
        {
            
            int data = 0;
            //sử dụng using thì kết thúc khối lệnh bên trong thì dữ liệu tự khai báo sẽ được giải phóng (SqlConnection connection = new SqlConnection(connectionSTR))
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // Là kết nối từ Client này xuống Server
            {
                connection.Open(); // Mở kết nối

                SqlCommand command = new SqlCommand(query, connection); // dùng để thực thi câu query trên connection đã tạo ở trên

                if (parameter != null) //parameter có thể null
                {
                    string[] listPara = query.Split(' '); // cắt theo khoảng trắng
                    int i = 0;
                    foreach (string item in listPara) // cho mỗi item trong list para
                    {
                        if (item.Contains('@')) // nếu có dấu @ thì thằng này có chứa parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }// có thể add n parameter
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();//Mở ra thì phải đóng, tránh tình trạng nhiều thằng cùng đổ về thì sẽ lỗi
            }

            return data;
        }//ExcuteNonQuery


        public object ExecuteScalar(string query, object[] parameter) //số lượng trả ra, phù hợp với select count(*)
        {

            object data = 0;
            //sử dụng using thì kết thúc khối lệnh bên trong thì dữ liệu tự khai báo sẽ được giải phóng (SqlConnection connection = new SqlConnection(connectionSTR))
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // Là kết nối từ Client này xuống Server
            {
                connection.Open(); // Mở kết nối

                SqlCommand command = new SqlCommand(query, connection); // dùng để thực thi câu query trên connection đã tạo ở trên

                if (parameter != null) //parameter có thể null
                {
                    string[] listPara = query.Split(' '); // cắt theo khoảng trắng
                    int i = 0;
                    foreach (string item in listPara) // cho mỗi item trong list para
                    {
                        if (item.Contains('@')) // nếu có dấu @ thì thằng này có chứa parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }// có thể add n parameter
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();//Mở ra thì phải đóng, tránh tình trạng nhiều thằng cùng đổ về thì sẽ lỗi
            }

            return data;
        }

    }// Dataprovider
}//
