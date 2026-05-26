namespace UI
{
    partial class FormCustomersManagement
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
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtFilter = new TextBox();
            lblId = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblFilter = new Label();
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
            txtId.Location = new Point(430, 17);
            txtId.Name = "txtId";
            txtId.Size = new Size(160, 27);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(430, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(160, 27);
            txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(430, 97);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(160, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(430, 137);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(160, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(430, 187);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(160, 27);
            txtFilter.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.Location = new Point(600, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(60, 23);
            lblId.TabIndex = 0;
            lblId.Text = "מזהה:";
            // 
            // lblName
            // 
            lblName.Location = new Point(600, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 23);
            lblName.TabIndex = 2;
            lblName.Text = "שם:";
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(600, 100);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(60, 23);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "כתובת:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(600, 140);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(60, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "טלפון:";
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(600, 190);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(90, 23);
            lblFilter.TabIndex = 8;
            lblFilter.Text = "סינון לפי שם:";
            // 
            // btnReadOne
            // 
            btnReadOne.Location = new Point(430, 230);
            btnReadOne.Name = "btnReadOne";
            btnReadOne.Size = new Size(100, 35);
            btnReadOne.TabIndex = 10;
            btnReadOne.BackColor = Color.White;
            btnReadOne.FlatStyle = FlatStyle.Flat;
            btnReadOne.Text = "הצג בודד";
            btnReadOne.Click += btnReadOne_Click;
            // 
            // btnReadAll
            // 
            btnReadAll.Location = new Point(540, 230);
            btnReadAll.Name = "btnReadAll";
            btnReadAll.Size = new Size(100, 35);
            btnReadAll.TabIndex = 11;
            btnReadAll.BackColor = Color.White;
            btnReadAll.FlatStyle = FlatStyle.Flat;
            btnReadAll.Text = "הצג הכל";
            btnReadAll.Click += btnReadAll_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(430, 280);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 35);
            btnCreate.TabIndex = 12;
            btnCreate.BackColor = Color.White;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Text = "הוסף";
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(540, 280);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 13;
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Text = "עדכן";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(430, 325);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 14;
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
            dataGridView.Size = new Size(400, 420);
            dataGridView.TabIndex = 15;
            // 
            // FormCustomersManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 460);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblFilter);
            Controls.Add(txtFilter);
            Controls.Add(btnReadOne);
            Controls.Add(btnReadAll);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView);
            Name = "FormCustomersManagement";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ניהול לקוחות";
            BackColor = Color.FromArgb(128, 64, 0);
            Load += FormCustomersManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtFilter;
        private Label lblId;
        private Label lblName;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblFilter;
        private Button btnReadOne;
        private Button btnReadAll;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView;
    }
}