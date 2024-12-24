using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarManagementSystem;

namespace Car_Management_System
{
    public partial class Form11 : Form
    {
        // Define and initialize the list of available cars at the class level
        private List<Car> availableCars = new List<Car>();

        // Constructor for Form11
        public Form11()
        {
            InitializeComponent();
            // Populate the list of available cars when the form is initialized
            PopulateAvailableCars();
        }

        // Event handler for the Go Back button
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();

            // Show the customer dashboard screen (Form5)
            Form5 form5 = new Form5();
            form5.Show();
        }

        // Method to populate the list of available cars
        private void PopulateAvailableCars()
        {
            try
            {
                // Connect to the database and fetch available cars
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    string selectStatement = "SELECT car_id, model, plate_number, availability FROM Cars WHERE availability = 1";
                    SqlCommand command = new SqlCommand(selectStatement, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Loop through the fetched cars and add them to the list box and availableCars list
                    while (reader.Read())
                    {
                        int carId = reader.GetInt32(0);
                        string model = reader.GetString(1);
                        string plateNumber = reader.GetString(2);
                        bool availability = reader.GetBoolean(3);

                        // Display car details in the ListBox
                        listBoxAvailableCars.Items.Add($"{carId}: {model} - {plateNumber}");

                        // Add cars to the availableCars list
                        availableCars.Add(new Car(carId, model, plateNumber, availability));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching available cars: {ex.Message}");
            }
        }

        // Event handler for the Select Car button
        private async void btn_SelectCar_Click(object sender, EventArgs e)
        {
            // Retrieve the selected car from the list box
            string selectedCar = listBoxAvailableCars.SelectedItem?.ToString();
            if (selectedCar != null)
            {
                int carId;
                // Extract the car ID from the selected car string
                if (int.TryParse(selectedCar.Split(':')[0], out carId))
                {
                    // Update the availability of the selected car in the database
                    await UpdateCarAvailabilityAsync(carId, false);
                    // Clear the list box and repopulate it with available cars
                    availableCars.Clear();
                    listBoxAvailableCars.Items.Clear();
                    PopulateAvailableCars();

                    // Open Form12 for further processing, passing the car ID and an initial driver ID
                    Form12 form12 = new Form12(carId, 0); // Assuming you initially pass 0 for the driver ID
                    form12.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to parse the selected car ID.");
                }
            }
            else
            {
                MessageBox.Show("Please select a car.");
            }
        }

        // Method to update the availability of a car in the database asynchronously
        private async Task UpdateCarAvailabilityAsync(int carId, bool availability)
        {
            // Connect to the database asynchronously
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;"))
            {
                await connection.OpenAsync();
                // Prepare the SQL update statement
                string updateStatement = "UPDATE Cars SET availability = @availability WHERE car_id = @carId";
                SqlCommand command = new SqlCommand(updateStatement, connection);
                command.Parameters.AddWithValue("@availability", availability);
                command.Parameters.AddWithValue("@carId", carId);
                await command.ExecuteNonQueryAsync(); // Execute the SQL command asynchronously
            }
        }

        // Event handler for the Form11 Load event
        private void Form11_Load(object sender, EventArgs e)
        {
            // This event handler currently has no implementation but can be used for additional functionality if needed
        }
    }
}
