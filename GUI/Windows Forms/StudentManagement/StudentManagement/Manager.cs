using Microsoft.IdentityModel.Tokens;

namespace StudentManagement
{
    public partial class Manager : Form
    {
        // Attributes
        DBMS dbms;
        int? selectedRoll;

        public Manager()
        {
            InitializeComponent();

            dbms = new DBMS();

            selectedRoll = null;

            // Get data from the database and bind it to the DataGridView
            dataGridView.DataSource = dbms.GetDataTable("SELECT * FROM InfoTable");
        }

        // List all students data
        void ListAllStudents()
        {
            // Clear the DataGridView
            dataGridView.DataSource = null;

            // Get all students data from the database and bind it to the DataGridView
            dataGridView.DataSource = dbms.GetDataTable("SELECT * FROM InfoTable");
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        // Check is string is valid or not
        bool IsValidString(string? str)
        {
            return !string.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str);
        }

        // Check if given data by user is valid/not for insertion
        bool IsInputDataValid()
        {
            return (
                IsValidString(nameTextBox.Text) &&
                IsValidString(rollTextBox.Text) &&
                IsValidString(ageTextBox.Text) &&
                !string.IsNullOrWhiteSpace(emailTextBox.Text)
            );
        }

        // Insert a new student
        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if data is invalid
                if (!IsInputDataValid())
                {
                    MessageBox.Show("Invalid Data!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Query
                string query = $"INSERT INTO InfoTable (Roll, Name, Age, Email) VALUES ({Convert.ToInt32(rollTextBox.Text)}, '{nameTextBox.Text}', {Convert.ToInt32(ageTextBox.Text)}, '{emailTextBox.Text}')";

                // Insert & Update
                dbms.SetData(query);
                ListAllStudents();

                // Display message
                MessageBox.Show("Your data has been inserted successfully", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the text boxes
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear data from text boxes
        void ClearTextBoxes()
        {
            rollTextBox.Clear();
            nameTextBox.Clear();
            ageTextBox.Clear();
            emailTextBox.Clear();

            selectedRoll = null;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // If no student is selected by user
            if (selectedRoll == null)
            {
                MessageBox.Show("Please select a student to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if data is invalid
                if (!IsInputDataValid())
                {
                    MessageBox.Show("Invalid Data!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Query
                string query = $"UPDATE InfoTable SET Name = '{nameTextBox.Text}', Age = {Convert.ToInt32(ageTextBox.Text)}, Email = '{emailTextBox.Text}' WHERE Roll = {selectedRoll}";

                // Insert & Update
                dbms.SetData(query);
                ListAllStudents();

                // Display message
                MessageBox.Show("Your data has been updated successfully", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the text boxes
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // If no student is selected by user
            if (selectedRoll == null)
            {
                MessageBox.Show("Please select a student to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Query
                string query = $"DELETE FROM InfoTable WHERE Roll = {selectedRoll}";

                // Insert & Update
                dbms.SetData(query);
                ListAllStudents();

                // Display message
                MessageBox.Show("Your data has been removed successfully", "Data Removal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the text boxes
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row index
            int rowIndex = e.RowIndex;

            // Check if the row index is valid
            if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView.Rows[rowIndex];
                selectedRoll = Convert.ToInt32(row.Cells["Roll"].Value);

                // Fill the text boxes with the selected row data
                rollTextBox.Text = row.Cells["Roll"].Value.ToString();
                nameTextBox.Text = row.Cells["Name"].Value.ToString();
                ageTextBox.Text = row.Cells["Age"].Value.ToString();
                emailTextBox.Text = row.Cells["Email"].Value.ToString();
            }
        }
    }
}
