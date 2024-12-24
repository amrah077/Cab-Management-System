namespace Car_Management_System
{
    partial class DriverDetailsForm
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
            this.listViewDriverDetails = new System.Windows.Forms.ListView();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_EditDriverDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewDriverDetails
            // 
            this.listViewDriverDetails.GridLines = true;
            this.listViewDriverDetails.HideSelection = false;
            this.listViewDriverDetails.Location = new System.Drawing.Point(9, 27);
            this.listViewDriverDetails.Margin = new System.Windows.Forms.Padding(2);
            this.listViewDriverDetails.Name = "listViewDriverDetails";
            this.listViewDriverDetails.Size = new System.Drawing.Size(583, 286);
            this.listViewDriverDetails.TabIndex = 9;
            this.listViewDriverDetails.UseCompatibleStateImageBehavior = false;
            this.listViewDriverDetails.View = System.Windows.Forms.View.Details;
            this.listViewDriverDetails.SelectedIndexChanged += new System.EventHandler(this.listViewDriverDetails_SelectedIndexChanged);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.BackColor = System.Drawing.Color.Crimson;
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.ForeColor = System.Drawing.Color.Pink;
            this.btn_GoBack.Location = new System.Drawing.Point(162, 323);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(88, 33);
            this.btn_GoBack.TabIndex = 10;
            this.btn_GoBack.Text = "Go Back ";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click_1);
            // 
            // btn_EditDriverDetails
            // 
            this.btn_EditDriverDetails.BackColor = System.Drawing.Color.Crimson;
            this.btn_EditDriverDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditDriverDetails.ForeColor = System.Drawing.Color.Pink;
            this.btn_EditDriverDetails.Location = new System.Drawing.Point(348, 323);
            this.btn_EditDriverDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditDriverDetails.Name = "btn_EditDriverDetails";
            this.btn_EditDriverDetails.Size = new System.Drawing.Size(128, 33);
            this.btn_EditDriverDetails.TabIndex = 11;
            this.btn_EditDriverDetails.Text = "Edit Driver Details";
            this.btn_EditDriverDetails.UseVisualStyleBackColor = false;
            this.btn_EditDriverDetails.Click += new System.EventHandler(this.btn_EditDriverDetails_Click);
            // 
            // DriverDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_EditDriverDetails);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.listViewDriverDetails);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DriverDetailsForm";
            this.Text = "DriverDetailsForm";
            this.Load += new System.EventHandler(this.DriverDetailsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDriverDetails;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_EditDriverDetails;
    }
}