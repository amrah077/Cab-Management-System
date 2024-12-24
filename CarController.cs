using Car_Management_System;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Management_System
{
    public class CarController
    {
        // Connection string for the SQL Server database
        private string connectionString = "Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;";

        // Method to get a list of available cars from the database
        public List<Car> GetAvailableCars()
        {
            // List to store available cars
            List<Car> availableCars = new List<Car>();

            try
            {
                // Establishing connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Open the connection

                    // SQL query to select available cars
                    string selectStatement = "SELECT car_id, model, plate_number, availability FROM Cars WHERE availability = 1";
                    SqlCommand command = new SqlCommand(selectStatement, connection);
                    SqlDataReader reader = command.ExecuteReader(); // Execute the query and get a data reader

                    // Read data from the reader and add to the list
                    while (reader.Read())
                    {
                        int carId = reader.GetInt32(0);
                        string model = reader.GetString(1);
                        string plateNumber = reader.GetString(2);
                        bool availability = reader.GetBoolean(3);

                        availableCars.Add(new Car(carId, model, plateNumber, availability));
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during data retrieval
                throw new Exception($"An error occurred while fetching available cars: {ex.Message}");
            }

            return availableCars; // Return the list of available cars
        }

        // Method to get a list of all cars from the database
        public List<Car> GetAllCars()
        {
            // List to store all cars
            List<Car> allCars = new List<Car>();

            try
            {
                // Establishing connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Open the connection

                    // SQL query to select all cars
                    string selectStatement = "SELECT car_id, model, plate_number, availability FROM Cars";
                    SqlCommand command = new SqlCommand(selectStatement, connection);
                    SqlDataReader reader = command.ExecuteReader(); // Execute the query and get a data reader

                    // Read data from the reader and add to the list
                    while (reader.Read())
                    {
                        int carId = reader.GetInt32(0);
                        string model = reader.GetString(1);
                        string plateNumber = reader.GetString(2);
                        bool availability = reader.GetBoolean(3);

                        allCars.Add(new Car(carId, model, plateNumber, availability));
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during data retrieval
                throw new Exception($"An error occurred while fetching all cars: {ex.Message}");
            }

            return allCars; // Return the list of all cars
        }

        // Method to add a new car to the database
        public void AddCar(Car newCar)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to insert a new car record
                string queryInsertCar = "INSERT INTO Cars (model, plate_number, availability) VALUES (@Model, @PlateNumber, @Availability)";

                SqlCommand commandInsertCar = new SqlCommand(queryInsertCar, connection);

                // Add parameters to the SQL command
                commandInsertCar.Parameters.AddWithValue("@Model", newCar.Model);
                commandInsertCar.Parameters.AddWithValue("@PlateNumber", newCar.PlateNumber);
                commandInsertCar.Parameters.AddWithValue("@Availability", newCar.Availability);

                try
                {
                    connection.Open(); // Open the connection

                    // Execute the insert command
                    int rowsAffected = commandInsertCar.ExecuteNonQuery();

                    // Check if the insert was successful
                    if (rowsAffected <= 0)
                    {
                        throw new Exception("Failed to add car to the list");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during data insertion
                    throw new Exception($"Error: {ex.Message}");
                }
            }
        }

        // Method to delete a car from the database
        public void DeleteCar(int carId)
        {
            // SQL query to delete a car record
            string deleteStatement = $"DELETE FROM Cars WHERE car_id = {carId}";

            try
            {
                // Establishing connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Open the connection

                    SqlCommand command = new SqlCommand(deleteStatement, connection);

                    // Execute the delete command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the delete was successful
                    if (rowsAffected <= 0)
                    {
                        throw new Exception("No records were deleted from the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during data deletion
                throw new Exception($"An error occurred while deleting the car: {ex.Message}");
            }
        }


        // Method to update car details in the database
        public void UpdateCarDetails(Car updatedCar)
        {
            // SQL query to update a car record
            string updateStatement = "UPDATE Cars SET model = @Model, plate_number = @PlateNumber, availability = @Availability WHERE car_id = @CarId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commandUpdateCar = new SqlCommand(updateStatement, connection);

                // Add parameters to the SQL command
                commandUpdateCar.Parameters.AddWithValue("@Model", updatedCar.Model);
                commandUpdateCar.Parameters.AddWithValue("@PlateNumber", updatedCar.PlateNumber);
                commandUpdateCar.Parameters.AddWithValue("@Availability", updatedCar.Availability);
                commandUpdateCar.Parameters.AddWithValue("@CarId", updatedCar.CarId);

                try
                {
                    connection.Open(); // Open the connection

                    // Execute the update command
                    int rowsAffected = commandUpdateCar.ExecuteNonQuery();

                    // Check if the update was successful
                    if (rowsAffected <= 0)
                    {
                        throw new Exception("Failed to update car details");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during data update
                    throw new Exception($"Error: {ex.Message}");
                }
            }
        }
    }
}
