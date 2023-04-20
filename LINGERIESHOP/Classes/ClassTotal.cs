using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LINGERIESHOP.Classes
{
    
    public class ClassTotal
    {
        public static string connectionString = @"Data Source=RODION_GETICO\SQLEXPRESS; Initial Catalog= swimSuitShop; Integrated Security=True";

        public static int Act_idUser;
        public static string Act_loginUser = "null";
        public static int Act_idRole;

        public static int wallet; 

        public static int inLimit = 4;
    }
    public class Category
    {
        public string name { get; set; }
        public BitmapImage PhotoCat { get; set; }
    }

    public class Product
    {
        public BitmapImage Photo { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Uid { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string Structure { get; set; }
        public string Information { get; set; }
    }

    public class ProductsInOrder : Product
    {
        public int Count { get; set; }
        public int Costing { get; set; }
    }
}
