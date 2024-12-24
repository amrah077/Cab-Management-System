using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Management_System
{
    public partial class EditCarForm : Form
    {
        private Car carToUpdate;
        private string connectionString = "Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;\r\n";

        public EditCarForm(Car car)
        {
            InitializeComponent();
            carToUpdate = car;
            InitializeAvailabilityComboBox();
            LoadCarDetails();
        }

        private void InitializeAvailabilityComboBox()
        {
            // Ensure the ComboBox is populated with items
            availabilityComboBox.Items.Clear();
            availabilityComboBox.Items.Add("Available"); // Index 0
            availabilityComboBox.Items.Add("Unavailable"); // Index 1
        }

        private void LoadCarDetails()
        {
            // Populate textboxes with car details
            CarIDTextBox.Text = carToUpdate.CarId.ToString();
            CarModelTextBox.Text = carToUpdate.Model;
            CarPlateNumberTextBox.Text = carToUpdate.PlateNumber;

            // Ensure ComboBox has items before setting SelectedIndex
            if (availabilityComboBox.Items.Count > 0)
            {
                if (carToUpdate.Availability)
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
            // Update car details
            string newModel = CarModelTextBox.Text;
            string newPlateNumber = CarPlateNumberTextBox.Text;
            bool newAvailability = availabilityComboBox.SelectedIndex == 0; // Check if the first item is selected

            // Update car details in the database
            UpdateCarDetails(carToUpdate.CarId, newModel, newPlateNumber, newAvailability);

            // Close the form
            this.Close();
        }

        private void UpdateCarDetails(int carId, string newModel, string newPlateNumber, bool newAvailability)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateStatement = "UPDATE Cars SET model = @model, plate_number = @plateNumber, availability = @availability WHERE car_id = @carId";
                    SqlCommand command = new SqlCommand(updateStatement, connection);
                    command.Parameters.AddWithValue("@model", newModel);
                    command.Parameters.AddWithValue("@plateNumber", newPlateNumber);
                    command.Parameters.AddWithValue("@availability", newAvailability);
                    command.Parameters.AddWithValue("@carId", carId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating car details: {ex.Message}");
            }
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCarForm_Load(object sender, EventArgs e)
        {
            // Event handler for when the form loads
        }
    }
}
