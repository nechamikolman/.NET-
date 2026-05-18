namespace UI
{
    partial class Main
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
            Manger_Button = new Button();
            Cashier_Button = new Button();
            SuspendLayout();
            // 
            // Manger_Button
            // 
            Manger_Button.Location = new Point(296, 80);
            Manger_Button.Name = "Manger_Button";
            Manger_Button.Size = new Size(260, 124);
            Manger_Button.TabIndex = 0;
            Manger_Button.Text = "Manager";
            Manger_Button.UseVisualStyleBackColor = true;
            Manger_Button.Click += button1_Click;
            // 
            // Cashier_Button
            // 
            Cashier_Button.Location = new Point(296, 225);
            Cashier_Button.Name = "Cashier_Button";
            Cashier_Button.Size = new Size(260, 125);
            Cashier_Button.TabIndex = 1;
            Cashier_Button.Text = "Cashier";
            Cashier_Button.UseVisualStyleBackColor = true;
            Cashier_Button.Click += Cashier_Button_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cashier_Button);
            Controls.Add(Manger_Button);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button Manger_Button;
        private Button Cashier_Button;
    }
}