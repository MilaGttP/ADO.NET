using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace ADO.NET
{
    public partial class MainWindow : Window
    {
        string connectionString = @"Data Source=WIN-DB5IFPI2TC8\SQLEXPRESS;Initial Catalog=Assessments;Integrated Security=True;
        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private List<Assessment> assessment;
        public MainWindow()
        {
            InitializeComponent();
            assessment = new List<Assessment>();
        }

        private async void Showing_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            await connection.OpenAsync();
            string command = @"SELECT * FROM Assessment";
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
            while (reader.Read())
            {
                assessment.Add(new Assessment(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), 
                    reader.GetInt32(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7)));
            }
            DG.ItemsSource = assessment;
            await connection.CloseAsync();
        }

        private async void Refreshing_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "SELECT * FROM Users";
            using (connection)
            {
                await connection.OpenAsync();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                await connection.CloseAsync();
            }
        }
    }
}
