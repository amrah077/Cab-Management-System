using Car_Management_System;
using System;

namespace CarManagementSystem
{
    public class Driver : Person // The Driver class inherits from the Person class
    {
        public int DriverId { get; set; } 
        public bool Availability { get; set; } 

        // Constructor to initialize the Driver object with provided values
        public Driver(int driverId, string name, string contactNumber, bool availability = true)
            : base(name, contactNumber) // Call the base class (Person) constructor to initialize name and contact number
        {
            DriverId = driverId; 
            Availability = availability; // Set the Availability property, default value is true
        }

        // Method to get driver details as a formatted string
        public string GetDetails()
        {
            // Return a string containing driver details
            return $"ID: {DriverId}, Name: {Name}, Contact: {ContactNumber}, Availability: {Availability}";
        }

        // Method to update the availability status of the driver
        public void UpdateAvailability(bool availability)
        {
            Availability = availability; // Update the Availability property with the new value
        }
    }
}
