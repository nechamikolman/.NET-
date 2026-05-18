namespace UI
{
    partial class FormManager
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
            Products_Management_Button = new Button();
            Customers_Management_Button = new Button();
            Sale_Management_Button = new Button();
            SuspendLayout();
            // 
            // Products_Management_Button
            // 
            Products_Management_Button.Location = new Point(305, 92);
            Products_Management_Button.Name = "Products_Management_Button";
            Products_Management_Button.Size = new Size(226, 57);
            Products_Management_Button.TabIndex = 0;
            Products_Management_Button.Text = "Products Management";
            Products_Management_Button.UseVisualStyleBackColor = true;
            // 
            // Customers_Management_Button
            // 
            Customers_Management_Button.Location = new Point(305, 170);
            Customers_Management_Button.Name = "Customers_Management_Button";
            Customers_Management_Button.Size = new Size(226, 57);
            Customers_Management_Button.TabIndex = 1;
            Customers_Management_Button.Text = "Customers Management";
            Customers_Management_Button.UseVisualStyleBackColor = true;
            // 
            // Sale_Management_Button
            // 
            Sale_Management_Button.Location = new Point(305, 244);
            Sale_Management_Button.Name = "Sale_Management_Button";
            Sale_Management_Button.Size = new Size(226, 57);
            Sale_Management_Button.TabIndex = 2;
            Sale_Management_Button.Text = "Sales Management";
            Sale_Management_Button.UseVisualStyleBackColor = true;
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sale_Management_Button);
            Controls.Add(Customers_Management_Button);
            Controls.Add(Products_Management_Button);
            Name = "FormManager";
            Text = "FormManager";
            ResumeLayout(false);
        }

        #endregion

        private Button Products_Management_Button;
        private Button Customers_Management_Button;
        private Button Sale_Management_Button;
    }
}