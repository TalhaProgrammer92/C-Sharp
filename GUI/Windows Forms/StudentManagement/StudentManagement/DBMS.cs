using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace StudentManagement
{
    class DBMS
    {
        // Attributes
        static readonly string connectionString = @"Data Source=DESKTOP-SK1FN69\SQLDESKTOP;Initial Catalog=StudentData;Integrated Security=True;Trust Server Certificate=True";
        public static SqlConnection sqlConnection = new SqlConnection(connectionString);
        private SqlCommand command;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;

        // Constructor
        public DBMS()
        {
            sqlConnection = new SqlConnection(connectionString);

            command = new SqlCommand();
            command.Connection = sqlConnection;
        }

        // Method - Open Connection
        void OpenConnection()
        {
            // Opens the SQL connection
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        // Method - Close Connection
        void CloseConnection()
        {
            // Closes the SQL connection
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        // Method - Get Data Table
        public DataTable GetDataTable(string query)
        {
            try
            {
                OpenConnection();

                // Creates a new DataTable to store query results
                dataTable = new DataTable();

                // Initializes a SqlDataAdapter with the provided query and connection string
                dataAdapter = new SqlDataAdapter(query, connectionString);

                // Executes the query and fills the DataTable with the retrieved data
                dataAdapter.Fill(dataTable);

                // Returns the populated DataTable to the caller
                return dataTable;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        // Method - Set Data
        public int SetData(string query)
        {
            try
            {
                OpenConnection();

                // Initializes a SqlCommand with the provided query and connection string
                command = new SqlCommand(query, sqlConnection);

                // Executes the command and returns the number of affected rows
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
            return 0;
        }
    }
}
