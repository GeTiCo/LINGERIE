using LINGERIESHOP.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LINGERIESHOP.View
{
    /// <summary>
    /// Логика взаимодействия для Katalog.xaml
    /// </summary>
    public partial class Katalog : Page
    {
        public static List<Classes.Product> listProducts;
        public static List<Classes.Category> listCat;

        public Katalog()
        {
            InitializeComponent();
            this.DataContext = this;

            listCategory.Items.Clear();
            listCategory.ItemsSource = App.makeCategoryList();
        }

        private void listCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.activeCategory = (listCategory.SelectedItem as Category).name;


            listProducts = new List<Classes.Product>();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ClassTotal.connectionString);
                sqlConnection.Open();

                SqlDataReader dataReader = null;

                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM product INNER JOIN  category ON product.categoryId = category.categoryId WHERE category.categoryName = '{App.activeCategory}'", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Classes.Product product = new Classes.Product();

                    product.Name = Convert.ToString(dataReader["productName"]);
                    product.Cost = Convert.ToInt32(dataReader["productCost"]);
                    product.Uid = Convert.ToString(dataReader["productId"]);
                    product.Size = Convert.ToString(dataReader["productSize"]);
                    product.Material = Convert.ToString(dataReader["productMaterial"]);
                    product.Structure = Convert.ToString(dataReader["productStructure"]);
                    product.Information = Convert.ToString(dataReader["productInformation"]);
                    try
                    {
                        string url = App.pathExe + $@"{Convert.ToString(dataReader["productPhotoUrl"])}";
                        product.Photo = App.ShowImageBit(url);
                    }
                    catch
                    {
                        string url = App.pathExe + @"/default.png";
                        product.Photo = App.ShowImageBit(url);
                    }
                    listProducts.Add(product);
                }
                listViewProducts.ItemsSource = listProducts;
                dataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MoreInfo(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Product product = (sender as Hyperlink).DataContext as Classes.Product;

                NavigationService.Navigate(new MoreInformation(product.Name, Convert.ToString(product.Cost), product.Photo,
                    product.Uid, product.Size, product.Material, product.Structure, product.Information));
            }
            catch
            {
                MessageBox.Show("Продукт временно недоступен");
            }
        }
    }
}
