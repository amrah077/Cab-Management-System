namespace Car_Management_System
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_ViewDriverDetails = new System.Windows.Forms.Button();
            this.btn_RemoveDrivers = new System.Windows.Forms.Button();
            this.btn_AddDrivers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Drivers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.BackColor = System.Drawing.Color.Crimson;
            this.btn_GoBack.ForeColor = System.Drawing.Color.Pink;
            this.btn_GoBack.Location = new System.Drawing.Point(396, 258);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(89, 33);
            this.btn_GoBack.TabIndex = 5;
            this.btn_GoBack.Text = "Go Back ";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_ViewDriverDetails
            // 
            this.btn_ViewDriverDetails.BackColor = System.Drawing.Color.Crimson;
            this.btn_ViewDriverDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewDriverDetails.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewDriverDetails.ForeColor = System.Drawing.Color.Pink;
            this.btn_ViewDriverDetails.Location = new System.Drawing.Point(156, 205);
            this.btn_ViewDriverDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewDriverDetails.Name = "btn_ViewDriverDetails";
            this.btn_ViewDriverDetails.Size = new System.Drawing.Size(198, 42);
            this.btn_ViewDriverDetails.TabIndex = 8;
            this.btn_ViewDriverDetails.Text = "View Driver Details";
            this.btn_ViewDriverDetails.UseVisualStyleBackColor = false;
            this.btn_ViewDriverDetails.Click += new System.EventHandler(this.btn_ViewDriverDetails_Click);
            // 
            // btn_RemoveDrivers
            // 
            this.btn_RemoveDrivers.BackColor = System.Drawing.Color.Crimson;
            this.btn_RemoveDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoveDrivers.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveDrivers.ForeColor = System.Drawing.Color.Pink;
            this.btn_RemoveDrivers.Location = new System.Drawing.Point(156, 131);
            this.btn_RemoveDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RemoveDrivers.Name = "btn_RemoveDrivers";
            this.btn_RemoveDrivers.Size = new System.Drawing.Size(198, 42);
            this.btn_RemoveDrivers.TabIndex = 7;
            this.btn_RemoveDrivers.Text = "Remove Drivers";
            this.btn_RemoveDrivers.UseVisualStyleBackColor = false;
            this.btn_RemoveDrivers.Click += new System.EventHandler(this.btn_RemoveDrivers_Click);
            // 
            // btn_AddDrivers
            // 
            this.btn_AddDrivers.BackColor = System.Drawing.Color.Crimson;
            this.btn_AddDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddDrivers.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddDrivers.ForeColor = System.Drawing.Color.Pink;
            this.btn_AddDrivers.Location = new System.Drawing.Point(156, 63);
            this.btn_AddDrivers.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddDrivers.Name = "btn_AddDrivers";
            this.btn_AddDrivers.Size = new System.Drawing.Size(198, 42);
            this.btn_AddDrivers.TabIndex = 6;
            this.btn_AddDrivers.Text = "Add Drivers";
            this.btn_AddDrivers.UseVisualStyleBackColor = false;
            this.btn_AddDrivers.Click += new System.EventHandler(this.btn_AddDrivers_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(507, 302);
            this.Controls.Add(this.btn_ViewDriverDetails);
            this.Controls.Add(this.btn_RemoveDrivers);
            this.Controls.Add(this.btn_AddDrivers);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_ViewDriverDetails;
        private System.Windows.Forms.Button btn_RemoveDrivers;
        private System.Windows.Forms.Button btn_AddDrivers;
    }
}