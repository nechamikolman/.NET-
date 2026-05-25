using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormOrderCashier : Form
    {
        private readonly IBl bl = BlApi.Factory.Get;
        private readonly Order _order = new Order();

        public FormOrderCashier()
        {
            InitializeComponent();
            LoadProductsCombo();
            RefreshOrderDisplay();
        }

        // ── Load products into combo box ─────────────────────────────
        private void LoadProductsCombo()
        {
            try
            {
                var products = bl.product.ReadAll();
                cmbProducts.DataSource = products;
                cmbProducts.DisplayMember = "name";
                cmbProducts.ValueMember = "id";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Add product by ID (typed) ────────────────────────────────
        private void btnAddById_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductId.Text, out int id))
            {
                MessageBox.Show("נא להזין מזהה מוצר תקין.");
                return;
            }
            if (!int.TryParse(txtAmount.Text, out int amount) || amount <= 0)
            {
                MessageBox.Show("נא להזין כמות תקינה.");
                return;
            }
            try
            {
                bl.order.AddProductToOrder(_order, id, amount);
                bl.order.CalcTotalPrice(_order);
                RefreshOrderDisplay();
                txtProductId.Text = "";
                txtAmount.Text = "1";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Add product from combo box ───────────────────────────────
        private void btnAddFromList_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedValue is not int id)
            {
                MessageBox.Show("נא לבחור מוצר מהרשימה.");
                return;
            }
            if (!int.TryParse(txtAmount.Text, out int amount) || amount <= 0)
            {
                MessageBox.Show("נא להזין כמות תקינה.");
                return;
            }
            try
            {
                bl.order.AddProductToOrder(_order, id, amount);
                bl.order.CalcTotalPrice(_order);
                RefreshOrderDisplay();
                txtAmount.Text = "1";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Do Order ────────────────────────────────────────────────
        private void btnDoOrder_Click(object sender, EventArgs e)
        {
            if (_order.Products == null || _order.Products.Count == 0)
            {
                MessageBox.Show("ההזמנה ריקה. יש להוסיף מוצרים תחילה.");
                return;
            }
            if (MessageBox.Show("לסיים הזמנה?", "אישור הזמנה", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                _order.IsPreferredClient = chkPreferred.Checked;
                bl.order.DoOrder(_order);
                MessageBox.Show($"ההזמנה בוצעה בהצלחה!\nסכום סופי: {_order.TotalPrice:F2} ₪");
                _order.Products!.Clear();
                _order.TotalPrice = 0;
                RefreshOrderDisplay();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Refresh order display ────────────────────────────────────
        private void RefreshOrderDisplay()
        {
            dataGridViewOrder.DataSource = null;
            dataGridViewOrder.DataSource = _order.Products;
            lblTotal.Text = $"סכום לתשלום: {_order.TotalPrice:F2} ₪";
        }

        private void FormOrderCashier_Load(object sender, EventArgs e)
        {

        }
    }
}