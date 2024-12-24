using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarManagementSystem;

namespace Car_Management_System
{
    public partial class EditDriverForm : Form
    {
        private Driver driverToUpdate;
        private string connectionString = "Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;\r\n";

        public EditDriverForm(Driver driver)
        {
            InitializeComponent();
            driverToUpdate = driver;
            InitializeAvailabilityComboBox(); // Initialize ComboBox items
            LoadDriverDetails();
        }

        private void InitializeAvailabilityComboBox()
        {
            // Ensure the ComboBox is populated with items
            availabilityComboBox.Items.Clear();
            availabilityComboBox.Items.Add("Available"); // Index 0
            availabilityComboBox.Items.Add("Unavailable"); // Index 1
        }

        private void LoadDriverDetails()
        {
            // Populate textboxes with driver details
            DriverIDTextBox.Text = driverToUpdate.DriverId.ToString();
            DriverNameTextBox.Text = driverToUpdate.Name;
            ContactNumberTextBox.Text = driverToUpdate.ContactNumber;

            // Ensure ComboBox has items before setting SelectedIndex
            if (availabilityComboBox.Items.Count > 0)
            {
                if (driverToUpdate.Availability)
                {
                    availabilityComboBox.SelectedIndex = 0; // Assuming index 0 represents availability
                }
                else
                {
                    availabilityComboBox.SelectedIndex = 1; // Assuming index 1 represents unavailability
                }
            }
            else
            {
                MessageBox.Show("The availabilityComboBox does not contain any items.");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            // Update driver details
            string newName = DriverNameTextBox.Text;
            string newContactNumber = ContactNumberTextBox.Text;
            bool newAvailability = availabilityComboBox.SelectedIndex == 0; // Check if the first item is selected

            // Update driver details in the database
            UpdateDriverDetails(driverToUpdate.DriverId, newName, newContactNumber, newAvailability);

            // Close the form
            this.Close();
        }

        private void UpdateDriverDetails(int driverId, string newName, string newContactNumber, bool newAvailability)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateStatement = "UPDATE Drivers SET name = @name, contact_number = @contactNumber, availability = @availability WHERE driver_id = @driverId";
                    SqlCommand command = new SqlCommand(updateStatement, connection);
                    command.Parameters.AddWithValue("@name", newName);
                    command.Parameters.AddWithValue("@contactNumber", newContactNumber);
                    command.Parameters.AddWithValue("@availability", newAvailability);
                    command.Parameters.AddWithValue("@driverId", driverId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating driver details: {ex.Message}");
            }
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event handler for clicking on a label
        }

        private void EditDriverForm_Load(object sender, EventArgs e)
        {
            // Event handler for when the form loads
        }
    }
}
