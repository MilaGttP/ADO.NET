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


namespace ADO.NET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString = @"Data Source=WIN-DB5IFPI2TC8\SQLEXPRESS;Initial Catalog=Countries;Integrated Security=True;
                                  Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowNamesCountries_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowNamesCapitals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowNamesBigCities_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowNamesBigCapitals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowNamesEurope_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowNamesCounriesSquare_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowCapitalsAP_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowCapitalsK_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowCountriesSquare_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowCountriesPopulation_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
