namespace Car_Management_System
{
    partial class Form12
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
            this.listBoxAvailableDrivers = new System.Windows.Forms.ListBox();
            this.btn_SelectDriver = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAvailableDrivers
            // 
            this.listBoxAvailableDrivers.FormattingEnabled = true;
            this.listBoxAvailableDrivers.Location = new System.Drawing.Point(26, 33);
            this.listBoxAvailableDrivers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAvailableDrivers.Name = "listBoxAvailableDrivers";
            this.listBoxAvailableDrivers.Size = new System.Drawing.Size(548, 160);
            this.listBoxAvailableDrivers.TabIndex = 1;
            // 
            // btn_SelectDriver
            // 
            this.btn_SelectDriver.BackColor = System.Drawing.Color.Crimson;
            this.btn_SelectDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectDriver.ForeColor = System.Drawing.Color.Pink;
            this.btn_SelectDriver.Location = new System.Drawing.Point(133, 212);
            this.btn_SelectDriver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SelectDriver.Name = "btn_SelectDriver";
            this.btn_SelectDriver.Size = new System.Drawing.Size(102, 38);
            this.btn_SelectDriver.TabIndex = 8;
            this.btn_SelectDriver.Text = "Select Driver";
            this.btn_SelectDriver.UseVisualStyleBackColor = false;
            this.btn_SelectDriver.Click += new System.EventHandler(this.btn_SelectDriver_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.BackColor = System.Drawing.Color.Crimson;
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.ForeColor = System.Drawing.Color.Pink;
            this.btn_GoBack.Location = new System.Drawing.Point(380, 212);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(104, 38);
            this.btn_GoBack.TabIndex = 9;
            this.btn_GoBack.Text = "Go Back";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(600, 291);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_SelectDriver);
            this.Controls.Add(this.listBoxAvailableDrivers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailableDrivers;
        private System.Windows.Forms.Button btn_SelectDriver;
        private System.Windows.Forms.Button btn_GoBack;
    }
}