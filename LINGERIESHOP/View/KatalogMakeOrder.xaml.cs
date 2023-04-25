using LINGERIESHOP.Classes;
using LINGERIESHOP.View.Settings;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LINGERIESHOP.View
{
    /// <summary>
    /// Логика взаимодействия для KatalogMakeOrder.xaml
    /// </summary>
    public partial class KatalogMakeOrder : Page
    {
        public static List<Classes.Product> listProducts;
        

        public static int SummaOrder { get; set; }

        public KatalogMakeOrder()
        {
            InitializeComponent();

            listCategory.Items.Clear();
            listCategory.ItemsSource = App.makeCategoryList();

            Random rnd = new Random();
            ClassTotal.wallet = rnd.Next(10000, 20000);

            userName.Text = $"Логин: {ClassTotal.Act_loginUser}";
            

            App.listProductsInOrders = new List<Classes.ProductsInOrder>();

            if (ClassTotal.Act_idRole == 2)
            {
                role.Text = $"Роль: Менеджер";
                wallet.Text = $"Баланс: Отсутствует";
                
                managerfunc.Visibility = Visibility.Visible;
                userfunc.Visibility = Visibility.Hidden;
            }
            if (ClassTotal.Act_idRole == 3)
            {
                role.Text = $"Роль: Клиент";
                wallet.Text = $"Баланс: {ClassTotal.wallet}";
                managerfunc.Visibility = Visibility.Hidden;
                userfunc.Visibility = Visibility.Visible;
            }
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

        private void MakeOrder(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CompleteOrder());
        }

        private void inorder(object sender, RoutedEventArgs e)
        {
            if (ClassTotal.Act_idRole == 2)
            {
                MessageBox.Show("Выйдите из профиля менеджера для совершения покупок");
            }
            else
            {
                Classes.ProductsInOrder productInOrder = null;

                Classes.Product product = (sender as Button).DataContext as Classes.Product;

                try
                {
                    if (SummaOrder + product.Cost <= ClassTotal.wallet)
                    {

                        int index = App.listProductsInOrders.FindIndex(x => x.Name == product.Name);

                        if (index < 0)
                        {
                            productInOrder = new Classes.ProductsInOrder();

                            productInOrder.Photo = product.Photo;
                            productInOrder.Name = product.Name;
                            productInOrder.Uid = product.Uid;
                            productInOrder.Cost = product.Cost;
                            productInOrder.Size = product.Size;
                            productInOrder.Structure = product.Structure;
                            productInOrder.Count = 1;
                            productInOrder.Costing = product.Cost;

                            App.listProductsInOrders.Add(productInOrder);
                        }
                        else
                        {
                            App.listProductsInOrders[index].Count++;
                            App.listProductsInOrders[index].Costing = App.listProductsInOrders[index].Cost * App.listProductsInOrders[index].Count;
                        }

                        SummaOrder += product.Cost;
                        limit.Text = "Сумма заказа: " + SummaOrder;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно средств");
                    }
                }
                catch
                {
                    MessageBox.Show("Нам не удалось добавить товар в корзину");
                }
            }
        }
    }
}
