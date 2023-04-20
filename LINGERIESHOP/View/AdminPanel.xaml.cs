using LINGERIESHOP.View.Settings;
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

namespace LINGERIESHOP.View
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Page
    {
        public AdminPanel()
        {
            InitializeComponent();
            SettingsFrame.Content = new AddProduct();
        }

        private void AddList(object sender, RoutedEventArgs e)
        {
            SettingsFrame.Content = new AddProduct();
        }

        private void SettingList(object sender, RoutedEventArgs e)
        {
            SettingsFrame.Content = new UpdateProduct();
        }

        private void DelList(object sender, RoutedEventArgs e)
        {
            SettingsFrame.Content = new DeleteProduct();
        }

        private void settingsOrders(object sender, RoutedEventArgs e)
        {
            SettingsFrame.Content = new SettingsOrder();
        }
    }
}
