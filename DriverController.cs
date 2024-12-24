using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CarManagementSystem;

namespace Car_Management_System
{
    public class DriverController
    {
        // Connection string to connect to the SQL Server database
        private string connectionString = "Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;";

        // Method to add a new driver to the database
        public void AddDriver(Driver newDriver)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL statement to insert a new driver
                string insertStatement = "INSERT INTO Drivers (name, contact_number, availability) VALUES (@name, @contact_number, @availability)";

                // Create a SQL command and assign the insert statement and connection
                SqlCommand command = new SqlCommand(insertStatement, connection);

                // Add parameters to the command
                command.Parameters.AddWithValue("@name", newDriver.Name);
                command.Parameters.AddWithValue("@contact_number", newDriver.ContactNumber);
                command.Parameters.AddWithValue("@availability", newDriver.Availability);

                try
                {
                    connection.Open(); // Open the connection
                    command.ExecuteNonQuery(); // Execute the command
                }
                catch (Exception ex)
                {
                    // Throw an exception if an error occurs
                    throw new Exception($"An error occurred while adding the driver: {ex.Message}");
                }
            }
        }

        // Method to delete a driver from the database using driver ID
        public void DeleteDriver(int driverId)
        {
            // SQL statement to delete a driver by ID
            string deleteStatement = $"DELETE FROM Drivers WHERE driver_id = {driverId}";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Open the connection
                    SqlCommand command = new SqlCommand(deleteStatement, connection); // Create a SQL command
                    int rowsAffected = command.ExecuteNonQuery(); // Execute the command and get the number of affected rows

                    if (rowsAffected <= 0)
                    {
                        // Throw an exception if no rows were deleted
                        throw new Exception("No records were deleted from the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Throw an exception if an error occurs
                throw new Exception($"An error occurred while deleting the driver: {ex.Message}");
            }
        }

        // Method to get all drivers from the database
        public List<Driver> GetAllDrivers()
        {
            List<Driver> driversList = new List<Driver>(); // List to store driver objects

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Open the connection
                    string selectStatement = "SELECT driver_id, name, contact_number, availability FROM Drivers"; // SQL statement to select all drivers
                    SqlCommand command = new SqlCommand(selectStatement, connection); // Create a SQL command
                    SqlDataReader reader = command.ExecuteReader(); // Execute the command and get a data reader

                    // Read each row from the data reader
                    while (reader.Read())
                    {
                        int driverId = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string contactNumber = reader.GetString(2);
                        bool availability = reader.GetBoolean(3);

                        // Create a new Driver object and add it to the list
                        driversList.Add(new Driver(driverId, name, contactNumber, availability));
                    }
                }
            }
            catch (Exception ex)
            {
                // Throw an exception if an error occurs
                throw new Exception($"An error occurred while fetching drivers: {ex.Message}");
            }

            return driversList; 
        }

        // Method to update driver details in the database
        public void UpdateDriverDetails(Driver updatedDriver)
        {
            // SQL statement to update driver details
            string updateStatement = "UPDATE Drivers SET name = @name, contact_number = @contact_number, availability = @availability WHERE driver_id = @driver_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(updateStatement, connection); // Create a SQL command
                // Add parameters to the command
                command.Parameters.AddWithValue("@driver_id", updatedDriver.DriverId);
                command.Parameters.AddWithValue("@name", updatedDriver.Name);
                command.Parameters.AddWithValue("@contact_number", updatedDriver.ContactNumber);
                command.Parameters.AddWithValue("@availability", updatedDriver.Availability);

                try
                {
                    connection.Open(); // Open the connection
                    int rowsAffected = command.ExecuteNonQuery(); // Execute the command and get the number of affected rows

                    if (rowsAffected <= 0)
                    {
                        // Throw an exception if no rows were updated
                        throw new Exception("No records were updated.");
                    }
                }
                
                catch (Exception ex)
                {
                    // Throw an exception if an error occurs
                    throw new Exception($"An error occurred while updating driver details: {ex.Message}");
                }
            }
        }
    }
}
