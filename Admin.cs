using CarManagementSystem;
using System;
using System.Collections.Generic;

namespace Car_Management_System
{
    public class Admin
    {
        // Lists made to store cars and drivers when car/driver objects are added
        private List<Car> cars = new List<Car>();
        private List<Driver> drivers = new List<Driver>();

        // Function to add a car
        public void AddCar(Car car)
        {
            // Adding the car to the list
            cars.Add(car);
            // Display a confirmation message popup.
            Console.WriteLine($"Car {car.Model} with plate number {car.PlateNumber} added successfully.");
        }

        // Function to remove a car
        public void RemoveCar(Car car)
        {
            // Check if the car exists in the list
            if (cars.Contains(car))
            {
                // Remove the car from the list
                cars.Remove(car);
                // Display a confirmation message
                Console.WriteLine($"Car {car.Model} with plate number {car.PlateNumber} removed successfully.");
            }
            else
            {
                // Display an error message if the car is not found
                Console.WriteLine($"Car {car.Model} with plate number {car.PlateNumber} not found.");
            }
        }

        // Method to view available cars
        public void ViewAvailableCars()
        {

            Console.WriteLine("Available Cars:");
            // Iterate through the list of cars
            foreach (var car in cars)
            {
                // Check if the car is available
                if (car.Availability)
                {
                    // Display the details of the available car
                    Console.WriteLine(car.GetDetails()); //calling a method from anoher class therefore we use classname first then . then function name.
                }
            }
        }

        // Method to view available drivers
        public void ViewAvailableDrivers()
        {

            Console.WriteLine("Available Drivers:");
            // Iterate through the list of drivers
            foreach (var driver in drivers)
            {
                // Check if the driver is available
                if (driver.Availability)
                {
                    // Display the details of the available driver
                    Console.WriteLine(driver.GetDetails());
                }
            }
        }
    }
}
