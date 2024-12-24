using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarManagementSystem;

namespace Car_Management_System
{
    // Form9 represents the screen for removing drivers
    public partial class Form9 : Form
    {
        private List<Driver> driversList; // List to hold drivers
        private DriverController driverController; // Controller for managing drivers

        // Constructor for Form9
        public Form9()
        {
            InitializeComponent();
            driverController = new DriverController(); // Initialize the driver controller
            PopulateComboBoxes(); // Populate the ComboBoxes with driver details
        }

        // Method to populate ComboBoxes with driver details
        private void PopulateComboBoxes()
        {
            try
            {
                driversList = driverController.GetAllDrivers(); // Retrieve all drivers from the database

                // Iterate over the list of drivers and add their details to the respective ComboBoxes
                foreach (Driver driver in driversList)
                {
                    comboBoxDriverID.Items.Add(driver.DriverId);
                    comboBoxDriverName.Items.Add(driver.Name);
                    comboBoxContactNumber.Items.Add(driver.ContactNumber);
                    comboBoxDriverAvailability.Items.Add(driver.Availability);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating ComboBoxes: {ex.Message}"); // Display an error message if an exception occurs
            }
        }

        // Event handler for the "Delete" button
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Check if a driver ID is selected
            if (comboBoxDriverID.SelectedItem == null)
            {
                MessageBox.Show("Please select a driver ID.");
                return;
            }

            int selectedDriverId = Convert.ToInt32(comboBoxDriverID.SelectedItem); // Get the selected driver ID

            try
            {
                // Delete the selected driver using the driver controller
                driverController.DeleteDriver(selectedDriverId);

                // Remove the driver from the local list
                Driver selectedDriver = driversList.Find(driver => driver.DriverId == selectedDriverId);
                if (selectedDriver != null)
                {
                    driversList.Remove(selectedDriver);
                    MessageBox.Show("Driver removed successfully."); // Display a success message
                }
                else
                {
                    MessageBox.Show("Selected driver not found in the list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}"); // Display an error message if an exception occurs
            }
        }

        // Event handler for the "Clear" button
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearComboBoxes(); // Clear the ComboBoxes
        }

        // Method to clear the ComboBoxes
        private void ClearComboBoxes()
        {
            comboBoxDriverID.SelectedIndex = -1;
            comboBoxDriverName.SelectedIndex = -1;
            comboBoxContactNumber.SelectedIndex = -1;
            comboBoxDriverAvailability.SelectedIndex = -1;
        }

        // Event handler for the "Go Back" button
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form9

            // Show Form4 (previous screen) with an empty list of cars
            Form4 form4 = new Form4(new List<Car>());
            form4.Show();
        }

        // Event handler for the Form9 load event (but this handler is empty)
        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
