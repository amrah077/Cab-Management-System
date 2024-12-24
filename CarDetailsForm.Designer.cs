namespace Car_Management_System
{
    partial class CarDetailsForm
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
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.listViewCarDetails = new System.Windows.Forms.ListView();
            this.btn_EditCarDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.BackColor = System.Drawing.Color.Crimson;
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.ForeColor = System.Drawing.Color.Pink;
            this.btn_GoBack.Location = new System.Drawing.Point(173, 323);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(88, 33);
            this.btn_GoBack.TabIndex = 7;
            this.btn_GoBack.Text = "Go Back ";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // listViewCarDetails
            // 
            this.listViewCarDetails.GridLines = true;
            this.listViewCarDetails.HideSelection = false;
            this.listViewCarDetails.Location = new System.Drawing.Point(9, 23);
            this.listViewCarDetails.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCarDetails.Name = "listViewCarDetails";
            this.listViewCarDetails.Size = new System.Drawing.Size(583, 286);
            this.listViewCarDetails.TabIndex = 8;
            this.listViewCarDetails.UseCompatibleStateImageBehavior = false;
            this.listViewCarDetails.View = System.Windows.Forms.View.Details;
            // 
            // btn_EditCarDetails
            // 
            this.btn_EditCarDetails.BackColor = System.Drawing.Color.Crimson;
            this.btn_EditCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCarDetails.ForeColor = System.Drawing.Color.Pink;
            this.btn_EditCarDetails.Location = new System.Drawing.Point(339, 323);
            this.btn_EditCarDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditCarDetails.Name = "btn_EditCarDetails";
            this.btn_EditCarDetails.Size = new System.Drawing.Size(128, 32);
            this.btn_EditCarDetails.TabIndex = 12;
            this.btn_EditCarDetails.Text = "Edit Car Details";
            this.btn_EditCarDetails.UseVisualStyleBackColor = false;
            this.btn_EditCarDetails.Click += new System.EventHandler(this.btn_EditCarDetails_Click);
            // 
            // CarDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_EditCarDetails);
            this.Controls.Add(this.listViewCarDetails);
            this.Controls.Add(this.btn_GoBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CarDetailsForm";
            this.Text = "CarDetailsForm";
            this.Load += new System.EventHandler(this.CarDetailsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.ListView listViewCarDetails;
        private System.Windows.Forms.Button btn_EditCarDetails;
    }
}