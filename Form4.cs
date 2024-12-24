using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarManagementSystem;

namespace Car_Management_System
{
    // Form4 represents the screen for managing drivers
    public partial class Form4 : Form
    {
        private List<Car> carsList; // List to hold cars
        private List<Driver> driversList; // List to hold drivers

        // Constructor for Form4, accepts a list of cars as a parameter
        public Form4(List<Car> carsList)
        {
            InitializeComponent();
            this.carsList = carsList; // Assign the provided list of cars to the local variable
            this.driversList = new List<Driver>(); // Initialize the list of drivers
        }

        // Event handler for the "Go Back" button
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form4

            // Show Form2 (admin dashboard screen) and pass the carsList
            Form2 form2 = new Form2(carsList);
            form2.Show();
        }

        // Event handler for the "Add Drivers" button
        private void btn_AddDrivers_Click(object sender, EventArgs e)
        {
            // Show Form8 (Add Drivers) and pass the driversList
            Form8 form8 = new Form8(driversList);
            form8.Show();
        }

        // Event handler for the "Remove Drivers" button
        private void btn_RemoveDrivers_Click(object sender, EventArgs e)
        {
            // Show Form9 (Remove Drivers)
            Form9 form9 = new Form9();
            form9.Show();
        }

        // Event handler for the "View Driver Details" button
        private void btn_ViewDriverDetails_Click(object sender, EventArgs e)
        {
            // Show DriverDetailsForm to view details of drivers and pass the driversList
            DriverDetailsForm driverDetailsForm = new DriverDetailsForm(driversList);
            driverDetailsForm.Show();
        }

        // Event handler for the click event of a label (but this handler is empty)
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the Form4 load event (but this handler is empty)
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
