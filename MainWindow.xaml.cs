using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ADO.NET
{
    public partial class MainWindow : Window
    {
        private List<Goods> Goods;
        public MainWindow()
        {
            InitializeComponent();
            Goods = new List<Goods>();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=WIN-DB5IFPI2TC8\SQLEXPRESS;Initial Catalog=Warehouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string command = @"SELECT * FROM Goods";
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Goods.Add(new Goods(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                }
                DG.ItemsSource = Goods;
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
