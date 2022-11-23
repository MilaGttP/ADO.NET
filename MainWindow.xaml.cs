using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Microsoft.Data.SqlClient;

namespace ADO.NET
{
    public partial class MainWindow : Window
    {
        private List<Stationery> stationeries;
        private List<Manager> managers;
        private string connectionString = @"Data Source=WIN-DB5IFPI2TC8\SQLEXPRESS;Initial Catalog=StationeryShop;Integrated Security=True;Connect Timeout=30;
                Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public MainWindow()
        {
            InitializeComponent();
            stationeries = new List<Stationery>();
            managers = new List<Manager>();
        }

        private void ShowAllStationery_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string command = @"SELECT * FROM Stationery";
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    stationeries.Add(new Stationery(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetDouble(4)));
                }
                DG.ItemsSource = stationeries;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void ShowAllStatTypes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string command = @"SELECT Type FROM Stationery";
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                List<string> types = new List<string>();
                int counter = 0;
                while (reader.Read()) counter++;
                for (int i = 0; i < counter; i++) types.Add(reader.GetString(i));
                DG.ItemsSource = types;
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

        private void ShowAllManagers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string command = @"SELECT * FROM Managers";
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    managers.Add(new Manager(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                }
                DG.ItemsSource = managers;
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void ShowMaxQuantity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sqlExpression = "sp_GetMaxQuantity";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var result = command.ExecuteScalar();
                connection.Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void ShowMinQuantity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sqlExpression = "sp_GetMinQuantity";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var result = command.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void ShowMaxPrice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sqlExpression = "sp_GetMaxPrice";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var result = command.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void ShowMinPrice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sqlExpression = "sp_GetMinPrice";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var result = command.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
