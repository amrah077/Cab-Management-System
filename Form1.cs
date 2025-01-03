﻿using System;
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
    public partial class Form1 : Form // Form1: Form to show inheritance
    {
        // Declare carsList. This is accessible to all the methods within the form1 class
        private List<Car> carsList;

        public Form1()
        {
            InitializeComponent(); // InitializeComponent() is a method generated by the designer that initializes the form's components, in this case, the carsList.

            // Initialize carsList (assuming it's initialized here, replace this with your actual initialization)
            carsList = new List<Car>();
        }

        private void btn_Login_Click(object sender, EventArgs e) // event handler called when login button is clicked.
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Admin Login Successful");
                // Pass carsList to Form2
                Form2 form2 = new Form2(carsList);
                form2.Show();

            }
            else if (username == "user" && password == "password123")
            {
                MessageBox.Show("User Login Successful");
                Form5 form5 = new Form5();
                form5.Show();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password! Please try again.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Event handler for when the form loads
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event handler for clicking on a label
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            // Event handler for when the text in the username textbox changes
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            // Event handler for clicking on a label
        }
    }
}
