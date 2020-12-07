using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeShop.DTO
{
    public class TableDTO
    {
        // Constructor
        public TableDTO(int id, string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }

        // Chuyển dữ liệu dạng 1 table thành 1 list các dòng 
        public TableDTO(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.status = row["status"].ToString();
        }


        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }



       

    }

   
}
