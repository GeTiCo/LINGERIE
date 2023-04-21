using LINGERIESHOP.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
    /// Логика взаимодействия для UpdateProduct.xaml
    /// </summary>
    public partial class UpdateProduct : Page
    {
        public static List<Classes.Product> listProducts;
        public static List<Classes.Category> listCat;

        public UpdateProduct()
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

        private void updateitem(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(ClassTotal.connectionString);
            sqlConnection.Open();

            string oldurl = App.pathExe + $@"/photo/{App.activeCategory}/{App.activeProduct}.png";
            string newurl = App.pathExe + $@"/photo/{App.activeCategory}/{NameItem.Text}.png";

            MessageBoxResult result = MessageBox.Show($"Вы хотите поменять изображение товара? {App.activeProduct}", "Изменение изображения", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.FileName = $"{NameItem.Text}";
                    dlg.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";

                    if (dlg.ShowDialog() == true)
                    {
                        File.Delete(oldurl);
                        File.Copy(dlg.FileName, newurl);
                        MessageBox.Show("Данные товара изменены");
                    }
                    else
                    {
                        MessageBox.Show("Данные товара\nизменены не полностью");
                    }

                }
                catch
                {
                    MessageBox.Show("Ошибка, фото не изменено");
                }

            }
            else
            {
                try
                {
                    newurl = App.pathExe + $@"/photo/{App.activeCategory}/{NameItem.Text}.png";
                    File.Move(oldurl, newurl);
                    MessageBox.Show("Данные товара изменены");
                }
                catch
                {
                    MessageBox.Show("Ошибка изменения имени фото");
                }

            }

            string adres = String.Format("/photo/{0}/{1}.png", App.activeCategory, NameItem.Text);

            SqlDataReader dataReader = null;
            SqlCommand sqlCommand = new SqlCommand($"UPDATE product SET productName = '{NameItem.Text}', productCost = {Convert.ToInt32(CostItem.Text)}, productSize = '{SizeItem.Text}', productMaterial = '{MaterialItem.Text}', productStructure = '{StructureItem.Text}', productInformation = '{InformationItem.Text}', productPhotoUrl = '{adres}' WHERE productName = '{App.activeProduct}';", sqlConnection);
            dataReader = sqlCommand.ExecuteReader();
            dataReader.Close();
            sqlConnection.Close();
        }

        private void clear(object sender, RoutedEventArgs e)
        {
            UidItem.Text = null;
            CostItem.Text = null;
            SizeItem.Text = null;
            NameItem.Text = null;
            InformationItem.Text = null;
            MaterialItem.Text = null;
            StructureItem.Text = null;
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
            catch
            {
                MessageBox.Show("Ошибка отображения\nинформации о продукте");
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
