using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementSystem
{
    // Define a Person class
    public class Person
    {
        // Properties for the person's name and contact number
        public string Name { get; set; } //When you see get; set;, it indicates that the property has both a getter (to read the value) and a setter (to write the value).
        public string ContactNumber { get; set; }

        // Constructor to initialize the person's name and contact number
        //A constructor is a special method in a class that is automatically called when an instance (object) of the class is created. The purpose of a constructor is to initialize the object and set up its initial state by assigning values to its fields or properties.
        // Constructors ensure that an object is properly set up before it is used, maintaining the integrity of the object's state.
        public Person(string name, string contactNumber)
        {
            Name = name; //Name = name;: This line sets the value of the Name property to the value passed in the name parameter.
            ContactNumber = contactNumber;
        }
    }
}
