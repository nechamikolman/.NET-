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
            Manger_Button.BackColor = Color.FromArgb(128, 64, 0);
            Manger_Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manger_Button.Location = new Point(338, 180);
            Manger_Button.Margin = new Padding(3, 4, 3, 4);
            Manger_Button.Name = "Manger_Button";
            Manger_Button.Size = new Size(297, 100);
            Manger_Button.TabIndex = 0;
            Manger_Button.Text = "Manager";
            Manger_Button.UseVisualStyleBackColor = false;
            Manger_Button.Click += Manger_Button_Click;
            // 
            // Cashier_Button
            // 
            Cashier_Button.BackColor = Color.FromArgb(128, 64, 0);
            Cashier_Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_Button.Location = new Point(338, 300);
            Cashier_Button.Margin = new Padding(3, 4, 3, 4);
            Cashier_Button.Name = "Cashier_Button";
            Cashier_Button.Size = new Size(297, 100);
            Cashier_Button.TabIndex = 1;
            Cashier_Button.Text = "Cashier";
            Cashier_Button.UseVisualStyleBackColor = false;
            Cashier_Button.Click += Cashier_Button_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._69b68fd7300b151284f7f44ed452e64a__1_;
            ClientSize = new Size(914, 600);
            Controls.Add(Cashier_Button);
            Controls.Add(Manger_Button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Manger_Button;
        private Button Cashier_Button;
    }
}