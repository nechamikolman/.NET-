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
    public partial class FormCustomersManagement : Form
    {
        private readonly IBl bl = BlApi.Factory.Get;

        public FormCustomersManagement()
        {
            InitializeComponent();
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
                Customer? c = bl.customer.Read(x => x.id == id);
                if (c == null) { MessageBox.Show("לקוח לא נמצא."); return; }
                FillFields(c);
                dataGridView.DataSource = new List<Customer?> { c };
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Read All / Filter ────────────────────────────────────────
        private void btnReadAll_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = txtFilter.Text.Trim();
                List<Customer?> list = string.IsNullOrEmpty(filter)
                    ? bl.customer.ReadAll()
                    : bl.customer.ReadAll(c => c.name.Contains(filter, StringComparison.OrdinalIgnoreCase));

                dataGridView.DataSource = list;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Create ───────────────────────────────────────────────────
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = ReadFields();
                int newId = bl.customer.Create(c);
                MessageBox.Show($"לקוח נוסף בהצלחה. מזהה: {newId}");
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Update ───────────────────────────────────────────────────
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = ReadFields();
                bl.customer.Update(c);
                MessageBox.Show("לקוח עודכן בהצלחה.");
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
            if (MessageBox.Show("למחוק לקוח זה?", "אישור מחיקה", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                bl.customer.Delete(id);
                MessageBox.Show("לקוח נמחק בהצלחה.");
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // ── Helpers ──────────────────────────────────────────────────
        private void FillFields(Customer c)
        {
            txtId.Text = c.id.ToString();
            txtName.Text = c.name;
            txtAddress.Text = c.address;
            txtPhone.Text = c.phone;
        }

        private Customer ReadFields()
        {
            int.TryParse(txtId.Text, out int id);
            return new Customer(id, txtName.Text, txtAddress.Text, txtPhone.Text);
        }

        private void ClearFields()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        private void FormCustomersManagement_Load(object sender, EventArgs e)
        {

        }
    }
}