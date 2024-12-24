using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarManagementSystem;

namespace Car_Management_System
{
    // Customer dashboard screen
    public partial class Form5 : Form
    {
        private List<Car> availableCars; // List to hold available cars
        private List<Driver> availableDrivers; // List to hold available drivers
        private CarController carController; // Controller for car-related operations/functions.
        private DriverController driverController; // Controller for driver-related operations/functions.

        // Constructor for Form5
        public Form5()
        {
            InitializeComponent();
            InitializeControllers(); // Initialize car and driver controllers
            InitializeLists(); // Initialize lists of available cars and drivers
        }

        // Method to initialize car and driver controllers
        private void InitializeControllers()
        {
            carController = new CarController(); // Initialize car controller
            driverController = new DriverController(); // Initialize driver controller
        }

        // Method to initialize lists of available cars and drivers
        private void InitializeLists()
        {
            availableCars = new List<Car>(); // Initialize list of available cars
            availableDrivers = new List<Driver>(); // Initialize list of available drivers

            PopulateAvailableCars(); // Populate list of available cars
            PopulateAvailableDrivers(); // Populate list of available drivers
        }

        // Method to populate the list of available cars
        private void PopulateAvailableCars()
        {
            try
            {
                availableCars = carController.GetAvailableCars(); // Retrieve available cars from the controller
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message if an exception occurs
            }
        }

        // Method to populate the list of available drivers
        private void PopulateAvailableDrivers()
        {
            try
            {
                availableDrivers = driverController.GetAllDrivers(); // Retrieve all drivers from the controller
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display error message if an exception occurs
            }
        }

        // Event handler for the "View Available Cars" button
        private void btn_AvailableCars_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form5

            // Show Form11 (View Available Cars)
            Form11 form11 = new Form11();
            form11.Show();
        }

        // Event handler for the "View Available Drivers" button
        private void btn_AvailableDrivers_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form5

            // Show Form12 (View Available Drivers)
            // Pass 0 for both selectedCarId and selectedDriverId as placeholders
            Form12 form12 = new Form12(0, 0);
            form12.Show();
        }

        // Event handler for the "Place Order" button
        private void btn_PlaceOrder_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form5

            // Check if availableCars and availableDrivers lists are not null
            if (availableCars != null && availableDrivers != null)
            {
                // Show Form13 (Place Order) with available cars and drivers
                // Pass 0 for both selectedCarId and selectedDriverId
                Form13 form13 = new Form13(0, 0);
                form13.Show();
            }
            else
            {
                MessageBox.Show("No available cars or drivers found. Please try again later.");
            }
        }

        // Event handler for the "User" link label
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); // Close Form5

            // Show Form1 (login screen)
            Form1 form1 = new Form1();
            form1.Show();
        }

        // Event handler for the "User" label (but this handler is empty)
        private void lbl_User_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the Form5 load event (but this handler is empty)
        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
