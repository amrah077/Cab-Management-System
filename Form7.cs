using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Car_Management_System
{
    // Form7 represents the screen for removing cars
    public partial class Form7 : Form
    {
        private List<Car> carsList; // List to hold cars
        private CarController carController; // Controller for managing cars

        // Constructor for Form7, accepts a list of cars as a parameter
        public Form7(List<Car> carsList)
        {
            InitializeComponent();
            this.carsList = carsList; // Assign the provided list of cars to the local variable
            carController = new CarController(); // Initialize the car controller
            PopulateComboBoxes(); // Populate ComboBoxes with available cars
        }

        // Method to populate ComboBoxes with available cars
        private void PopulateComboBoxes()
        {
            try
            {
                List<Car> availableCars = carController.GetAvailableCars(); // Retrieve available cars from the controller

                // Add car details to respective ComboBoxes
                foreach (Car car in availableCars)
                {
                    comboBoxCarID.Items.Add(car.CarId);
                    comboBoxModel.Items.Add(car.Model);
                    comboBoxPlateNumber.Items.Add(car.PlateNumber);
                    comboBoxAvailability.Items.Add(car.Availability);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating ComboBoxes: {ex.Message}");
            }
        }

        // Method to clear ComboBoxes
        private void ClearComboBoxes()
        {
            comboBoxCarID.SelectedIndex = -1;
            comboBoxModel.SelectedIndex = -1;
            comboBoxPlateNumber.SelectedIndex = -1;
            comboBoxAvailability.SelectedIndex = -1;
        }

        // Event handler for the "Go Back" button
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form7

            // Show Form3 (previous screen) and pass the carsList
            Form3 form3 = new Form3(carsList);
            form3.Show();
        }

        // Event handler for the "Delete" button
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Get the selected car ID
            if (comboBoxCarID.SelectedItem == null)
            {
                MessageBox.Show("Please select a car ID.");
                return;
            }

            int selectedCarId = Convert.ToInt32(comboBoxCarID.SelectedItem);

            try
            {
                // Delete the car using the car controller
                carController.DeleteCar(selectedCarId);

                // Remove the car from the list
                Car selectedCar = carsList.Find(car => car.CarId == selectedCarId);
                if (selectedCar != null)
                {
                    carsList.Remove(selectedCar);
                    MessageBox.Show("Car removed successfully.");
                    ClearComboBoxes(); // Clear the ComboBoxes after successful deletion
                    PopulateComboBoxes(); // Re-populate ComboBoxes to reflect changes
                }
                else
                {
                    MessageBox.Show("Selected car not found in the list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Event handler for the "Clear" button
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearComboBoxes(); // Call the method to clear ComboBoxes
        }

        // Event handler for the SelectedIndexChanged event of the car ID ComboBox (but this handler is empty)
        private void comboBoxCarID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Event handler for the Form7 load event (but this handler is empty)
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            ClearComboBoxes(); // Call the method to clear ComboBoxes
        }
    }
}
