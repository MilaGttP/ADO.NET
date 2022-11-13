
using System.Windows;
using System.Windows.Controls;

namespace ADO.NET
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        public Main() => InitializeComponent();

        private void Lab_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Lab());
        private void HW_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new HW());
    }
}
