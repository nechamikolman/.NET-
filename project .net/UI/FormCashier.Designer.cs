namespace UI
{
    partial class FormCashier
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
            Products_Cashier_Button = new Button();
            Customers_Management_Button = new Button();
            Sale_Management_Button = new Button();
            SuspendLayout();
            // 
            // Products_Cashier_Button
            // 
            Products_Cashier_Button.Location = new Point(319, 97);
            Products_Cashier_Button.Name = "Products_Cashier_Button";
            Products_Cashier_Button.Size = new Size(234, 50);
            Products_Cashier_Button.TabIndex = 0;
            Products_Cashier_Button.Text = "Products Cashier";
            Products_Cashier_Button.UseVisualStyleBackColor = true;
            // 
            // Customers_Management_Button
            // 
            Customers_Management_Button.Location = new Point(319, 162);
            Customers_Management_Button.Name = "Customers_Management_Button";
            Customers_Management_Button.Size = new Size(234, 50);
            Customers_Management_Button.TabIndex = 1;
            Customers_Management_Button.Text = "Customers Management";
            Customers_Management_Button.UseVisualStyleBackColor = true;
            // 
            // Sale_Management_Button
            // 
            Sale_Management_Button.Location = new Point(319, 229);
            Sale_Management_Button.Name = "Sale_Management_Button";
            Sale_Management_Button.Size = new Size(234, 50);
            Sale_Management_Button.TabIndex = 2;
            Sale_Management_Button.Text = "Sales Management";
            Sale_Management_Button.UseVisualStyleBackColor = true;
            // 
            // FormCashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sale_Management_Button);
            Controls.Add(Customers_Management_Button);
            Controls.Add(Products_Cashier_Button);
            Name = "FormCashier";
            Text = "FormCashier";
            ResumeLayout(false);
        }

        #endregion

        private Button Products_Cashier_Button;
        private Button Customers_Management_Button;
        private Button Sale_Management_Button;
    }
}