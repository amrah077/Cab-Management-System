using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Management_System
{
    // Form3 represents the screen for managing cars
    public partial class Form3 : Form
    {
        private List<Car> carsList; // Declare carsList as a private field to hold the list of cars

        // Constructor that accepts a list of cars as a parameter
        public Form3(List<Car> carsList)
        {
            InitializeComponent();
            this.carsList = carsList; // Assign the provided list to the local variable
        }

        // Event handler triggered when label1 is clicked (but this handler is empty)
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Event handler triggered when "Go Back" button is clicked
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form3

            // Show Form2 (admin dashboard screen) and pass carsList to it
            Form2 form2 = new Form2(carsList);
            form2.Show();
        }

        // Event handler triggered when "Add Cars" button is clicked
        private void btn_AddCars_Click(object sender, EventArgs e)
        {
            // Open Form6 for adding cars and pass carsList to it, then close Form3
            Form6 form6 = new Form6(carsList);
            form6.Show();
            this.Close();
        }

        // Event handler triggered when "View Car Details" button is clicked
        private void btn_ViewCarDetails_Click(object sender, EventArgs e)
        {
            // Open CarDetailsForm for viewing car details and pass carsList to it
            CarDetailsForm carDetailsForm = new CarDetailsForm(carsList);
            carDetailsForm.Show();
        }

        // Event handler triggered when "Remove Cars" button is clicked
        private void btn_RemoveCars_Click(object sender, EventArgs e)
        {
            // Open Form7 for removing cars and pass carsList to it, then close Form3
            Form7 form7 = new Form7(carsList);
            form7.Show();
            this.Close();
        }

        // Event handler triggered when Form3 is loaded (but this handler is empty)
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
