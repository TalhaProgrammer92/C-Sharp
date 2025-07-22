using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace InventoryManagement
{
    class SQLValidations
    {
        // Username Property
        public static string user;

        public static string USER
        {
            get { return user; }            // Getter
            private set { user = value; }   // Setter
        }

        // User image Property
        public static Image image;

        public static Image IMAGE
        {
            get { return image; }           // Getter
            private set { image = value; }  // Setter
        }

        // SQL Connection
        public static readonly string connenctionString;
        public static SqlConnection connection = new SqlConnection(connenctionString);

        // Check user validation
        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;

            // Create query and command to extract data from database
            string query = @"SELECT * from users where name = '" + username + "' and password = '" + password + "'";
            SqlCommand command = new SqlCommand(query, connection);

            // Extract data from database
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            // If the user exist
            if (data.Rows.Count > 0)
            {
                isValid = true;

                // Set username
                USER = data.Rows[0]["name"].ToString();

                // Set user image
                //Byte[] imageArray = 
            }

            return isValid;
        }

        // Stop a panel to buffer
        public static void StopBuffering(System.Windows.Forms.Panel panel, bool doubleBuffer)
        {
            try
            {
                // Stop buffering
                typeof(Control).InvokeMember(
                    "DoubleBuffering",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, panel, new object[] {doubleBuffer}
                 );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // CRUD Operation
        public static int SQLOperation(string query, Hashtable hashTable)
        {
            int result = 0;

            try
            {
                // Establish sql command
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;

                // Add values to the command object from given hash table
                foreach (DictionaryEntry item in hashTable)
                {
                    command.Parameters.AddWithValue(
                        item.Key.ToString(),    // Key in the hash table
                        item.Value              // Value in the hash table
                     );
                }

                // If connection is closed
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                // Close the connection
                connection.Close();
            }

            return result;
        }
    }
}
