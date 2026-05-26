namespace UI
{
    partial class FormCashier
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Order_Button = new Button();
            SuspendLayout();
            // 
            // Order_Button
            // 
            Order_Button.BackColor = Color.FromArgb(128, 64, 0);
            Order_Button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order_Button.Location = new Point(328, 200);
            Order_Button.Margin = new Padding(3, 4, 3, 4);
            Order_Button.Name = "Order_Button";
            Order_Button.Size = new Size(258, 76);
            Order_Button.TabIndex = 0;
            Order_Button.Text = "בניית הזמנה";
            Order_Button.UseVisualStyleBackColor = false;
            Order_Button.Click += Order_Button_Click;
            // 
            // FormCashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 500);
            Controls.Add(Order_Button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCashier";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "קופאי";
            Load += FormCashier_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Order_Button;
    }
}