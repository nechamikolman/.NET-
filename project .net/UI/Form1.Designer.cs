namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcom_button = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // welcom_button
            // 
            welcom_button.BackColor = Color.FromArgb(128, 64, 0);
            welcom_button.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcom_button.ForeColor = SystemColors.WindowText;
            welcom_button.Location = new Point(12, 324);
            welcom_button.Name = "welcom_button";
            welcom_button.Size = new Size(241, 93);
            welcom_button.TabIndex = 0;
            welcom_button.Text = "welcome";
            welcom_button.UseVisualStyleBackColor = false;
            welcom_button.Click += welcom_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 64, 0);
            label1.Font = new Font("Snap ITC", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 26);
            label1.Name = "label1";
            label1.Size = new Size(157, 61);
            label1.TabIndex = 1;
            label1.Text = "Cafe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.סוגי_קפה_מומלצים_768x432;
            ClientSize = new Size(800, 451);
            Controls.Add(label1);
            Controls.Add(welcom_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button welcom_button;
        private Label label1;
    }
}
