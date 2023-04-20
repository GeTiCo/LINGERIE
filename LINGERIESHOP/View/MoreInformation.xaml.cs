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
    /// Логика взаимодействия для MoreInformation.xaml
    /// </summary>
    public partial class MoreInformation : Page
    {
        public MoreInformation(string name, string cost, BitmapImage photo, string uid, string size, string material, string structure, string information)
        {
            InitializeComponent();

            ItemName.Text = name;
            ItemCost.Text = $"Цена: {cost}";
            ItemPhoto.Source = photo;
            ItemUid.Text = $"UID: {uid}";
            ItemSize.Text = $"Размеры: {size}";
            ItemMaterial.Text = $"Состав: {material}";
            ItemStructure.Text = $"В комплекте {structure}";
            ItemInformation.Text = $"Информация: {information}";
        }

        private void closeInfo(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
