using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormSaleManagement : Form
    {
        private readonly IBl bl = BlApi.Factory.Get;

        public FormSaleManagement()
        {
            InitializeComponent();
        }

        // ── Read Single ──────────────────────────────────────────────
        private void btnReadOne_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductId.Text, out int id))
            {
                MessageBox.Show("נא להזין מזהה מוצר תקין.");
                return;
            }
            try
            {
                Sale? s = bl.sale.Read(x => x.id_product == id);
                if (s == null) { MessageBox.Show("מבצע לא נמצא."); return; }
                FillFields(s);
                dataGridView.DataSource = new List<Sale?> { s };
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Read All / Filter by general sale ────────────────────────
        private void btnReadAll_Click(object sender, EventArgs e)
        {
            try
            {
                List<Sale?> list;
                if (chkFilterGeneral.Checked)
                    list = bl.sale.ReadAll(s => s.if_general_sale);
                else
                    list = bl.sale.ReadAll();

                dataGridView.DataSource = list;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Create ───────────────────────────────────────────────────
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Sale s = ReadFields();
                int newId = bl.sale.Create(s);
                MessageBox.Show($"מבצע נוסף בהצלחה. מזהה מוצר: {newId}");
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Update ───────────────────────────────────────────────────
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Sale s = ReadFields();
                bl.sale.Update(s);
                MessageBox.Show("מבצע עודכן בהצלחה.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Delete ───────────────────────────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductId.Text, out int id))
            {
                MessageBox.Show("נא להזין מזהה מוצר תקין.");
                return;
            }
            if (MessageBox.Show("למחוק מבצע זה?", "אישור מחיקה", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                bl.sale.Delete(id);
                MessageBox.Show("מבצע נמחק בהצלחה.");
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Helpers ──────────────────────────────────────────────────
        private void FillFields(Sale s)
        {
            txtProductId.Text = s.id_product.ToString();
            txtAmountRequired.Text = s.amount_required.ToString();
            txtFinalPrice.Text = s.final_price.ToString();
            chkGeneralSale.Checked = s.if_general_sale;
            dtpStart.Value = s.date_start_sale;
            dtpEnd.Value = s.date_finish_sale;
        }

        private Sale ReadFields()
        {
            int.TryParse(txtProductId.Text, out int productId);
            int.TryParse(txtAmountRequired.Text, out int amount);
            double.TryParse(txtFinalPrice.Text, out double price);
            return new Sale(productId, amount, price, chkGeneralSale.Checked, dtpStart.Value, dtpEnd.Value);
        }

        private void ClearFields()
        {
            txtProductId.Text = "";
            txtAmountRequired.Text = "";
            txtFinalPrice.Text = "";
            chkGeneralSale.Checked = false;
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
        }

        private void FormSaleManagement_Load(object sender, EventArgs e)
        {

        }
    }
}