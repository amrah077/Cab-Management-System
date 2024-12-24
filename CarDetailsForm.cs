using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Management_System
{
    public partial class CarDetailsForm : Form
    {
        private List<Car> carsList;

        // Constructor to initialize the form with the list of cars
        public CarDetailsForm(List<Car> carsList)
        {
            InitializeComponent(); // Initialize the form components
            this.carsList = carsList; // Assign the provided list of cars to the local variable
            InitializeListViewColumns(); // Initialize the ListView columns
            DisplayCarDetails(); // Display car details in the ListView
        }

        // Method to initialize the columns of the ListView
        private void InitializeListViewColumns()
        {
            listViewCarDetails.Columns.Clear(); // Clear existing columns

            // Add new columns to the ListView
            listViewCarDetails.Columns.Add("Car ID", 100); // Column for Car ID
            listViewCarDetails.Columns.Add("Model", 150); 
            listViewCarDetails.Columns.Add("Plate Number", 150); 
            listViewCarDetails.Columns.Add("Availability", 100); 

            listViewCarDetails.View = View.Details; // Set ListView to display details
            listViewCarDetails.GridLines = true; // Enable grid lines
            listViewCarDetails.FullRowSelect = true; // Enable full row selection
        }

        // Method to display car details in the ListView
        private void DisplayCarDetails()
        {
            listViewCarDetails.Items.Clear(); // Clear existing items in the ListView

            try
            {
                CarController carController = new CarController(); // Create an object of CarController
                List<Car> carsListFromDB = carController.GetAllCars(); // Fetch all the cars from the database

                carsList.Clear(); // Clear the existing carsList
                carsList.AddRange(carsListFromDB); // Add fetched cars to the carsList

                // Add each car to the ListView
                foreach (var car in carsListFromDB)
                {
                    ListViewItem item = new ListViewItem(car.CarId.ToString()); // Create a new ListViewItem with Car ID
                    item.SubItems.Add(car.Model); // Add Model as a sub-item
                    item.SubItems.Add(car.PlateNumber); // Add Plate Number as a sub-item
                    item.SubItems.Add(car.Availability ? "Available" : "Unavailable"); // Add Availability as a sub-item
                    listViewCarDetails.Items.Add(item); // Add the item to the ListView
                }
            }
            catch (Exception ex)
            {
                // Display an error message if any exception occurs during data fetching
                MessageBox.Show($"An error occurred while fetching car details: {ex.Message}");
            }
        }

        // Event handler for the Go Back button click
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form

            // Show the previous form (Form3)
            Form3 form3 = new Form3(carsList);
            form3.Show();
        }

        // Event handler for the Edit Car Details button click
        private void btn_EditCarDetails_Click(object sender, EventArgs e)
        {
            // Check if any car is selected in the ListView
            if (listViewCarDetails.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a car to edit.");
                return;
            }

            // Get the selected car ID from the ListView
            int selectedCarId = Convert.ToInt32(listViewCarDetails.SelectedItems[0].Text);

            // Find the selected car in the carsList
            Car selectedCar = carsList.Find(car => car.CarId == selectedCarId);
            if (selectedCar == null)
            {
                MessageBox.Show("Selected car not found.");
                return;
            }

            // Open the EditCarForm with the selected car
            EditCarForm editForm = new EditCarForm(selectedCar);
            editForm.ShowDialog(); // Show the form as a dialog

            // Update the car details in the ListView after editing
            listViewCarDetails.SelectedItems[0].SubItems[1].Text = selectedCar.Model;
            listViewCarDetails.SelectedItems[0].SubItems[2].Text = selectedCar.PlateNumber;
            listViewCarDetails.SelectedItems[0].SubItems[3].Text = selectedCar.Availability ? "Available" : "Unavailable";
        }

        
        private void CarDetailsForm_Load(object sender, EventArgs e)
        {
            // No additional actions needed during form load
        }
    }
}
