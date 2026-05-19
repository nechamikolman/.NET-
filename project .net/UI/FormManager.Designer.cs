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
            Products_Management_Button.Location = new Point(349, 123);
            Products_Management_Button.Margin = new Padding(3, 4, 3, 4);
            Products_Management_Button.Name = "Products_Management_Button";
            Products_Management_Button.Size = new Size(258, 76);
            Products_Management_Button.TabIndex = 0;
            Products_Management_Button.Text = "Products Management";
            Products_Management_Button.UseVisualStyleBackColor = true;
            Products_Management_Button.Click += Products_Management_Button_Click;
            // 
            // Customers_Management_Button
            // 
            Customers_Management_Button.Location = new Point(349, 227);
            Customers_Management_Button.Margin = new Padding(3, 4, 3, 4);
            Customers_Management_Button.Name = "Customers_Management_Button";
            Customers_Management_Button.Size = new Size(258, 76);
            Customers_Management_Button.TabIndex = 1;
            Customers_Management_Button.Text = "Customers Management";
            Customers_Management_Button.UseVisualStyleBackColor = true;
            Customers_Management_Button.Click += Customers_Management_Button_Click;
            // 
            // Sale_Management_Button
            // 
            Sale_Management_Button.Location = new Point(349, 325);
            Sale_Management_Button.Margin = new Padding(3, 4, 3, 4);
            Sale_Management_Button.Name = "Sale_Management_Button";
            Sale_Management_Button.Size = new Size(258, 76);
            Sale_Management_Button.TabIndex = 2;
            Sale_Management_Button.Text = "Sales Management";
            Sale_Management_Button.UseVisualStyleBackColor = true;
            Sale_Management_Button.Click += Sale_Management_Button_Click;
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._69b68fd7300b151284f7f44ed452e64a__1_;
            ClientSize = new Size(914, 600);
            Controls.Add(Sale_Management_Button);
            Controls.Add(Customers_Management_Button);
            Controls.Add(Products_Management_Button);
            Margin = new Padding(3, 4, 3, 4);
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