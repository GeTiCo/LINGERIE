using LINGERIESHOP.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Word = Microsoft.Office.Interop.Word;

namespace LINGERIESHOP
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string pathExe = Environment.CurrentDirectory;

        public static Word.Application wordApp;
        public static Word.Document wordDoc;
        public static Word.Paragraph wordPar;
        public static Word.Range wordRange;
        public static Word.Table wordTable;
        public static Word.InlineShape wordShape;

        public static string activeCategory = "";
        public static string activeProduct = "";

        public static List<Classes.Category> listCat;
        public static List<Classes.ProductsInOrder> listProductsInOrders;

        //Формирование списка категорий товаров
        public static List<Classes.Category> makeCategoryList()
        {

            listCat = new List<Classes.Category>();

            string cs = ClassTotal.connectionString;
            SqlConnection sqlConnection = new SqlConnection(cs);
            sqlConnection.Open();

            SqlDataReader dataReader = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM category", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();


                while (dataReader.Read())
                {
                    Classes.Category categorys = new Classes.Category();
                    string url = pathExe + $@"{Convert.ToString(dataReader["categoryPhotoURL"])}";

                    categorys.name = Convert.ToString(dataReader["categoryName"]);
                    categorys.PhotoCat = ShowImageBit(url);

                    listCat.Add(categorys);
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }

            return listCat;
        }
        //Преобразование фото в битовый образ
        public static BitmapImage ShowImageBit(string fileName)
        {
            BitmapImage bit = null;
            byte[] photo = File.ReadAllBytes(fileName);
            System.IO.MemoryStream strm = new System.IO.MemoryStream(photo);
            bit = new System.Windows.Media.Imaging.BitmapImage();
            bit.BeginInit();
            bit.StreamSource = strm;
            bit.EndInit();
            return bit;
        }
    }
}
