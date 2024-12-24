using System;

namespace Car_Management_System
{
    partial class OrderViewingForm
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
            this.listViewCustomers = new System.Windows.Forms.ListView();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCustomers
            // 
            this.listViewCustomers.GridLines = true;
            this.listViewCustomers.HideSelection = false;
            this.listViewCustomers.Location = new System.Drawing.Point(26, 52);
            this.listViewCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCustomers.Name = "listViewCustomers";
            this.listViewCustomers.Size = new System.Drawing.Size(443, 286);
            this.listViewCustomers.TabIndex = 9;
            this.listViewCustomers.UseCompatibleStateImageBehavior = false;
            this.listViewCustomers.View = System.Windows.Forms.View.Details;
            // 
            // listViewOrders
            // 
            this.listViewOrders.GridLines = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(491, 53);
            this.listViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(443, 286);
            this.listViewOrders.TabIndex = 10;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.BackColor = System.Drawing.Color.Crimson;
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.ForeColor = System.Drawing.Color.Pink;
            this.btn_GoBack.Location = new System.Drawing.Point(808, 352);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(126, 32);
            this.btn_GoBack.TabIndex = 11;
            this.btn_GoBack.Text = "Go Back ";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(492, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 43);
            this.label2.TabIndex = 13;
            this.label2.Text = "Order Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderViewingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(956, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.listViewCustomers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderViewingForm";
            this.Text = "OrderViewingForm";
            this.Load += new System.EventHandler(this.OrderViewingForm_Load);
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListView listViewCustomers;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}