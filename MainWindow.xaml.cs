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
        private string connectionString;
        private string DataSrc;
        private string Catalog;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TBDataSrc_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataSrc = TBDataSrc.Text;
        }

        private void TBCatalog_TextChanged(object sender, TextChangedEventArgs e)
        {
            Catalog = TBCatalog.Text;
            connectionString = @$"Data Source={DataSrc}\SQLEXPRESS;Initial Catalog={Catalog};Integrated Security=True;Connect Timeout=30;
                Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        private void TBDataSrc_PreviewMouseDown(object sender, MouseButtonEventArgs e) => TBDataSrc.Text = " ";
        private void TBCatalog_PreviewMouseDown(object sender, MouseButtonEventArgs e) => TBCatalog.Text = " ";

        private void ShowTable_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
