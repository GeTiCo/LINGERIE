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

namespace LINGERIESHOP.View.Settings
{
    /// <summary>
    /// Логика взаимодействия для DeleteProduct.xaml
    /// </summary>
    public partial class DeleteProduct : Page
    {
        public static List<Classes.Product> listProducts;
        public static List<Classes.Category> listCat;

        public DeleteProduct()
        {
            InitializeComponent();
            this.DataContext = this;

            listCategory.Items.Clear();
            listCategory.ItemsSource = App.makeCategoryList();
        }
        private void ListCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
                        string url = App.pathExe + $@"{Convert.ToString(dataReader["productPhotoURL"])}";
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

        private void delitem(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ClassTotal.connectionString);
                sqlConnection.Open();

                SqlDataReader datacatid = null;
                SqlCommand itemdel = new SqlCommand($"DELETE product FROM product WHERE productName = '{App.activeProduct}'", sqlConnection);
                datacatid = itemdel.ExecuteReader();
                datacatid.Close();

                System.IO.File.Delete(App.pathExe + $@"/photo/{App.activeCategory}/{App.activeProduct}.png");

                sqlConnection.Close();
                MessageBox.Show("Товар успешно удален");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnInfo(object sender, RoutedEventArgs e)
        {
            try
            {
                Classes.Product product = (sender as Button).DataContext as Classes.Product;

                NameItem.Text = product.Name;
                App.activeProduct = product.Name;
                PhotoItem.Source = product.Photo;
                UidItem.Text = product.Uid;
                CostItem.Text = Convert.ToString(product.Cost);
                SizeItem.Text = product.Size;
                InformationItem.Text = product.Information;
                MaterialItem.Text = product.Material;
                StructureItem.Text = product.Structure;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listCategory_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            ScrollViewer scrollviewer = FindVisualChildren<ScrollViewer>(listBox).FirstOrDefault();
            if (e.Delta > 0)
                scrollviewer.LineLeft();
            else
                scrollviewer.LineRight();
            e.Handled = true;
        }
        private static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}
