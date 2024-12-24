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
    // Form2 represents a menu for managing cars, drivers, and viewing orders
    public partial class Form2 : Form
    {
        private List<Car> carsList; // Declare carsList to hold the list of cars

        // Constructor to initialize an instance of Form2 with a list of cars
        public Form2(List<Car> carsList)
        {
            InitializeComponent();
            this.carsList = carsList; // Assign the provided list to the local variable
        }

        // Event handler triggered when label1 is clicked (but this handler is empty)
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Event handler triggered when linkLabel1 is clicked to go back to the login screen (Form1)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Close Form2
            this.Close();

            // Show Form1 (login screen)
            Form1 form1 = new Form1();
            form1.Show();
        }

        // Event handler triggered when "Manage Cars" button is clicked
        private void btn_ManageCars_Click(object sender, EventArgs e)
        {
            // Open Form3 for managing cars and close Form2
            Form3 form3 = new Form3(carsList);
            form3.Show();
            this.Close();
        }

        // Event handler triggered when "Manage Drivers" button is clicked
        private void btn_ManageDrivers_Click(object sender, EventArgs e)
        {
            // Open Form4 for managing drivers and close Form2
            Form4 form4 = new Form4(carsList);
            form4.Show();
            this.Close();
        }

        // Event handler triggered when "View Orders" button is clicked
        private void btn_ViewOrders_Click(object sender, EventArgs e)
        {
            // Open OrderViewingForm for viewing orders (without passing any arguments)
            OrderViewingForm form = new OrderViewingForm();
            form.Show();
        }

        // Event handler triggered when Form2 is loaded (but this handler is empty)
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
