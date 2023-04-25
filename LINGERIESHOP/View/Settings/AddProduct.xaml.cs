using LINGERIESHOP.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Security.Policy;
using System.Net.NetworkInformation;
using Microsoft.VisualBasic;
using Button = System.Windows.Controls.Button;
using Page = System.Windows.Controls.Page;
using Microsoft.Win32;
using System.ComponentModel;

namespace LINGERIESHOP.View.Settings
{
    /// <summary>
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {

        

        public AddProduct()
        {
            InitializeComponent();
            this.DataContext = this;

            listCategory.Items.Clear();
            listCategory.ItemsSource = App.makeCategoryList();
        }
        private void ListCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            App.activeCategory = (listCategory.SelectedItem as Category).name;

            App.listProducts = new List<Classes.Product>();
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
                    App.listProducts.Add(product);
                }
                listViewProducts.ItemsSource = App.listProducts;
                dataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newlist(object sender, RoutedEventArgs e)
        {
            string input = Interaction.InputBox("Введите наименование новой категории", "Добавление категории");
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ClassTotal.connectionString);
                sqlConnection.Open();

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.FileName = $"{input}";
                dlg.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";

                if (input != "" || dlg.ShowDialog() != true)
                {
                    string url = App.pathExe + $@"/BANERS/{input}.png";

                    if (dlg.ShowDialog() == true)
                    {
                        File.Copy(dlg.FileName, url);
                    }
                    else
                    {
                        File.Copy(App.pathExe + @"/photo/default.png", App.pathExe + $@"/BANERS/{input}.png");
                    }

                    string adres = String.Format("/BANERS/{0}.png", input);

                    SqlDataReader datacatid = null;
                    SqlCommand catid = new SqlCommand($"INSERT INTO category (categoryName, categoryPhotoURL) VALUES ('{input}', '{adres}')", sqlConnection);
                    datacatid = catid.ExecuteReader();
                    datacatid.Close();

                    Directory.CreateDirectory(App.pathExe + $@"/photo/{input}");
                    sqlConnection.Close();
                    MessageBox.Show("Категория успешно добавлена");
                }
                else
                {
                    MessageBox.Show("Невозможно добавить категорию");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dellist(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show($"Вы действительно хотите\nудалить категорию {App.activeCategory}", "Удаление категории", MessageBoxButton.YesNo);

            try
            {
                if (App.activeCategory != "" && result == MessageBoxResult.Yes)
                {
                    try
                    {
                        SqlConnection sqlConnection = new SqlConnection(ClassTotal.connectionString);
                        sqlConnection.Open();

                        SqlDataReader datacatid = null;
                        SqlCommand itemdel = new SqlCommand($"DELETE product FROM product INNER JOIN category ON product.categoryId = category.categoryId WHERE category.categoryName = '{App.activeCategory}'", sqlConnection);
                        datacatid = itemdel.ExecuteReader();
                        datacatid.Close();

                        SqlCommand catdel = new SqlCommand($"DELETE category FROM category WHERE categoryName = '{App.activeCategory}'", sqlConnection);
                        datacatid = catdel.ExecuteReader();
                        datacatid.Close();

                        Directory.Delete(App.pathExe + $@"/photo/{App.activeCategory}", true);
                        File.Delete(App.pathExe + $@"/BANERS/{App.activeCategory}.png");

                        sqlConnection.Close();

                        MessageBox.Show("Категория Удалена");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void NewItemClick(object sender, RoutedEventArgs e)
        {
            string url = App.pathExe + $@"/photo/{App.activeCategory}/{NameItem.Text}.png";

            if (App.activeCategory != "" && UidItem.Text != "" || CostItem.Text != "" || SizeItem.Text != "" || NameItem.Text != "" || MaterialItem.Text != "" || StructureItem.Text != "" || InformationItem.Text != "")
            {
                if (File.Exists(url) != true)
                {
                    try
                    {
                        SqlConnection sqlConnection = new SqlConnection(ClassTotal.connectionString);
                        sqlConnection.Open();

                        SqlDataReader datacatid = null;
                        SqlCommand catid = new SqlCommand($"SELECT categoryId FROM category WHERE categoryName = '{App.activeCategory}'", sqlConnection);
                        datacatid = catid.ExecuteReader();
                        datacatid.Close();
                        int idcat = (Int32)catid.ExecuteScalar();


                        Classes.Product product = new Classes.Product();

                        OpenFileDialog dlg = new OpenFileDialog();
                        dlg.FileName = $"{NameItem.Text}";
                        dlg.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";


                        if (dlg.ShowDialog() == true)
                        {
                            File.Copy(dlg.FileName, url);
                        }
                        else
                        {

                            File.Copy(App.pathExe + @"/photo/default.png", App.pathExe + $@"/photo/{App.activeCategory}/{dlg.FileName}.png");
                        }

                        string adres = String.Format("/photo/{0}/{1}.png", App.activeCategory, NameItem.Text);

                        SqlDataReader dataReader = null;
                        SqlCommand sqlCommand = new SqlCommand($"INSERT INTO product (categoryId, productName, productCost, productSize, productMaterial, productStructure, productInformation, productPhotoUrl)" +
                            $"VALUES ({idcat},'{NameItem.Text}',{Convert.ToInt32(CostItem.Text)},'{SizeItem.Text}','{MaterialItem.Text}','{StructureItem.Text}','{InformationItem.Text}','{adres}');", sqlConnection);
                        dataReader = sqlCommand.ExecuteReader();

                        dataReader.Close();
                        sqlConnection.Close();

                        MessageBox.Show("Товар успешно добавлен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Такой товар уже существует");
                }

            }
            else
            {
                MessageBox.Show("Присутствуют пустые строки");
            }
            listCategory.UpdateLayout();
        }

        private void btnInfo(object sender, RoutedEventArgs e)
        {
            Classes.Product product = (sender as Button).DataContext as Classes.Product;//(2)
            string name = $"Наименование:\n{product.Name}\n\nИдентификатор:\n{product.Uid}\n\nЦена:\n{product.Cost}\n\nРазмеры:\n{product.Size}\n\nМатериалы:\n{product.Material}\n\nСостав комплекта:\n{product.Structure}\n\nДополнительная информация:\n{product.Information}";
            MessageBox.Show(name);
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
