namespace UI
{
    partial class FormProductsManagement
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
            txtId = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtAmount = new TextBox();
            cmbCategory = new ComboBox();
            cmbFilterCategory = new ComboBox();
            lblId = new Label();
            lblName = new Label();
            lblPrice = new Label();
            lblAmount = new Label();
            lblCategory = new Label();
            lblFilterCategory = new Label();
            btnReadOne = new Button();
            btnReadAll = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();

            // lblId
            lblId.Text = "מזהה:";
            lblId.Location = new Point(640, 20);
            lblId.Size = new Size(60, 23);

            // txtId
            txtId.Location = new Point(460, 17);
            txtId.Size = new Size(170, 27);

            // lblName
            lblName.Text = "שם:";
            lblName.Location = new Point(640, 60);
            lblName.Size = new Size(60, 23);

            // txtName
            txtName.Location = new Point(460, 57);
            txtName.Size = new Size(170, 27);

            // lblPrice
            lblPrice.Text = "מחיר:";
            lblPrice.Location = new Point(640, 100);
            lblPrice.Size = new Size(60, 23);

            // txtPrice
            txtPrice.Location = new Point(460, 97);
            txtPrice.Size = new Size(170, 27);

            // lblAmount
            lblAmount.Text = "כמות:";
            lblAmount.Location = new Point(640, 140);
            lblAmount.Size = new Size(60, 23);

            // txtAmount
            txtAmount.Location = new Point(460, 137);
            txtAmount.Size = new Size(170, 27);

            // lblCategory
            lblCategory.Text = "קטגוריה:";
            lblCategory.Location = new Point(640, 180);
            lblCategory.Size = new Size(70, 23);

            // cmbCategory
            cmbCategory.Location = new Point(460, 177);
            cmbCategory.Size = new Size(170, 28);
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            // lblFilterCategory
            lblFilterCategory.Text = "סינון קטגוריה:";
            lblFilterCategory.Location = new Point(640, 225);
            lblFilterCategory.Size = new Size(90, 23);

            // cmbFilterCategory
            cmbFilterCategory.Location = new Point(460, 222);
            cmbFilterCategory.Size = new Size(170, 28);
            cmbFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterCategory.Items.Insert(0, "הכל");
            cmbFilterCategory.SelectedIndex = 0;

            // btnReadOne
            btnReadOne.Text = "הצג בודד";
            btnReadOne.Location = new Point(460, 265);
            btnReadOne.Size = new Size(100, 35);
            btnReadOne.Click += btnReadOne_Click;

            // btnReadAll
            btnReadAll.Text = "הצג הכל";
            btnReadAll.Location = new Point(570, 265);
            btnReadAll.Size = new Size(100, 35);
            btnReadAll.Click += btnReadAll_Click;

            // btnCreate
            btnCreate.Text = "הוסף";
            btnCreate.Location = new Point(460, 310);
            btnCreate.Size = new Size(100, 35);
            btnCreate.Click += btnCreate_Click;

            // btnUpdate
            btnUpdate.Text = "עדכן";
            btnUpdate.Location = new Point(570, 310);
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.Click += btnUpdate_Click;

            // btnDelete
            btnDelete.Text = "מחק";
            btnDelete.Location = new Point(460, 355);
            btnDelete.Size = new Size(100, 35);
            btnDelete.Click += btnDelete_Click;

            // dataGridView
            dataGridView.Location = new Point(12, 12);
            dataGridView.Size = new Size(430, 430);
            dataGridView.ReadOnly = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;

            // FormProductsManagement
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 470);
            Text = "ניהול מוצרים";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblFilterCategory);
            Controls.Add(cmbFilterCategory);
            Controls.Add(btnReadOne);
            Controls.Add(btnReadAll);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtAmount;
        private ComboBox cmbCategory;
        private ComboBox cmbFilterCategory;
        private Label lblId;
        private Label lblName;
        private Label lblPrice;
        private Label lblAmount;
        private Label lblCategory;
        private Label lblFilterCategory;
        private Button btnReadOne;
        private Button btnReadAll;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView;
    }
}