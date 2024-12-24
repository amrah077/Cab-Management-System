using System;

namespace Car_Management_System
{
    // The  class is public so it can be accessed by multiple classes.
    // This is useful because we need car details and methods in more than one form, making it easy to access.
    public class Car
    {
        // Attributes
        public int CarId { get; set; } // Unique identifier for the car
        public string Model { get; set; } 
        public string PlateNumber { get; set; } 
        public bool Availability { get; set; } // Availability status of the car (true if available, false otherwise)


        // Constructor-Initializes a new instance of the Car class with the specified details.
        public Car(int carId, string model, string plateNumber, bool availability)
        {
            this.CarId = carId; // Assigns the carId parameter to the CarId property
            this.Model = model; 
            this.PlateNumber = plateNumber; 
            this.Availability = availability; 
        }

        // Method to get car details
        // Returns a string containing the car's details.
        public string GetDetails()
        {
            // Format and return the car details as a string.
            return $"Car ID: {CarId}, Model: {Model}, Plate Number: {PlateNumber}, Availability: {(Availability ? "Available" : "Not Available")}";
        }

       
        //Function which updates the Availability property of the car.
        public void UpdateAvailability(bool available)
        {
            Availability = available; // Set the Availability property to the specified value
        }

        // Override ToString() to provide custom string representation of car details
        // This method returns a string that represents the current object.
        public override string ToString()
        {
            // Return the result of GetDetails() method
            return GetDetails();
        }
    }
}
