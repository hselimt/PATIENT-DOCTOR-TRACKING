using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace PATIENT_DOCTOR_TRACKING
{
    public class DatabaseConnection
    {
        // private static string connectionString = @"Data Source=YOUR_SERVER_NAME\SQLEXPRESS;Initial Catalog=PatientDoctorDB;Integrated Security=True;TrustServerCertificate=True";

        public static string GetConnectionString()
        {
            try
            {    
                 var connectionString = ConfigurationManager.ConnectionStrings["PatientDoctorDB"]?.ConnectionString;
                 if (string.IsNullOrEmpty(connectionString))
                 {
                     return @"Data Source=.\SQLEXPRESS;Initial Catalog=PatientDoctorDB;Integrated Security=True;TrustServerCertificate=True";
                 }
                 return connectionString;
            }
            
            catch
            {
                return @"Data Source=.\SQLEXPRESS;Initial Catalog=PatientDoctorDB;Integrated Security=True;TrustServerCertificate=True";
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }

        public static bool ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public static object ExecuteScalar(string query)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
