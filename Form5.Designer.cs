namespace Car_Management_System
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_PlaceOrder = new System.Windows.Forms.Button();
            this.btn_AvailableDrivers = new System.Windows.Forms.Button();
            this.btn_AvailableCars = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.LightPink;
            this.lbl_User.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_User.Location = new System.Drawing.Point(238, 9);
            this.lbl_User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(206, 37);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "User Dashboard";
            this.lbl_User.Click += new System.EventHandler(this.lbl_User_Click);
            // 
            // btn_PlaceOrder
            // 
            this.btn_PlaceOrder.BackColor = System.Drawing.Color.Crimson;
            this.btn_PlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlaceOrder.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceOrder.ForeColor = System.Drawing.Color.Pink;
            this.btn_PlaceOrder.Location = new System.Drawing.Point(472, 139);
            this.btn_PlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PlaceOrder.Name = "btn_PlaceOrder";
            this.btn_PlaceOrder.Size = new System.Drawing.Size(193, 185);
            this.btn_PlaceOrder.TabIndex = 6;
            this.btn_PlaceOrder.Text = "Place an Order";
            this.btn_PlaceOrder.UseVisualStyleBackColor = false;
            this.btn_PlaceOrder.Click += new System.EventHandler(this.btn_PlaceOrder_Click);
            // 
            // btn_AvailableDrivers
            // 
            this.btn_AvailableDrivers.BackColor = System.Drawing.Color.Crimson;
            this.btn_AvailableDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AvailableDrivers.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AvailableDrivers.ForeColor = System.Drawing.Color.Pink;
            this.btn_AvailableDrivers.Location = new System.Drawing.Point(254, 139);
            this.btn_AvailableDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AvailableDrivers.Name = "btn_AvailableDrivers";
            this.btn_AvailableDrivers.Size = new System.Drawing.Size(190, 185);
            this.btn_AvailableDrivers.TabIndex = 5;
            this.btn_AvailableDrivers.Text = "Available Drivers";
            this.btn_AvailableDrivers.UseVisualStyleBackColor = false;
            this.btn_AvailableDrivers.Click += new System.EventHandler(this.btn_AvailableDrivers_Click);
            // 
            // btn_AvailableCars
            // 
            this.btn_AvailableCars.BackColor = System.Drawing.Color.Crimson;
            this.btn_AvailableCars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AvailableCars.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AvailableCars.ForeColor = System.Drawing.Color.Pink;
            this.btn_AvailableCars.Location = new System.Drawing.Point(32, 139);
            this.btn_AvailableCars.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AvailableCars.Name = "btn_AvailableCars";
            this.btn_AvailableCars.Size = new System.Drawing.Size(188, 185);
            this.btn_AvailableCars.TabIndex = 4;
            this.btn_AvailableCars.Text = "Available Cars";
            this.btn_AvailableCars.UseVisualStyleBackColor = false;
            this.btn_AvailableCars.Click += new System.EventHandler(this.btn_AvailableCars_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.LightPink;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Crimson;
            this.linkLabel1.Location = new System.Drawing.Point(610, 11);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 24);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(196, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 56);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to the User Dashboard \r\nWhat would you like to do today ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(701, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_PlaceOrder);
            this.Controls.Add(this.btn_AvailableDrivers);
            this.Controls.Add(this.btn_AvailableCars);
            this.Controls.Add(this.lbl_User);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_PlaceOrder;
        private System.Windows.Forms.Button btn_AvailableDrivers;
        private System.Windows.Forms.Button btn_AvailableCars;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}