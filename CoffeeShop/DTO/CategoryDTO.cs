using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class CategoryDTO
    {

        public CategoryDTO(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public CategoryDTO(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = (string)row["name"];
        }


        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
