using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CarManagementSystem;

namespace Car_Management_System
{
    public partial class DriverDetailsForm : Form
    {
        private List<Driver> driversList;
        DriverController driverController = new DriverController();

        public DriverDetailsForm(List<Driver> driversList)
        {
            InitializeComponent();
            this.driversList = driversList;
            InitializeListViewColumns();
            DisplayDriverDetails();
        }

        private void InitializeListViewColumns()
        {
            // Clear existing columns
            listViewDriverDetails.Columns.Clear();

            // Add columns
            listViewDriverDetails.Columns.Add("Driver ID", 100);
            listViewDriverDetails.Columns.Add("Name", 150);
            listViewDriverDetails.Columns.Add("Contact Number", 150);
            listViewDriverDetails.Columns.Add("Availability", 100);

            // Set ListView to display details and grid lines
            listViewDriverDetails.View = View.Details;
            listViewDriverDetails.GridLines = true;
            listViewDriverDetails.FullRowSelect = true;
        }

        private void DisplayDriverDetails()
        {
            // Clear existing items in the ListView
            listViewDriverDetails.Items.Clear();

            try
            {
                // Fetch all the drivers from the database using DriverController
                driversList = driverController.GetAllDrivers();

                // Add drivers to the ListView (so GUI)
                foreach (Driver driver in driversList)
                {
                    ListViewItem item = new ListViewItem(driver.DriverId.ToString());
                    item.SubItems.Add(driver.Name);
                    item.SubItems.Add(driver.ContactNumber);
                    item.SubItems.Add(driver.Availability ? "Available" : "Unavailable");

                    listViewDriverDetails.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show($"An error occurred while fetching driver details: {ex.Message}");
            }
        }

        private void btn_EditDriverDetails_Click(object sender, EventArgs e)
        {
            // Check if a driver is selected
            if (listViewDriverDetails.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a driver to edit.");
                return;
            }

            // Get the selected driver ID
            int selectedDriverId = Convert.ToInt32(listViewDriverDetails.SelectedItems[0].Text);

            // Find the selected driver in the list
            Driver selectedDriver = driversList.Find(driver => driver.DriverId == selectedDriverId);
            if (selectedDriver == null)
            {
                MessageBox.Show("Selected driver not found.");
                return;
            }

            // Open the EditDriverForm with the selected driver
            EditDriverForm editForm = new EditDriverForm(selectedDriver);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Update driver details in the database
                    driverController.UpdateDriverDetails(selectedDriver);

                    // Refresh the driver details in the ListView(on my application GUI screen)
                    DisplayDriverDetails();
                }
                catch (Exception ex)
                {
                    // Show error message if an exception occurs
                    MessageBox.Show($"An error occurred while updating driver details: {ex.Message}");
                }
            }
        }

        private void btn_GoBack_Click_1(object sender, EventArgs e)
        {
            this.Close(); //close current form

            // Show Form4 (the previous screen)
            Form4 form4 = new Form4(new List<Car>());
            form4.Show();
        }

        private void listViewDriverDetails_SelectedIndexChanged(object sender, EventArgs e) //unused
        {
            // Event handler for when the selected item in the ListView changes
        }

        private void DriverDetailsForm_Load(object sender, EventArgs e)
        {
            // Event handler for the form to load
        }
    }
}
