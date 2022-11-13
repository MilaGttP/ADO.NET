using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ADO.NET
{
    /// <summary>
    /// Логика взаимодействия для HW.xaml
    /// </summary>
    public partial class HW : UserControl
    {
        private List<FruitsAndVegetables> fruitsAndVegetables;
        public HW()
        {
            InitializeComponent();
            fruitsAndVegetables = new List<FruitsAndVegetables>();
        }
        private void Back_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Main());
        private void HW_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=WIN-DB5IFPI2TC8\SQLEXPRESS;Initial Catalog=FruitsAndVegetables;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string command = @"SELECT * FROM Info";
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    fruitsAndVegetables.Add(new FruitsAndVegetables(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4)));
                }
                HWDG.ItemsSource = fruitsAndVegetables;
                connection.Close();
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }
    }
}
