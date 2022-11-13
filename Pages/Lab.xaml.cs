
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

namespace ADO.NET
{
    /// <summary>
    /// Логика взаимодействия для Lab.xaml
    /// </summary>
    public partial class Lab : UserControl
    {
        private List<Assess> assesses;
        public Lab()
        {
            InitializeComponent();
            assesses = new List<Assess>();
        }
        private void Back_Click(object sender, RoutedEventArgs e) => Switcher.Switch(new Main());
        private void Lab_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=WIN-DB5IFPI2TC8\SQLEXPRESS;Initial Catalog=Assessments;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string command = @"SELECT * FROM Assessment";
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    assesses.Add(new Assess(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7)));
                }
                LabDG.ItemsSource = assesses;
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
