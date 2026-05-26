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
            // 
            // txtId
            // 
            txtId.Location = new Point(460, 17);
            txtId.Name = "txtId";
            txtId.Size = new Size(170, 27);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(460, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 27);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(460, 97);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(170, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(460, 137);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(170, 27);
            txtAmount.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(460, 177);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(170, 28);
            cmbCategory.TabIndex = 9;
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterCategory.Items.AddRange(new object[] { "הכל" });
            cmbFilterCategory.Location = new Point(460, 222);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(170, 28);
            cmbFilterCategory.TabIndex = 11;
            // 
            // lblId
            // 
            lblId.Location = new Point(640, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(60, 23);
            lblId.TabIndex = 0;
            lblId.Text = "מזהה:";
            // 
            // lblName
            // 
            lblName.Location = new Point(640, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 23);
            lblName.TabIndex = 2;
            lblName.Text = "שם:";
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(640, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(60, 23);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "מחיר:";
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(640, 140);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(60, 23);
            lblAmount.TabIndex = 6;
            lblAmount.Text = "כמות:";
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(640, 180);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(70, 23);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "קטגוריה:";
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.Location = new Point(640, 225);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(90, 23);
            lblFilterCategory.TabIndex = 10;
            lblFilterCategory.Text = "סינון קטגוריה:";
            // 
            // btnReadOne
            // 
            btnReadOne.Location = new Point(460, 265);
            btnReadOne.Name = "btnReadOne";
            btnReadOne.Size = new Size(100, 35);
            btnReadOne.TabIndex = 12;
            btnReadOne.BackColor = Color.White;
            btnReadOne.FlatStyle = FlatStyle.Flat;
            btnReadOne.Text = "הצג בודד";
            btnReadOne.Click += btnReadOne_Click;
            // 
            // btnReadAll
            // 
            btnReadAll.Location = new Point(570, 265);
            btnReadAll.Name = "btnReadAll";
            btnReadAll.Size = new Size(100, 35);
            btnReadAll.TabIndex = 13;
            btnReadAll.BackColor = Color.White;
            btnReadAll.FlatStyle = FlatStyle.Flat;
            btnReadAll.Text = "הצג הכל";
            btnReadAll.Click += btnReadAll_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(460, 310);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 35);
            btnCreate.TabIndex = 14;
            btnCreate.BackColor = Color.White;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Text = "הוסף";
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(570, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 15;
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Text = "עדכן";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(460, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 16;
            btnDelete.BackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Text = "מחק";
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(430, 430);
            dataGridView.TabIndex = 17;
            // 
            // FormProductsManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 470);
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
            Name = "FormProductsManagement";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ניהול מוצרים";
            BackColor = Color.FromArgb(128, 64, 0);
            Load += FormProductsManagement_Load;
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