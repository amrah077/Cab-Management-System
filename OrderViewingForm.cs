using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Management_System
{
    public partial class OrderViewingForm : Form
    {
        // Connection string to connect to the database
        private string connectionString = "Data Source=DESKTOP-HMHKFJI\\SQLEXPRESS;Initial Catalog=CarManagementSystem;Integrated Security=True;";

        // Constructor for the OrderViewingForm
        public OrderViewingForm()
        {
            InitializeComponent();
            InitializeListViewColumns(); // Initialize the columns of the ListView controls
            LoadCustomersData(); // Load customer data into the ListView
            LoadOrdersData(); // Load order data into the ListView
        }

        // Method to initialize the columns of the ListView controls
        private void InitializeListViewColumns()
        {
            // Clear existing columns in the ListViews
            listViewCustomers.Columns.Clear();
            listViewOrders.Columns.Clear();

            // Add columns for Customers
            listViewCustomers.Columns.Add("Customer ID", 100);
            listViewCustomers.Columns.Add("Name", 150);
            listViewCustomers.Columns.Add("Contact Number", 150);
            listViewCustomers.Columns.Add("Current Location", 150);
            listViewCustomers.Columns.Add("Destination", 150);

            // Add columns for Orders
            listViewOrders.Columns.Add("Order ID", 100);
            listViewOrders.Columns.Add("Customer ID", 100);
            listViewOrders.Columns.Add("Driver ID", 100);
            listViewOrders.Columns.Add("Car ID", 100);
            listViewOrders.Columns.Add("Date", 100);

            // Set ListView properties
            listViewCustomers.View = View.Details;
            listViewOrders.View = View.Details;
            listViewCustomers.GridLines = true;
            listViewOrders.GridLines = true;
            listViewCustomers.FullRowSelect = true;
            listViewOrders.FullRowSelect = true;
        }

        // Method to load customer data into the ListView
        private void LoadCustomersData()
        {
            // Clear existing items in the ListView
            listViewCustomers.Items.Clear();

            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectStatement = "SELECT * FROM Customers";
                    SqlCommand command = new SqlCommand(selectStatement, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Iterate through the results and add them to the ListView
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["customer_id"].ToString());
                        item.SubItems.Add(reader["name"].ToString());
                        item.SubItems.Add(reader["contact_number"].ToString());
                        item.SubItems.Add(reader["current_location"].ToString());
                        item.SubItems.Add(reader["destination"].ToString());
                        listViewCustomers.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customer data: {ex.Message}");
            }
        }

        // Method to load order data into the ListView
        private void LoadOrdersData()
        {
            // Clear existing items in the ListView
            listViewOrders.Items.Clear();

            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectStatement = "SELECT * FROM Orders";
                    SqlCommand command = new SqlCommand(selectStatement, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Iterate through the results and add them to the ListView
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["order_id"].ToString());
                        item.SubItems.Add(reader["customer_id"].ToString());
                        item.SubItems.Add(reader["driver_id"].ToString());
                        item.SubItems.Add(reader["car_id"].ToString());
                        item.SubItems.Add(reader["date"].ToString());
                        listViewOrders.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading order data: {ex.Message}");
            }
        }

        // Event handler for the Go Back button
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            // Show Form3 (previous screen)
            Form3 form3 = new Form3(new List<Car>()); // Pass appropriate data as needed
            form3.Show();
        }

        // Event handler for the OrderViewingForm load event
        private void OrderViewingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
