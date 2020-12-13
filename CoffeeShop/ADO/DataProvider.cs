using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.ADO
{
    public class DataProvider
    {
        // Constructor
        private DataProvider() { }

        // Design singleton
        // Dung de khoi tao du lieu 1 lan duy nhat cho toan bo chuong trinh
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set { instance = value; }
        }


        private string connectionStr = "Data Source=TruongKhai\\SQLEXPRESS;Initial Catalog=CoffeeShopManagement;Integrated Security=True";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                // command chiu trach nhiem thuc thi truy van CRUD
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            // parameter truyen cac tham so an toan cho cau truy van
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        // ExcuteNonQuery chỉ trả về kết quả số dòng dữ liệu bị ảnh hưởng. (update, insert, delete)
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                // command chiu trach nhiem thuc thi truy van CRUD
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            // truyền mảng parameter vào item tương ứng: @username = 'Admin'
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        // ExcuteScalar thi hành câu lệnh Sql trả về giá trị là cột đầu tiên của dòng đầu tiên
        public object ExecuteScalarQuery(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                // command chiu trach nhiem thuc thi truy van CRUD
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            // parameter truyen cac tham so an toan cho cau truy van
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
