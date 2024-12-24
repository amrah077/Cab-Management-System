namespace Car_Management_System
{
    partial class Form2
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
            this.lbl_Admin = new System.Windows.Forms.Label();
            this.btn_ManageCars = new System.Windows.Forms.Button();
            this.btn_ManageDrivers = new System.Windows.Forms.Button();
            this.btn_ViewOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_Admin
            // 
            this.lbl_Admin.AutoSize = true;
            this.lbl_Admin.BackColor = System.Drawing.Color.LightPink;
            this.lbl_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Admin.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Admin.Location = new System.Drawing.Point(0, 0);
            this.lbl_Admin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Admin.Name = "lbl_Admin";
            this.lbl_Admin.Size = new System.Drawing.Size(228, 37);
            this.lbl_Admin.TabIndex = 0;
            this.lbl_Admin.Text = "Admin Dashboard";
            // 
            // btn_ManageCars
            // 
            this.btn_ManageCars.BackColor = System.Drawing.Color.Crimson;
            this.btn_ManageCars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageCars.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageCars.ForeColor = System.Drawing.Color.Pink;
            this.btn_ManageCars.Location = new System.Drawing.Point(23, 135);
            this.btn_ManageCars.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ManageCars.Name = "btn_ManageCars";
            this.btn_ManageCars.Size = new System.Drawing.Size(188, 185);
            this.btn_ManageCars.TabIndex = 1;
            this.btn_ManageCars.Text = "Manage Cars";
            this.btn_ManageCars.UseVisualStyleBackColor = false;
            this.btn_ManageCars.Click += new System.EventHandler(this.btn_ManageCars_Click);
            // 
            // btn_ManageDrivers
            // 
            this.btn_ManageDrivers.BackColor = System.Drawing.Color.Crimson;
            this.btn_ManageDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageDrivers.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageDrivers.ForeColor = System.Drawing.Color.Pink;
            this.btn_ManageDrivers.Location = new System.Drawing.Point(229, 135);
            this.btn_ManageDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ManageDrivers.Name = "btn_ManageDrivers";
            this.btn_ManageDrivers.Size = new System.Drawing.Size(190, 185);
            this.btn_ManageDrivers.TabIndex = 2;
            this.btn_ManageDrivers.Text = "Manage Drivers";
            this.btn_ManageDrivers.UseVisualStyleBackColor = false;
            this.btn_ManageDrivers.Click += new System.EventHandler(this.btn_ManageDrivers_Click);
            // 
            // btn_ViewOrders
            // 
            this.btn_ViewOrders.BackColor = System.Drawing.Color.Crimson;
            this.btn_ViewOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewOrders.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewOrders.ForeColor = System.Drawing.Color.Pink;
            this.btn_ViewOrders.Location = new System.Drawing.Point(442, 135);
            this.btn_ViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewOrders.Name = "btn_ViewOrders";
            this.btn_ViewOrders.Size = new System.Drawing.Size(181, 185);
            this.btn_ViewOrders.TabIndex = 3;
            this.btn_ViewOrders.Text = "View Orders";
            this.btn_ViewOrders.UseVisualStyleBackColor = false;
            this.btn_ViewOrders.Click += new System.EventHandler(this.btn_ViewOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(119, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to the Admin Dashboard \r\nPlease select the operation you would like to do" +
    "!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.LightPink;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Crimson;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Crimson;
            this.linkLabel1.Location = new System.Drawing.Point(568, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 24);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(647, 341);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ViewOrders);
            this.Controls.Add(this.btn_ManageDrivers);
            this.Controls.Add(this.btn_ManageCars);
            this.Controls.Add(this.lbl_Admin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Admin;
        private System.Windows.Forms.Button btn_ManageCars;
        private System.Windows.Forms.Button btn_ManageDrivers;
        private System.Windows.Forms.Button btn_ViewOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}