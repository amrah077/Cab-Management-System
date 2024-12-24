namespace Car_Management_System
{
    partial class Form11
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
            this.listBoxAvailableCars = new System.Windows.Forms.ListBox();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_SelectCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAvailableCars
            // 
            this.listBoxAvailableCars.FormattingEnabled = true;
            this.listBoxAvailableCars.Location = new System.Drawing.Point(29, 32);
            this.listBoxAvailableCars.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAvailableCars.Name = "listBoxAvailableCars";
            this.listBoxAvailableCars.Size = new System.Drawing.Size(548, 160);
            this.listBoxAvailableCars.TabIndex = 0;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.BackColor = System.Drawing.Color.Crimson;
            this.btn_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoBack.ForeColor = System.Drawing.Color.Pink;
            this.btn_GoBack.Location = new System.Drawing.Point(397, 207);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(97, 48);
            this.btn_GoBack.TabIndex = 6;
            this.btn_GoBack.Text = "Go Back ";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_SelectCar
            // 
            this.btn_SelectCar.BackColor = System.Drawing.Color.Crimson;
            this.btn_SelectCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectCar.ForeColor = System.Drawing.Color.Pink;
            this.btn_SelectCar.Location = new System.Drawing.Point(130, 207);
            this.btn_SelectCar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SelectCar.Name = "btn_SelectCar";
            this.btn_SelectCar.Size = new System.Drawing.Size(104, 48);
            this.btn_SelectCar.TabIndex = 7;
            this.btn_SelectCar.Text = "Select Car";
            this.btn_SelectCar.UseVisualStyleBackColor = false;
            this.btn_SelectCar.Click += new System.EventHandler(this.btn_SelectCar_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(600, 285);
            this.Controls.Add(this.btn_SelectCar);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.listBoxAvailableCars);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailableCars;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_SelectCar;
    }
}