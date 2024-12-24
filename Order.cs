using Car_Management_System; // Importing the Car_Management_System namespace
using System; // Importing the System namespace

namespace CarManagementSystem
{
    // Declaration of the Order class
    public class Order
    {
        // Properties of the Order class
        public int order_id { get; private set; } // An integer property representing the order ID
        public Customer customer { get; private set; } // A Customer object representing the customer associated with the order
        public Driver driver { get; private set; } // A Driver object representing the driver associated with the order
        public DateTime date { get; private set; } // A DateTime object representing the date of the order

        // Constructor of the Order class
        public Order(int orderId, Customer customer, Driver driver, DateTime date)
        {
            // Assigning values to the properties of the Order object
            this.order_id = orderId; // Assigning the provided orderId to the order_id property
            this.customer = customer; 
            this.driver = driver; 
            this.date = date; 
        }

        // Method to print order details to the console
        public void get_details()
        {
            // Printing order details to the console
            Console.WriteLine($"Order ID: {order_id}"); // Printing the order ID
            Console.WriteLine($"Customer: {customer.Name}"); // Printing the customer's name
            Console.WriteLine($"Driver: {driver.Name}"); // Printing the driver's name
            Console.WriteLine($"Date: {date}"); // Printing the date of the order
        }
    }
}
