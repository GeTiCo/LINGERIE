using LINGERIESHOP.View;
using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Data;
using LINGERIESHOP.Classes;
using Microsoft.Office.Interop.Word;
using Window = System.Windows.Window;
using Application = System.Windows.Application;

namespace LINGERIESHOP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ClassTotal.connectionString;
            //Попытка подключения
            try
            {
                connection.Open();
            }
            //Обработка сбоя при подключении
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + " Уровень ошибки " + ex.Class);
                System.Windows.Application.Current.Shutdown();
            }
            //Общий сбой при подключении
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения " + ex.Message);
                System.Windows.Application.Current.Shutdown();
            }

            MainFrame.Content = new SignIn_LogIn();
        }
        public void refresh()
        {
            MainWindow newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            if (ClassTotal.Act_loginUser != "null")
            {
                MessageBoxResult result = MessageBox.Show($"Вы действительно хотите выйти", "Выход", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    ClassTotal.wallet = 0;
                    App.listProductsInOrders = null;
                    KatalogMakeOrder.SummaOrder = 0;

                    ClassTotal.Act_idUser = 0;
                    ClassTotal.Act_loginUser = "null";
                    ClassTotal.Act_idRole = 0;

                    MainFrame.Content = new SignIn_LogIn();
                }
            }
            else
            {
                System.Windows.Application.Current.Shutdown();
            }
            
        }

        private void message(object sender, RoutedEventArgs e)
        {

        }
    }
}
