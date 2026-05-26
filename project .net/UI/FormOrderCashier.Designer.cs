namespace UI
{
    partial class FormOrderCashier
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
            txtProductId = new TextBox();
            txtAmount = new TextBox();
            cmbProducts = new ComboBox();
            chkPreferred = new CheckBox();
            lblProductId = new Label();
            lblAmount = new Label();
            lblProductsList = new Label();
            lblPreferred = new Label();
            lblTotal = new Label();
            btnAddById = new Button();
            btnAddFromList = new Button();
            btnDoOrder = new Button();
            dataGridViewOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            SuspendLayout();
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(460, 17);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(170, 27);
            txtProductId.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(460, 57);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(170, 27);
            txtAmount.TabIndex = 3;
            txtAmount.Text = "1";
            // 
            // cmbProducts
            // 
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.Location = new Point(460, 152);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(170, 28);
            cmbProducts.TabIndex = 6;
            // 
            // chkPreferred
            // 
            chkPreferred.Location = new Point(460, 243);
            chkPreferred.Name = "chkPreferred";
            chkPreferred.Size = new Size(20, 24);
            chkPreferred.TabIndex = 9;
            // 
            // lblProductId
            // 
            lblProductId.Location = new Point(640, 20);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(80, 23);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "מזהה מוצר:";
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(640, 60);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(60, 23);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "כמות:";
            // 
            // lblProductsList
            // 
            lblProductsList.Location = new Point(640, 155);
            lblProductsList.Name = "lblProductsList";
            lblProductsList.Size = new Size(110, 23);
            lblProductsList.TabIndex = 5;
            lblProductsList.Text = "בחר מוצר מרשימה:";
            // 
            // lblPreferred
            // 
            lblPreferred.Location = new Point(640, 245);
            lblPreferred.Name = "lblPreferred";
            lblPreferred.Size = new Size(95, 23);
            lblPreferred.TabIndex = 8;
            lblPreferred.Text = "לקוח מועדפון:";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(460, 285);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(220, 30);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "סכום לתשלום: 0.00 ₪";
            // 
            // btnAddById
            // 
            btnAddById.Location = new Point(460, 100);
            btnAddById.Name = "btnAddById";
            btnAddById.Size = new Size(170, 35);
            btnAddById.TabIndex = 4;
            btnAddById.BackColor = Color.White;
            btnAddById.FlatStyle = FlatStyle.Flat;
            btnAddById.Text = "הוסף לפי קוד";
            btnAddById.Click += btnAddById_Click;
            // 
            // btnAddFromList
            // 
            btnAddFromList.Location = new Point(460, 190);
            btnAddFromList.Name = "btnAddFromList";
            btnAddFromList.Size = new Size(170, 35);
            btnAddFromList.TabIndex = 7;
            btnAddFromList.BackColor = Color.White;
            btnAddFromList.FlatStyle = FlatStyle.Flat;
            btnAddFromList.Text = "הוסף מרשימה";
            btnAddFromList.Click += btnAddFromList_Click;
            // 
            // btnDoOrder
            // 
            btnDoOrder.BackColor = Color.FromArgb(128, 64, 0);
            btnDoOrder.FlatStyle = FlatStyle.Flat;
            btnDoOrder.Location = new Point(460, 330);
            btnDoOrder.Name = "btnDoOrder";
            btnDoOrder.Size = new Size(170, 45);
            btnDoOrder.TabIndex = 11;
            btnDoOrder.Text = "בצע הזמנה";
            btnDoOrder.UseVisualStyleBackColor = false;
            btnDoOrder.Click += btnDoOrder_Click;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AllowUserToAddRows = false;
            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrder.ColumnHeadersHeight = 29;
            dataGridViewOrder.Location = new Point(12, 12);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.ReadOnly = true;
            dataGridViewOrder.RowHeadersWidth = 51;
            dataGridViewOrder.Size = new Size(430, 450);
            dataGridViewOrder.TabIndex = 12;
            // 
            // FormOrderCashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 490);
            Controls.Add(lblProductId);
            Controls.Add(txtProductId);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(btnAddById);
            Controls.Add(lblProductsList);
            Controls.Add(cmbProducts);
            Controls.Add(btnAddFromList);
            Controls.Add(lblPreferred);
            Controls.Add(chkPreferred);
            Controls.Add(lblTotal);
            Controls.Add(btnDoOrder);
            Controls.Add(dataGridViewOrder);
            Name = "FormOrderCashier";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "בניית הזמנה";
            BackColor = Color.FromArgb(128, 64, 0);
            Load += FormOrderCashier_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductId;
        private TextBox txtAmount;
        private ComboBox cmbProducts;
        private CheckBox chkPreferred;
        private Label lblProductId;
        private Label lblAmount;
        private Label lblProductsList;
        private Label lblPreferred;
        private Label lblTotal;
        private Button btnAddById;
        private Button btnAddFromList;
        private Button btnDoOrder;
        private DataGridView dataGridViewOrder;
    }
}