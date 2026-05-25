using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI
{
    public partial class FormProductsManagement : Form
    {
        private readonly IBl bl = BlApi.Factory.Get();

        public FormProductsManagement()
        {
            InitializeComponent();
            cmbCategory.DataSource = Enum.GetValues(typeof(Categorys));
        }

        // ── Read Single ──────────────────────────────────────────────
        private void btnReadOne_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("נא להזין מזהה תקין.");
                return;
            }
            try
            {
                Product? p = bl.product.Read(x => x.id == id);
                if (p == null) { MessageBox.Show("מוצר לא נמצא."); return; }
                FillFields(p);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Read All / Filter by Category ────────────────────────────
        private void btnReadAll_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product?> list;
                if (cmbFilterCategory.SelectedItem is Categorys cat)
                    list = bl.product.ReadAll(p => p.category == cat);
                else
                    list = bl.product.ReadAll();

                dataGridView.DataSource = list;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Create ───────────────────────────────────────────────────
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = ReadFields();
                int newId = bl.product.Create(p);
                MessageBox.Show($"מוצר נוסף בהצלחה. מזהה: {newId}");
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Update ───────────────────────────────────────────────────
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = ReadFields();
                bl.product.Update(p);
                MessageBox.Show("מוצר עודכן בהצלחה.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Delete ───────────────────────────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("נא להזין מזהה תקין.");
                return;
            }
            if (MessageBox.Show("למחוק מוצר זה?", "אישור מחיקה", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                bl.product.Delete(id);
                MessageBox.Show("מוצר נמחק בהצלחה.");
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Helpers ──────────────────────────────────────────────────
        private void FillFields(Product p)
        {
            txtId.Text = p.id.ToString();
            txtName.Text = p.name;
            txtPrice.Text = p.price.ToString();
            txtAmount.Text = p.amount.ToString();
            cmbCategory.SelectedItem = p.category;
        }

        private Product ReadFields()
        {
            int.TryParse(txtId.Text, out int id);
            double.TryParse(txtPrice.Text, out double price);
            int.TryParse(txtAmount.Text, out int amount);
            Categorys cat = cmbCategory.SelectedItem is Categorys c ? c : Categorys.Coffee;
            return new Product(id, cat, txtName.Text, price, amount);
        }

        private void ClearFields()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtAmount.Text = "";
        }
    }
}