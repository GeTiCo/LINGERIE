using LINGERIESHOP.Classes;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для SignIn_LogIn.xaml
    /// </summary>
    public partial class SignIn_LogIn : Page
    {

        SqlConnection connection = new SqlConnection();
        int limit = ClassTotal.inLimit;

        public SignIn_LogIn()
        {
            InitializeComponent();

            connection.ConnectionString = ClassTotal.connectionString;
            connection.Open();  
        }
        //Авторизация пользователя
        private void authorisation(object sender, RoutedEventArgs e)
        {
            string login = oldlogin.Text;
            string password = oldpassword.Password;

            if (login == "" && password == "")
            {
                ClassTotal.Act_idUser = 0;
                ClassTotal.Act_loginUser = "Guest";
                ClassTotal.Act_idRole = 0;

                NavigationService.Navigate(new Katalog());
            }
            else
            {
                SqlCommand command3 = connection.CreateCommand();
                string findUser = $"SELECT * FROM \"user\" WHERE userLogin = '{login}'";
                command3.CommandText = findUser;
                SqlDataReader dataReader3 = command3.ExecuteReader();

                if (dataReader3.Read() == true)
                {
                    string chekLogin = (string)dataReader3["userLogin"];
                    string chekPassword = (string)dataReader3["userPassword"];
                    if (chekLogin == login && chekPassword == password)
                    {
                        ClassTotal.Act_idUser = (int)dataReader3["userId"];
                        ClassTotal.Act_loginUser = (string)dataReader3["userLogin"];
                        ClassTotal.Act_idRole = (int)dataReader3["userRole"];

                        switch (ClassTotal.Act_idRole)
                        {
                            case 0:
                                NavigationService.Navigate(new Katalog());
                                break;
                            case 1:
                                NavigationService.Navigate(new AdminPanel());
                                break;
                            case 2:
                                NavigationService.Navigate(new KatalogMakeOrder());
                                break;
                            case 3:
                                NavigationService.Navigate(new KatalogMakeOrder());
                                break;
                        }
                        

                        dataReader3.Close();
                    }
                    else
                    {
                        limit--;
                        dataReader3.Close();
                    }
                }
                else
                {
                    limit--;
                    dataReader3.Close();
                }
                if (limit == 0)
                {
                    auntlimit.Text = $"Вход заблокирован";
                    auntbtn.IsEnabled = false;
                }
                else
                {
                    auntlimit.Text = $"У вас осталось {limit} попыток";
                }
            }
        }
        //Регистрация пользователя
        private void registration(object sender, RoutedEventArgs e)
        {
            string login = newlogin.Text;
            string password1 = newpassword.Password;
            string password2 = repeatpassword.Password;

            SqlCommand command1 = connection.CreateCommand();
            string findlogin = $"SELECT userLogin FROM \"user\" WHERE userLogin = '{login}'";
            command1.CommandText = findlogin;
            SqlDataReader dataReader1 = command1.ExecuteReader();

            Boolean findLoginResult = dataReader1.Read();

            dataReader1.Close();

            //Проверка, свободен ли выбранный логин
            if (findLoginResult == true)
            {
                MessageBox.Show("Такой пользователь уже существует");
            }
            else
            {
                //Проверка совпадения пароля
                if (password1 == password2)
                {
                    SqlCommand command2 = connection.CreateCommand();
                    string newUser = $"INSERT INTO \"user\" (userLogin, userPassword, userRole) Values ('{login}', '{password1}', 3);";
                    command2.CommandText = newUser;
                    SqlDataReader dataReader2 = command2.ExecuteReader();

                    MessageBox.Show("Пользователь успешно добавлен");
                    dataReader2.Close();

                    SignIn.Visibility = Visibility.Hidden;
                    LogIn.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Пароль не совпадает");
                }
            }
        }
        private void signInbtn(object sender, RoutedEventArgs e)
        {
            LogIn.Visibility = Visibility.Hidden;
            SignIn.Visibility = Visibility.Visible;
        }
        private void LogInbtn(object sender, RoutedEventArgs e)
        {
            SignIn.Visibility = Visibility.Hidden;
            LogIn.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
