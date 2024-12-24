using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Car_Management_System
{
    // Form6 represents the screen for adding cars
    public partial class Form6 : Form
    {
        private List<Car> carsList; // List to hold cars
        private CarController carController; // Controller for managing cars

        // Constructor for Form6, accepts a list of cars as a parameter
        public Form6(List<Car> carsList)
        {
            InitializeComponent();
            this.carsList = carsList; // Assign the provided list of cars to the local variable
            carController = new CarController(); // Initialize the car controller

            // Add items to the availability dropdown list
            availabilityComboBox.Items.Add("True");
            availabilityComboBox.Items.Add("False");
        }

        // Event handler for the "Go Back" button
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form6

            // Show Form3 (previous screen) and pass the carsList
            Form3 form3 = new Form3(carsList);
            form3.Show();
        }

        // Event handler for the "Submit" button
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // Retrieve car details from text boxes
            int carId;
            if (!int.TryParse(carIDTextBox.Text, out carId))
            {
                MessageBox.Show("Invalid Car ID! Please enter a valid integer.");
                return;
            }

            string model = modelTextBox.Text;
            string plateNumber = plateNumberTextBox.Text;
            bool availability = bool.Parse(availabilityComboBox.SelectedItem.ToString()); // Get the selected item from the dropdown

            // Create a new car object
            Car newCar = new Car(carId, model, plateNumber, availability);

            try
            {
                // Insert car details into the database using the car controller
                carController.AddCar(newCar);
                MessageBox.Show("Car Added to the Car List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Clear text boxes after adding the car
            ClearTextBoxes();
        }

        // Method to clear the text boxes
        private void ClearTextBoxes()
        {
            carIDTextBox.Clear();
            modelTextBox.Clear();
            plateNumberTextBox.Clear();
            availabilityComboBox.SelectedIndex = -1; // Clear the selected item in the dropdown
        }

        // Event handler for the "Clear" button
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(); // Call the method to clear text boxes
        }

        // Event handler for the click event of a label (but this handler is empty)
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the Form6 load event (but this handler is empty)
        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
