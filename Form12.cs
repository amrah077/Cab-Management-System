using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarManagementSystem;

namespace Car_Management_System
{
    public partial class Form12 : Form
    {
        // Define and initialize lists to store available cars and drivers
        private List<Car> availableCars = new List<Car>();
        private List<Driver> availableDrivers = new List<Driver>();

        // Store the IDs of the selected car and driver
        private int selectedCarId;
        private int selectedDriverId;

        // Constructor for Form12
        public Form12(int selectedCarId, int selectedDriverId)
        {
            InitializeComponent();
            // Initialize the selected car and driver IDs
            this.selectedCarId = selectedCarId;
            this.selectedDriverId = selectedDriverId;
            // Populate the list of available drivers
            PopulateAvailableDrivers();
        }

        // Event handler for the Go Back button
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();

            // Show the customer dashboard screen (Form5)
            Form5 form5 = new Form5();
            form5.Show();
        }

        // Method to populate the list of available drivers
        //private void PopulateAvailableDrivers()
        //{
        //    try
        //    {
        //        // Connect to the database and fetch available drivers
        //        using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;"))
        //        {
        //            connection.Open();
        //            string selectStatement = "SELECT driver_id, name FROM Drivers WHERE availability = 1";
        //            SqlCommand command = new SqlCommand(selectStatement, connection);
        //            SqlDataReader reader = command.ExecuteReader();

        //            // Loop through the fetched drivers and add them to the list box and availableDrivers list
        //            while (reader.Read())
        //            {
        //                int driverId = reader.GetInt32(0);
        //                string name = reader.GetString(1);

        //                // Display driver details in the ListBox
        //                listBoxAvailableDrivers.Items.Add($"{driverId}: {name}");
        //                // Add drivers to the availableDrivers list
        //                availableDrivers.Add(new Driver(driverId, name));
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred while fetching available drivers: {ex.Message}");
        //    }
        //}

        private void PopulateAvailableDrivers()
        {
            try
            {
                // Connect to the database and fetch available drivers
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;"))
                {
                    connection.Open();
                    string selectStatement = "SELECT driver_id, name, contact_number FROM Drivers WHERE availability = 1";
                    SqlCommand command = new SqlCommand(selectStatement, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Loop through the fetched drivers and add them to the list box and availableDrivers list
                    while (reader.Read())
                    {
                        int driverId = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string contactNumber = reader.GetString(2);

                        // Display driver details in the ListBox
                        listBoxAvailableDrivers.Items.Add($"{driverId}: {name}");
                        // Add drivers to the availableDrivers list
                        availableDrivers.Add(new Driver(driverId, name, contactNumber));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching available drivers: {ex.Message}");
            }
        }



        // Event handler for the Select Driver button
        private void btn_SelectDriver_Click(object sender, EventArgs e)
        {
            // Retrieve the selected driver from the list box
            string selectedDriver = listBoxAvailableDrivers.SelectedItem?.ToString();
            if (selectedDriver != null)
            {
                // Extract the driver ID from the selected driver string
                int driverId = int.Parse(selectedDriver.Split(':')[0]);
                // Update the availability of the selected driver in the database
                UpdateDriverAvailability(driverId, false);
                // Clear the list box and repopulate it with available drivers
                availableDrivers.Clear();
                listBoxAvailableDrivers.Items.Clear();
                PopulateAvailableDrivers();
                // Open Form13 for further processing, passing the car ID and the selected driver ID
                Form13 form13 = new Form13(selectedCarId, driverId);
                form13.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a driver.");
            }
        }

        // Method to update the availability of a driver in the database
        private void UpdateDriverAvailability(int driverId, bool availability)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;"))
            {
                connection.Open();
                string updateStatement = "UPDATE Drivers SET availability = @availability WHERE driver_id = @driverId";
                SqlCommand command = new SqlCommand(updateStatement, connection);
                command.Parameters.AddWithValue("@availability", availability);
                command.Parameters.AddWithValue("@driverId", driverId);
                command.ExecuteNonQuery();
            }
        }

        // Event handler for the Form12 Load event
        private void Form12_Load(object sender, EventArgs e)
        {
            // This event handler currently has no implementation but can be used for additional functionality if needed
        }
    }
}
