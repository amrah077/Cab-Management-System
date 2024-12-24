using System;

namespace CarManagementSystem
{
    public class Customer : Person // The Customer class inherits from the Person class
    {
        //public int CustomerId: This is a property named CustomerId of type int. It can be accessed publicly, meaning it can be read from outside the class.
        //{ get; private set; }: This indicates that the property has a public getter and a private setter.The get accessor allows reading the value of CustomerId from outside the class, while the set accessor can only be used within the class
        public int CustomerId { get; private set; } // Unique identifier for the customer, read-only outside the class(private)
        public string CurrentLocation { get; private set; } 
        public string Destination { get; private set; } 

        // Constructor to initialize the Customer object with provided values
        public Customer(int customerId, string name, string contactNumber, string currentLocation, string destination)
            : base(name, contactNumber) // Call the base class (Person) constructor to initialize name and contact number
        {
            CustomerId = customerId; 
            CurrentLocation = currentLocation; 
            Destination = destination; 
        }

        // Method to print the details of the customer to the console
        public void GetDetails()
        {
            Console.WriteLine($"Customer ID: {CustomerId}"); 
            Console.WriteLine($"Name: {Name}"); // Print Name (inherited from Person class)
            Console.WriteLine($"Contact Number: {ContactNumber}"); // Print Contact Number (inherited from Person class)
            Console.WriteLine($"Current Location: {CurrentLocation}"); 
            Console.WriteLine($"Destination: {Destination}"); 
        }
    }
}
