using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarManagementSystem;

namespace Car_Management_System
{
    // Form8 represents the screen for adding drivers
    public partial class Form8 : Form
    {
        private List<Driver> driversList; // List to hold drivers
        private DriverController driverController; // Controller for managing drivers

        // Constructor for Form8, accepts a list of drivers as a parameter
        public Form8(List<Driver> driversList)
        {
            InitializeComponent();
            this.driversList = driversList; // Assign the provided list of drivers to the local variable
            driverController = new DriverController(); // Initialize the driver controller

            // Add options to the availabilityComboBox
            availabilityComboBox.Items.Add("Available");
            availabilityComboBox.Items.Add("Not Available");
        }

        // Event handler for the "Go Back" button
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form8

            // Show Form4 (previous screen) with an empty list of cars
            Form4 form4 = new Form4(new List<Car>());
            form4.Show();
        }

        // Event handler for the "Add" button
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Get data from input fields
                string name = DriverNameTextBox.Text;
                string contactNumber = ContactNumberTextBox.Text;
                bool availability = availabilityComboBox.SelectedItem.ToString() == "Available";

                // Insert the driver into the database using the driver controller
                driverController.AddDriver(new Driver(0, name, contactNumber, availability)); // Assuming 0 for driverId

                // Update the driversList with all drivers from the database
                driversList = driverController.GetAllDrivers();

                MessageBox.Show("Driver added successfully."); // Display a success message
                ClearFields(); // Clear input fields after successful addition
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the driver: {ex.Message}"); // Display an error message if an exception occurs
            }
        }

        // Event handler for the "Clear" button
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields(); // Call the method to clear input fields
        }

        // Method to clear input fields
        private void ClearFields()
        {
            DriverIDTextBox.Clear(); // Clear the driver ID field
            DriverNameTextBox.Clear(); // Clear the driver name field
            ContactNumberTextBox.Clear(); // Clear the contact number field
            availabilityComboBox.SelectedIndex = -1; // Clear the selected item in the availabilityComboBox
        }

        // Event handler for the Form8 load event (but this handler is empty)
        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
