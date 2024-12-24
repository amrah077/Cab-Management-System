namespace Car_Management_System
{
    partial class Form9
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDriverID = new System.Windows.Forms.ComboBox();
            this.comboBoxDriverName = new System.Windows.Forms.ComboBox();
            this.comboBoxContactNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxDriverAvailability = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select the Driver Details to Delete";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.BackColor = System.Drawing.Color.Crimson;
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.ForeColor = System.Drawing.Color.Pink;
            this.btn_GoBack.Location = new System.Drawing.Point(595, 305);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(77, 33);
            this.btn_GoBack.TabIndex = 23;
            this.btn_GoBack.Text = "Go Back ";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(163, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Enter Driver ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(140, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Enter Driver Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(49, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter Driver Contact Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(140, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Driver Availability :";
            // 
            // comboBoxDriverID
            // 
            this.comboBoxDriverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDriverID.FormattingEnabled = true;
            this.comboBoxDriverID.Location = new System.Drawing.Point(321, 80);
            this.comboBoxDriverID.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDriverID.Name = "comboBoxDriverID";
            this.comboBoxDriverID.Size = new System.Drawing.Size(282, 25);
            this.comboBoxDriverID.TabIndex = 28;
            // 
            // comboBoxDriverName
            // 
            this.comboBoxDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDriverName.FormattingEnabled = true;
            this.comboBoxDriverName.Location = new System.Drawing.Point(321, 128);
            this.comboBoxDriverName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDriverName.Name = "comboBoxDriverName";
            this.comboBoxDriverName.Size = new System.Drawing.Size(282, 25);
            this.comboBoxDriverName.TabIndex = 29;
            // 
            // comboBoxContactNumber
            // 
            this.comboBoxContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContactNumber.FormattingEnabled = true;
            this.comboBoxContactNumber.Location = new System.Drawing.Point(321, 177);
            this.comboBoxContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxContactNumber.Name = "comboBoxContactNumber";
            this.comboBoxContactNumber.Size = new System.Drawing.Size(282, 25);
            this.comboBoxContactNumber.TabIndex = 30;
            // 
            // comboBoxDriverAvailability
            // 
            this.comboBoxDriverAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDriverAvailability.FormattingEnabled = true;
            this.comboBoxDriverAvailability.Location = new System.Drawing.Point(322, 224);
            this.comboBoxDriverAvailability.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDriverAvailability.Name = "comboBoxDriverAvailability";
            this.comboBoxDriverAvailability.Size = new System.Drawing.Size(282, 25);
            this.comboBoxDriverAvailability.TabIndex = 31;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Pink;
            this.btn_Delete.Location = new System.Drawing.Point(322, 271);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(88, 33);
            this.btn_Delete.TabIndex = 32;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Crimson;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Pink;
            this.btn_Clear.Location = new System.Drawing.Point(479, 271);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(88, 33);
            this.btn_Clear.TabIndex = 33;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(683, 349);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.comboBoxDriverAvailability);
            this.Controls.Add(this.comboBoxContactNumber);
            this.Controls.Add(this.comboBoxDriverName);
            this.Controls.Add(this.comboBoxDriverID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDriverID;
        private System.Windows.Forms.ComboBox comboBoxDriverName;
        private System.Windows.Forms.ComboBox comboBoxContactNumber;
        private System.Windows.Forms.ComboBox comboBoxDriverAvailability;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
    }
}