namespace UI
{
    partial class FormSaleManagement
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
            txtAmountRequired = new TextBox();
            txtFinalPrice = new TextBox();
            chkGeneralSale = new CheckBox();
            chkFilterGeneral = new CheckBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            lblProductId = new Label();
            lblAmountRequired = new Label();
            lblFinalPrice = new Label();
            lblGeneralSale = new Label();
            lblStart = new Label();
            lblEnd = new Label();
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
            // txtProductId
            // 
            txtProductId.Location = new Point(460, 17);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(170, 27);
            txtProductId.TabIndex = 1;
            // 
            // txtAmountRequired
            // 
            txtAmountRequired.Location = new Point(460, 57);
            txtAmountRequired.Name = "txtAmountRequired";
            txtAmountRequired.Size = new Size(170, 27);
            txtAmountRequired.TabIndex = 3;
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.Location = new Point(460, 97);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.Size = new Size(170, 27);
            txtFinalPrice.TabIndex = 5;
            // 
            // chkGeneralSale
            // 
            chkGeneralSale.Location = new Point(460, 138);
            chkGeneralSale.Name = "chkGeneralSale";
            chkGeneralSale.Size = new Size(20, 24);
            chkGeneralSale.TabIndex = 7;
            // 
            // chkFilterGeneral
            // 
            chkFilterGeneral.Location = new Point(460, 258);
            chkFilterGeneral.Name = "chkFilterGeneral";
            chkFilterGeneral.Size = new Size(20, 24);
            chkFilterGeneral.TabIndex = 13;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(460, 175);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(170, 27);
            dtpStart.TabIndex = 9;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(460, 215);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(170, 27);
            dtpEnd.TabIndex = 11;
            // 
            // lblProductId
            // 
            lblProductId.Location = new Point(640, 20);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(80, 23);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "מזהה מוצר:";
            // 
            // lblAmountRequired
            // 
            lblAmountRequired.Location = new Point(640, 60);
            lblAmountRequired.Name = "lblAmountRequired";
            lblAmountRequired.Size = new Size(85, 23);
            lblAmountRequired.TabIndex = 2;
            lblAmountRequired.Text = "כמות נדרשת:";
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.Location = new Point(640, 100);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(75, 23);
            lblFinalPrice.TabIndex = 4;
            lblFinalPrice.Text = "מחיר סופי:";
            // 
            // lblGeneralSale
            // 
            lblGeneralSale.Location = new Point(640, 140);
            lblGeneralSale.Name = "lblGeneralSale";
            lblGeneralSale.Size = new Size(80, 23);
            lblGeneralSale.TabIndex = 6;
            lblGeneralSale.Text = "מבצע כללי:";
            // 
            // lblStart
            // 
            lblStart.Location = new Point(640, 178);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(95, 23);
            lblStart.TabIndex = 8;
            lblStart.Text = "תאריך התחלה:";
            // 
            // lblEnd
            // 
            lblEnd.Location = new Point(640, 218);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(85, 23);
            lblEnd.TabIndex = 10;
            lblEnd.Text = "תאריך סיום:";
            // 
            // lblFilter
            // 
            lblFilter.Location = new Point(640, 260);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(110, 23);
            lblFilter.TabIndex = 12;
            lblFilter.Text = "סינון: כלליים בלבד";
            // 
            // btnReadOne
            // 
            btnReadOne.Location = new Point(460, 295);
            btnReadOne.Name = "btnReadOne";
            btnReadOne.Size = new Size(100, 35);
            btnReadOne.TabIndex = 14;
            btnReadOne.BackColor = Color.White;
            btnReadOne.FlatStyle = FlatStyle.Flat;
            btnReadOne.Text = "הצג בודד";
            btnReadOne.Click += btnReadOne_Click;
            // 
            // btnReadAll
            // 
            btnReadAll.Location = new Point(570, 295);
            btnReadAll.Name = "btnReadAll";
            btnReadAll.Size = new Size(100, 35);
            btnReadAll.TabIndex = 15;
            btnReadAll.BackColor = Color.White;
            btnReadAll.FlatStyle = FlatStyle.Flat;
            btnReadAll.Text = "הצג הכל";
            btnReadAll.Click += btnReadAll_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(460, 340);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 35);
            btnCreate.TabIndex = 16;
            btnCreate.BackColor = Color.White;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Text = "הוסף";
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(570, 340);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 17;
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Text = "עדכן";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(460, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 18;
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
            dataGridView.Size = new Size(430, 450);
            dataGridView.TabIndex = 19;
            // 
            // FormSaleManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 490);
            Controls.Add(lblProductId);
            Controls.Add(txtProductId);
            Controls.Add(lblAmountRequired);
            Controls.Add(txtAmountRequired);
            Controls.Add(lblFinalPrice);
            Controls.Add(txtFinalPrice);
            Controls.Add(lblGeneralSale);
            Controls.Add(chkGeneralSale);
            Controls.Add(lblStart);
            Controls.Add(dtpStart);
            Controls.Add(lblEnd);
            Controls.Add(dtpEnd);
            Controls.Add(lblFilter);
            Controls.Add(chkFilterGeneral);
            Controls.Add(btnReadOne);
            Controls.Add(btnReadAll);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView);
            Name = "FormSaleManagement";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ניהול מבצעים";
            BackColor = Color.FromArgb(128, 64, 0);
            Load += FormSaleManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductId;
        private TextBox txtAmountRequired;
        private TextBox txtFinalPrice;
        private CheckBox chkGeneralSale;
        private CheckBox chkFilterGeneral;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label lblProductId;
        private Label lblAmountRequired;
        private Label lblFinalPrice;
        private Label lblGeneralSale;
        private Label lblStart;
        private Label lblEnd;
        private Label lblFilter;
        private Button btnReadOne;
        private Button btnReadAll;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView;
    }
}