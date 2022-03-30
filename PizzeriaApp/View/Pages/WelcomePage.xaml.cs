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

namespace PizzeriaApp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Page
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void ClientButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientPage());
        }
        private void ProductButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ProductPage());
        }

        
    }
}
