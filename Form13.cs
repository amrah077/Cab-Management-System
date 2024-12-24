using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarManagementSystem;

namespace Car_Management_System
{
    public partial class Form13 : Form
    {
        // Define lists to store available cars and drivers
        private List<Car> availableCars;
        private List<Driver> availableDrivers;

        // Properties to store the selected car and driver IDs
        public int SelectedCarId { get; set; }
        public int SelectedDriverId { get; set; }

        // Constructor for Form13
        public Form13(int selectedCarId, int selectedDriverId)
        {
            InitializeComponent();
            // Initialize the selected car and driver IDs
            this.SelectedCarId = selectedCarId;
            this.SelectedDriverId = selectedDriverId;
            // Populate the car and driver combo boxes with the selected IDs
            PopulateCarComboBox(selectedCarId);
            PopulateDriverComboBox(selectedDriverId);
        }

        // Method to populate the car combo box with the selected car ID
        private void PopulateCarComboBox(int selectedCarId)
        {
            // Add the selected car to the combo box
            comboBoxAvailableCar.Items.Add($"{selectedCarId}: {GetCarModel(selectedCarId)}");
            comboBoxAvailableCar.SelectedIndex = 0; // Select the first item by default
        }

        // Method to populate the driver combo box with the selected driver ID
        private void PopulateDriverComboBox(int selectedDriverId)
        {
            // Add the selected driver to the combo box
            comboBoxAvailableDriver.Items.Add($"{selectedDriverId}: {GetDriverName(selectedDriverId)}");
            comboBoxAvailableDriver.SelectedIndex = 0; // Select the first item by default
        }

        // Event handler for the Go Back button
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();

            // Show the customer dashboard screen (Form5)
            Form5 form5 = new Form5();
            form5.Show();
        }

        // Event handler for the Place Order button
        private void btn_PlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if both car and driver are selected
                if (comboBoxAvailableCar.SelectedItem == null || comboBoxAvailableDriver.SelectedItem == null)
                {
                    MessageBox.Show("Please select a car and a driver.");
                    return;
                }

                // Extract car and driver IDs from the combo box selections
                int selectedCarId = int.Parse(comboBoxAvailableCar.SelectedItem.ToString().Split(':')[0]);
                int selectedDriverId = int.Parse(comboBoxAvailableDriver.SelectedItem.ToString().Split(':')[0]);

                // Retrieve customer details from text boxes
                string name = textBoxName.Text;
                string contactNumber = textBoxContactNumber.Text;
                string currentLocation = textBoxCurrentLocation.Text;
                string destination = textBoxDestination.Text;

                // Check if customer details are filled
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contactNumber) ||
                    string.IsNullOrWhiteSpace(currentLocation) || string.IsNullOrWhiteSpace(destination))
                {
                    MessageBox.Show("Please fill in all customer details.");
                    return;
                }

                // Insert customer details into the database and retrieve the customer ID
                int customerId = InsertCustomerDetails(name, contactNumber, currentLocation, destination);
                // Insert order details into the database
                InsertOrderDetails(customerId, selectedDriverId, selectedCarId);

                MessageBox.Show("Order placed successfully.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while placing the order: {ex.Message}");
            }
        }

        // Method to insert customer details into the database
        private int InsertCustomerDetails(string name, string contactNumber, string currentLocation, string destination)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;"))
            {
                connection.Open();
                string insertStatement = "INSERT INTO Customers (name, contact_number, current_location, destination) OUTPUT INSERTED.customer_id VALUES (@name, @contact_number, @current_location, @destination)";
                SqlCommand command = new SqlCommand(insertStatement, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@contact_number", contactNumber);
                command.Parameters.AddWithValue("@current_location", currentLocation);
                command.Parameters.AddWithValue("@destination", destination);

                int customerId = (int)command.ExecuteScalar();
                return customerId;
            }
        }

        // Method to insert order details into the database
        private void InsertOrderDetails(int customerId, int driverId, int carId)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;"))
            {
                connection.Open();
                string insertStatement = "INSERT INTO Orders (customer_id, driver_id, car_id, date) VALUES (@customer_id, @driver_id, @car_id, @date)";
                SqlCommand command = new SqlCommand(insertStatement, connection);
                command.Parameters.AddWithValue("@customer_id", customerId);
                command.Parameters.AddWithValue("@driver_id", driverId);
                command.Parameters.AddWithValue("@car_id", carId);
                command.Parameters.AddWithValue("@date", DateTime.Now);

                command.ExecuteNonQuery();
            }
        }

        // Method to retrieve the car model from the database based on the car ID
        private string GetCarModel(int carId)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;"))
            {
                connection.Open();
                string selectStatement = "SELECT model FROM Cars WHERE car_id = @carId";
                SqlCommand command = new SqlCommand(selectStatement, connection);
                command.Parameters.AddWithValue("@carId", carId);

                string carModel = command.ExecuteScalar().ToString();
                return carModel;
            }
        }

        // Method to retrieve the driver name from the database based on the driver ID
        private string GetDriverName(int driverId)
        {
            // Create a new SQL connection using the connection string
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;"))
            {
                // Open the connection
                connection.Open();
                // SQL select statement to retrieve the name of the driver with the given ID
                string selectStatement = "SELECT name FROM Drivers WHERE driver_id = @driverId";
                // Create a SQL command with the select statement and connection
                SqlCommand command = new SqlCommand(selectStatement, connection);
                // Set the parameter for the driver ID
                command.Parameters.AddWithValue("@driverId", driverId);

                // Execute the command to retrieve the driver name and convert it to string
                string driverName = command.ExecuteScalar().ToString();
                return driverName; // Return the driver name
            }
        }

        // Method to clear all input fields
        private void ClearFields()
        {
            // Clear the selected items in the combo boxes
            comboBoxAvailableCar.SelectedItem = null;
            comboBoxAvailableDriver.SelectedItem = null;
            // Clear the text in the text boxes
            textBoxName.Clear();
            textBoxContactNumber.Clear();
            textBoxCurrentLocation.Clear();
            textBoxDestination.Clear();
        }

        // Event handler for the Form13 Load event
        private void Form13_Load(object sender, EventArgs e)
        {
            // Empty method body
        }

        // Another event handler for the Form13 Load event
        private void Form13_Load_1(object sender, EventArgs e)
        {
            // Empty method body
        }
    }
}

